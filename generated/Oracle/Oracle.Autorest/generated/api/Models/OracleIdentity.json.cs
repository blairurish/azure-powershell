// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Extensions;

    public partial class OracleIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IOracleIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IOracleIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IOracleIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonObject json ? new OracleIdentity(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonObject into a new instance of <see cref="OracleIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OracleIdentity(Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)_subscriptionId;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)_resourceGroupName;}
            {_autonomousdatabasename = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("autonomousdatabasename"), out var __jsonAutonomousdatabasename) ? (string)__jsonAutonomousdatabasename : (string)_autonomousdatabasename;}
            {_cloudexadatainfrastructurename = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("cloudexadatainfrastructurename"), out var __jsonCloudexadatainfrastructurename) ? (string)__jsonCloudexadatainfrastructurename : (string)_cloudexadatainfrastructurename;}
            {_cloudvmclustername = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("cloudvmclustername"), out var __jsonCloudvmclustername) ? (string)__jsonCloudvmclustername : (string)_cloudvmclustername;}
            {_exadbVMClusterName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("exadbVmClusterName"), out var __jsonExadbVMClusterName) ? (string)__jsonExadbVMClusterName : (string)_exadbVMClusterName;}
            {_exascaleDbStorageVaultName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("exascaleDbStorageVaultName"), out var __jsonExascaleDbStorageVaultName) ? (string)__jsonExascaleDbStorageVaultName : (string)_exascaleDbStorageVaultName;}
            {_location = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("location"), out var __jsonLocation) ? (string)__jsonLocation : (string)_location;}
            {_adbscharsetname = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("adbscharsetname"), out var __jsonAdbscharsetname) ? (string)__jsonAdbscharsetname : (string)_adbscharsetname;}
            {_adbsncharsetname = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("adbsncharsetname"), out var __jsonAdbsncharsetname) ? (string)__jsonAdbsncharsetname : (string)_adbsncharsetname;}
            {_autonomousdbversionsname = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("autonomousdbversionsname"), out var __jsonAutonomousdbversionsname) ? (string)__jsonAutonomousdbversionsname : (string)_autonomousdbversionsname;}
            {_dbsystemshapename = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("dbsystemshapename"), out var __jsonDbsystemshapename) ? (string)__jsonDbsystemshapename : (string)_dbsystemshapename;}
            {_dnsprivateviewocid = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("dnsprivateviewocid"), out var __jsonDnsprivateviewocid) ? (string)__jsonDnsprivateviewocid : (string)_dnsprivateviewocid;}
            {_dnsprivatezonename = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("dnsprivatezonename"), out var __jsonDnsprivatezonename) ? (string)__jsonDnsprivatezonename : (string)_dnsprivatezonename;}
            {_flexComponentName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("flexComponentName"), out var __jsonFlexComponentName) ? (string)__jsonFlexComponentName : (string)_flexComponentName;}
            {_giversionname = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("giversionname"), out var __jsonGiversionname) ? (string)__jsonGiversionname : (string)_giversionname;}
            {_giMinorVersionName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("giMinorVersionName"), out var __jsonGiMinorVersionName) ? (string)__jsonGiMinorVersionName : (string)_giMinorVersionName;}
            {_systemversionname = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("systemversionname"), out var __jsonSystemversionname) ? (string)__jsonSystemversionname : (string)_systemversionname;}
            {_adbbackupid = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("adbbackupid"), out var __jsonAdbbackupid) ? (string)__jsonAdbbackupid : (string)_adbbackupid;}
            {_dbserverocid = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("dbserverocid"), out var __jsonDbserverocid) ? (string)__jsonDbserverocid : (string)_dbserverocid;}
            {_dbnodeocid = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("dbnodeocid"), out var __jsonDbnodeocid) ? (string)__jsonDbnodeocid : (string)_dbnodeocid;}
            {_virtualnetworkaddressname = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("virtualnetworkaddressname"), out var __jsonVirtualnetworkaddressname) ? (string)__jsonVirtualnetworkaddressname : (string)_virtualnetworkaddressname;}
            {_exascaleDbNodeName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("exascaleDbNodeName"), out var __jsonExascaleDbNodeName) ? (string)__jsonExascaleDbNodeName : (string)_exascaleDbNodeName;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)_id;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OracleIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OracleIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._autonomousdatabasename)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._autonomousdatabasename.ToString()) : null, "autonomousdatabasename" ,container.Add );
            AddIf( null != (((object)this._cloudexadatainfrastructurename)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._cloudexadatainfrastructurename.ToString()) : null, "cloudexadatainfrastructurename" ,container.Add );
            AddIf( null != (((object)this._cloudvmclustername)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._cloudvmclustername.ToString()) : null, "cloudvmclustername" ,container.Add );
            AddIf( null != (((object)this._exadbVMClusterName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._exadbVMClusterName.ToString()) : null, "exadbVmClusterName" ,container.Add );
            AddIf( null != (((object)this._exascaleDbStorageVaultName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._exascaleDbStorageVaultName.ToString()) : null, "exascaleDbStorageVaultName" ,container.Add );
            AddIf( null != (((object)this._location)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._location.ToString()) : null, "location" ,container.Add );
            AddIf( null != (((object)this._adbscharsetname)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._adbscharsetname.ToString()) : null, "adbscharsetname" ,container.Add );
            AddIf( null != (((object)this._adbsncharsetname)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._adbsncharsetname.ToString()) : null, "adbsncharsetname" ,container.Add );
            AddIf( null != (((object)this._autonomousdbversionsname)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._autonomousdbversionsname.ToString()) : null, "autonomousdbversionsname" ,container.Add );
            AddIf( null != (((object)this._dbsystemshapename)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._dbsystemshapename.ToString()) : null, "dbsystemshapename" ,container.Add );
            AddIf( null != (((object)this._dnsprivateviewocid)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._dnsprivateviewocid.ToString()) : null, "dnsprivateviewocid" ,container.Add );
            AddIf( null != (((object)this._dnsprivatezonename)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._dnsprivatezonename.ToString()) : null, "dnsprivatezonename" ,container.Add );
            AddIf( null != (((object)this._flexComponentName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._flexComponentName.ToString()) : null, "flexComponentName" ,container.Add );
            AddIf( null != (((object)this._giversionname)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._giversionname.ToString()) : null, "giversionname" ,container.Add );
            AddIf( null != (((object)this._giMinorVersionName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._giMinorVersionName.ToString()) : null, "giMinorVersionName" ,container.Add );
            AddIf( null != (((object)this._systemversionname)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._systemversionname.ToString()) : null, "systemversionname" ,container.Add );
            AddIf( null != (((object)this._adbbackupid)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._adbbackupid.ToString()) : null, "adbbackupid" ,container.Add );
            AddIf( null != (((object)this._dbserverocid)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._dbserverocid.ToString()) : null, "dbserverocid" ,container.Add );
            AddIf( null != (((object)this._dbnodeocid)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._dbnodeocid.ToString()) : null, "dbnodeocid" ,container.Add );
            AddIf( null != (((object)this._virtualnetworkaddressname)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._virtualnetworkaddressname.ToString()) : null, "virtualnetworkaddressname" ,container.Add );
            AddIf( null != (((object)this._exascaleDbNodeName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._exascaleDbNodeName.ToString()) : null, "exascaleDbNodeName" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}