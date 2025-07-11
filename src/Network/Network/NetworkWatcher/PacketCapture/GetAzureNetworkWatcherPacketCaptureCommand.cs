﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using AutoMapper;
using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Network;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using MNM = Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "NetworkWatcherPacketCapture", DefaultParameterSetName = "SetByResource"), OutputType(typeof(PSGetPacketCaptureResult))]

    public class GetAzureNetworkWatcherPacketCaptureCommand : PacketCaptureBaseCmdlet
    {
        [Parameter(
             Mandatory = true,
             ValueFromPipeline = true,
             HelpMessage = "The network watcher resource.",
             ParameterSetName = "SetByResource")]
        [ValidateNotNull]
        public PSNetworkWatcher NetworkWatcher { get; set; }

        [Alias("Name")]
        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            HelpMessage = "The name of network watcher.",
            ParameterSetName = "SetByName")]
        [ResourceNameCompleter("Microsoft.Network/networkWatchers", "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public string NetworkWatcherName { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The name of the network watcher resource group.",
            ParameterSetName = "SetByName")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "Location of the network watcher.",
            ParameterSetName = "SetByLocation")]
        [LocationCompleter("Microsoft.Network/networkWatchers")]
        [ValidateNotNull]
        public string Location { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The packet capture name.")]
        [ResourceNameCompleter("Microsoft.Network/networkWatchers/packetCaptures", "ResourceGroupName", "NetworkWatcherName")]
        [ValidateNotNullOrEmpty]
        [SupportsWildcards]
        public string PacketCaptureName { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void Execute()
        {
            base.Execute();

            string resourceGroupName;
            string name;

            if (string.Equals(this.ParameterSetName, "SetByLocation", StringComparison.OrdinalIgnoreCase))
            {
                var networkWatcher = this.GetNetworkWatcherByLocation(this.Location);

                if (networkWatcher == null)
                {
                    throw new ArgumentException("There is no network watcher in location {0}", this.Location);
                }

                resourceGroupName = NetworkBaseCmdlet.GetResourceGroup(networkWatcher.Id);
                name = networkWatcher.Name;
            }
            else if (string.Equals(this.ParameterSetName, "SetByResource", StringComparison.OrdinalIgnoreCase))
            {
                resourceGroupName = this.NetworkWatcher.ResourceGroupName;
                name = this.NetworkWatcher.Name;
            }
            else
            {
                resourceGroupName = this.ResourceGroupName;
                name = this.NetworkWatcherName;
            }

            if (ShouldGetByName(resourceGroupName, PacketCaptureName))
            {
                PSPacketCaptureResult psPacketCapture = new PSPacketCaptureResult();
                psPacketCapture = this.GetPacketCapture(resourceGroupName, name, this.PacketCaptureName);

                PSGetPacketCaptureResult pcResult = new PSGetPacketCaptureResult();

                try
                {
                    var packetCaptureStatus = this.PacketCaptures.GetStatus(resourceGroupName, name, this.PacketCaptureName);
                    pcResult.CaptureStartTime = packetCaptureStatus.CaptureStartTime;

                    pcResult.PacketCaptureError = new List<string>();

                    if (packetCaptureStatus.PacketCaptureError != null)
                    {
                        foreach (var error in packetCaptureStatus.PacketCaptureError)
                        {
                            pcResult.PacketCaptureError.Add(error);
                        }
                    }
                    pcResult.PacketCaptureStatus = packetCaptureStatus.PacketCaptureStatus;
                    pcResult.StopReason = packetCaptureStatus.StopReason;
                    if (psPacketCapture.ContinuousCapture != null)
                    {
                        pcResult.ContinuousCapture = psPacketCapture.ContinuousCapture;
                        pcResult.CaptureSettings = psPacketCapture.CaptureSettings;
                    }
                }
                catch
                {
                    pcResult.CaptureStartTime = null;
                    pcResult.PacketCaptureError = null;
                    pcResult.PacketCaptureStatus = null;
                    pcResult.StopReason = null;
                }
                finally
                {
                    pcResult.BytesToCapturePerPacket = psPacketCapture.BytesToCapturePerPacket;
                    pcResult.TotalBytesPerSession = psPacketCapture.TotalBytesPerSession;
                    pcResult.Etag = psPacketCapture.Etag;
                    pcResult.Filters = psPacketCapture.Filters;
                    pcResult.Id = psPacketCapture.Id;
                    pcResult.Name = psPacketCapture.Name;
                    pcResult.ProvisioningState = psPacketCapture.ProvisioningState;
                    pcResult.StorageLocation = psPacketCapture.StorageLocation;
                    pcResult.Target = psPacketCapture.Target;
                    pcResult.TargetType = psPacketCapture.TargetType;
                    pcResult.TimeLimitInSeconds = psPacketCapture.TimeLimitInSeconds;
                }

                WriteObject(pcResult);
            }
            else
            {
                List<PSPacketCaptureResult> psPacketCaptureList = new List<PSPacketCaptureResult>();

                var packetCaptureList = this.PacketCaptures.List(resourceGroupName, name);
                var pcResultList = new List<PSGetPacketCaptureResult>();

                foreach (var pc in packetCaptureList)
                {

                    PSPacketCaptureResult psPacketCapture = NetworkResourceManagerProfile.Mapper.Map<PSPacketCaptureResult>(pc);
                    psPacketCaptureList.Add(psPacketCapture);

                    PSGetPacketCaptureResult pcResult = new PSGetPacketCaptureResult();

                    try
                    {
                        var packetCaptureStatus = this.PacketCaptures.GetStatus(resourceGroupName, name, psPacketCapture.Name);
                        var psPacketCaptureStatus = NetworkResourceManagerProfile.Mapper.Map<PSPacketCaptureStatus>(packetCaptureStatus);

                        pcResult.CaptureStartTime = psPacketCaptureStatus.CaptureStartTime;
                        pcResult.PacketCaptureError = new List<string>();

                        if (packetCaptureStatus.PacketCaptureError != null)
                        {
                            foreach (var error in packetCaptureStatus.PacketCaptureError)
                            {
                                pcResult.PacketCaptureError.Add(error);
                            }
                        }
                        pcResult.PacketCaptureStatus = psPacketCaptureStatus.PacketCaptureStatus;
                        pcResult.StopReason = psPacketCaptureStatus.StopReason;
                        if (psPacketCapture.ContinuousCapture != null)
                        {
                            pcResult.ContinuousCapture = psPacketCapture.ContinuousCapture;
                            pcResult.CaptureSettings = psPacketCapture.CaptureSettings;
                        }
                    }
                    catch
                    {
                        pcResult.CaptureStartTime = null;
                        pcResult.PacketCaptureError = null;
                        pcResult.PacketCaptureStatus = null;
                        pcResult.StopReason = null;
                    }
                    finally
                    {
                        pcResult.BytesToCapturePerPacket = psPacketCapture.BytesToCapturePerPacket;
                        pcResult.TotalBytesPerSession = psPacketCapture.TotalBytesPerSession;
                        pcResult.Etag = psPacketCapture.Etag;
                        pcResult.Filters = psPacketCapture.Filters;
                        pcResult.Id = psPacketCapture.Id;
                        pcResult.Name = psPacketCapture.Name;
                        pcResult.StorageLocation = psPacketCapture.StorageLocation;
                        pcResult.Target = psPacketCapture.Target;
                        pcResult.TargetType = psPacketCapture.TargetType;
                        pcResult.TimeLimitInSeconds = psPacketCapture.TimeLimitInSeconds;
                        pcResult.ProvisioningState = psPacketCapture.ProvisioningState;
                    }

                    pcResultList.Add(pcResult);
                }

                WriteObject(SubResourceWildcardFilter(PacketCaptureName, pcResultList), true);
            }
        }
    }
}
