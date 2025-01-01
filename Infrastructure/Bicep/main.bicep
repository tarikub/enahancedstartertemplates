param location string = resourceGroup().location
param appServiceName string
param appServicePlanName string
param skuName string = 'F1'

module appService 'appservice.bicep' = {
  name: 'appServiceDeployment'
  params: {
    location: location
    appServiceName: appServiceName
    appServicePlanName: appServicePlanName
    skuName: skuName
  }
}
