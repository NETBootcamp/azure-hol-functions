# azure-hol-functions

## Clone this repo

## Log into your azure account

## Create a Storage account

![image](https://github.com/NETBootcamp/azure-hol-functions/assets/8570490/911fb615-eebf-4bc8-8521-f4aa07a661d5)

Goto AccessKeys ff the storage account you've just created and hit Show button from Key1 --> Connection string and hit the copy to clipboard button

![image](https://github.com/NETBootcamp/azure-hol-functions/assets/8570490/652c35bb-49b9-4b48-add9-9b4f688ba28d)

Replace `StorageConnectionAppSetting` setting on `local.settings.json` file

![image](https://github.com/NETBootcamp/azure-hol-functions/assets/8570490/c77eca10-d51f-45d3-8a63-1606b3402f56)

## Create a Function App

![image](https://github.com/NETBootcamp/azure-hol-functions/assets/8570490/7d02f8ad-8650-4fe2-b1d4-aca604915a6a)

Goto Application Insights and in overview copy the Instrumentation Key value

![image](https://github.com/NETBootcamp/azure-hol-functions/assets/8570490/50565ffd-f546-484d-8098-9254f98c1510)

Replace `APPINSIGHTS_INSTRUMENTATIONKEY` setting on `local.settings.json` file

## On `Function2.cs` set the table name of your Azure Table

![image](https://github.com/NETBootcamp/azure-hol-functions/assets/8570490/483ed4b6-0e30-4d6d-ac8f-130237d9ef56)

