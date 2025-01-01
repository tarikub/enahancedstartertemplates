param location string = resourceGroup().location
param appServicePlanName string
param appServiceName string
param skuName string = 'B1'
param skuTier string = 'Basic'

resource appServicePlan 'Microsoft.Web/serverfarms@2021-02-01' = {
    name: appServicePlanName
    location: location
    sku: {
        name: skuName
        tier: skuTier
    }
    properties: {
        reserved: false
    }
}

resource appService 'Microsoft.Web/sites@2021-02-01' = {
    name: appServiceName
    location: location
    properties: {
        serverFarmId: appServicePlan.id
    }
}

output appServicePlanId string = appServicePlan.id
output appServiceId string = appService.id