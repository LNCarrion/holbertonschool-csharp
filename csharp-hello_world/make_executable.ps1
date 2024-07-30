# Make the script executable
$scriptPath = ".\0-initialize_new_project.sh"
$acl = Get-Acl $scriptPath
$permission = "Everyone", "FullControl", "Allow"
$accessRule = New-Object System.Security.AccessControl.FileSystemAccessRule $permission
$acl.SetAccessRule($accessRule)
Set-Acl $scriptPath $acl
