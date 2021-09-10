param (
    [parameter(mandatory = $true)]
    [string]$SqlServerName,
    
    [parameter(mandatory = $true)]
    [string]$SqlServerResourceGroup,
    
    [parameter(mandatory = $true)]
    [string]$SqlServerKeyVaultName,
    
    [parameter(mandatory = $true)]
    [string]$SqlServerPasswordSecretName,

    [parameter(mandatory = $true)]
    [string]$DBName,

    <# an array of hashtables containing the following properties:
        [string]id (must be the app id for service principals and objectId for AAD groups), 
        [bool]isAADGroup,
        [string]dbRoles (must be comma-delimited)

        Example:
        @(
            @{id=-"000-0000-000000-00000"; isAADGroup=$true; dbRoles="db_owner"},
            @{id="aaaa-aaaa-aaaaaa-aaaaa"; isAADGroup=$false; dbRoles="db_writer,db_reader"},
            @{etc.}
        )
    #>
    [parameter(mandatory = $true)]
    [array]$DbPrincipalObjectList,

    [parameter(mandatory = $true)]
    [string]$SqlScriptName,

    [parameter(mandatory = $true)]
    [string]$SubscriptionId
)
begin
{
	echo 'foo';
}
end
{
}