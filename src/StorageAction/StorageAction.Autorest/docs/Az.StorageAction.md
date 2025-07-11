---
Module Name: Az.StorageAction
Module Guid: 78dad367-40fa-497c-afc0-831ee12e5038
Download Help Link: https://learn.microsoft.com/powershell/module/az.storageaction
Help Version: 1.0.0.0
Locale: en-US
---

# Az.StorageAction Module
## Description
Microsoft Azure PowerShell: StorageAction cmdlets

## Az.StorageAction Cmdlets
### [Get-AzStorageActionTask](Get-AzStorageActionTask.md)
Get the storage task properties

### [Get-AzStorageActionTaskAssignment](Get-AzStorageActionTaskAssignment.md)
Lists Resource IDs of the Storage Task Assignments associated with this Storage Task.

### [Get-AzStorageActionTasksReport](Get-AzStorageActionTasksReport.md)
Fetch the storage tasks run report summary for each assignment.

### [Invoke-AzStorageActionTaskPreviewAction](Invoke-AzStorageActionTaskPreviewAction.md)
Runs the input conditions against input object metadata properties and designates matched objects in response.

### [New-AzStorageActionTask](New-AzStorageActionTask.md)
Asynchronously create a new storage task resource with the specified parameters.
If a storage task is already created and a subsequent create request is issued with different properties, the storage task properties will be updated.
If a storage task is already created and a subsequent create request is issued with the exact same set of properties, the request will succeed.

### [New-AzStorageActionTaskOperationObject](New-AzStorageActionTaskOperationObject.md)
Create an in-memory object for StorageTaskOperation.

### [New-AzStorageActionTaskPreviewBlobPropertiesObject](New-AzStorageActionTaskPreviewBlobPropertiesObject.md)
Create an in-memory object for StorageTaskPreviewBlobProperties.

### [New-AzStorageActionTaskPreviewKeyValuePropertiesObject](New-AzStorageActionTaskPreviewKeyValuePropertiesObject.md)
Create an in-memory object for StorageTaskPreviewKeyValueProperties.

### [Remove-AzStorageActionTask](Remove-AzStorageActionTask.md)
Delete the storage task resource.

### [Update-AzStorageActionTask](Update-AzStorageActionTask.md)
Asynchronously update a new storage task resource with the specified parameters.
If a storage task is already created and a subsequent update request is issued with different properties, the storage task properties will be updated.
If a storage task is already created and a subsequent update request is issued with the exact same set of properties, the request will succeed.

