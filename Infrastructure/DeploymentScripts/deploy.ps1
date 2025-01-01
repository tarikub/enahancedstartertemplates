<#
.SYNOPSIS
    Deploys Azure resources using a Bicep file.

.DESCRIPTION
    This script deploys Azure resources to a specified resource group using a Bicep file.
    It requires the Azure CLI to be installed and logged in.

.PARAMETER ResourceGroupName
    The name of the resource group where the resources will be deployed.

.PARAMETER DeploymentName
    The name of the deployment.

.PARAMETER BicepFilePath
    The path to the Bicep file to be used for the deployment.

.PARAMETER Location
    The location where the resource group will be created if it doesn't exist.

.EXAMPLE
    .\deploy.ps1 -ResourceGroupName "MyResourceGroup" -DeploymentName "MyDeployment" -BicepFilePath "main.bicep" -Location "westus"
#>

param (
    [Parameter(Mandatory=$true)]
    [string]$ResourceGroupName,

    [Parameter(Mandatory=$true)]
    [string]$DeploymentName,

    [Parameter(Mandatory=$true)]
    [string]$BicepFilePath,

    [Parameter(Mandatory=$true)]
    [string]$Location = "westus"
)

# Check if the resource group exists, and create it if it doesn't
_ = az group show --name $ResourceGroupName --output none 2>$null

if (-not $?) {
    Write-Host "Resource group '$ResourceGroupName' does not exist. Creating..."
    az group create --name $ResourceGroupName --location $Location
} else {
    Write-Host "Resource group '$ResourceGroupName' already exists."
}

# Start the deployment
az deployment group create --resource-group $ResourceGroupName --name $DeploymentName --template-file $BicepFilePath