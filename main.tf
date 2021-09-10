resource "null_resource" "staff_storage_set_up_users" {

  provisioner "local-exec" {
    command     = <<EOT
    Scripts/ConfigureSqlDatabase.ps1 `
     -SqlServerName foo `
     -SqlServerResourceGroup foo `
     -SqlServerKeyVaultName foo `
     -SqlServerPasswordSecretName foo `
     -dbName foo `
     -DbPrincipalObjectList foo `
     -SqlScriptName "ConfigureSqlDatabasePermissions.sql" `
     -subscriptionId foo
    EOT
    on_failure  = fail
  }
}