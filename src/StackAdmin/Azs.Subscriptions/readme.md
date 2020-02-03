<!-- region Generated -->
# Azs.Subscription
This directory contains the PowerShell module for the Subscription service.

---
## Status
[![Azs.Subscription](https://img.shields.io/powershellgallery/v/Azs.Subscription.svg?style=flat-square&label=Azs.Subscription "Azs.Subscription")](https://www.powershellgallery.com/packages/Azs.Subscription/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 1.6.0 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Azs.Subscription`, see [how-to.md](how-to.md).
<!-- endregion -->

## Generation Requirements
Use of the beta version of `autorest.powershell` generator requires the following:
- [NodeJS LTS](https://nodejs.org) (10.15.x LTS preferred)
  - **Note**: It *will not work* with Node < 10.x. Using 11.x builds may cause issues as they may introduce instability or breaking changes.
> If you want an easy way to install and update Node, [NVS - Node Version Switcher](../nodejs/installing-via-nvs.md) or [NVM - Node Version Manager](../nodejs/installing-via-nvm.md) is recommended.
- [AutoRest](https://aka.ms/autorest) v3 beta <br>`npm install -g autorest@beta`<br>&nbsp;
- PowerShell 6.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g pwsh`<br>&nbsp;
- .NET Core SDK 2.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g dotnet-sdk-2.2`<br>&nbsp;

## Run Generation
In this directory, run AutoRest:
> `autorest`

---
### AutoRest Configuration
> see https://aka.ms/autorest

# Azure PowerShell AutoRest Configuration

> Values
``` yaml
azure: true
powershell: true
branch: stackadmin
repo: https://github.com/rakku-ms/azure-rest-api-specs/tree/$(branch)
metadata:
  authors: Microsoft Corporation
  owners: Microsoft Corporation
  description: 'Microsoft Azure PowerShell: $(service-name) cmdlets'
  copyright: Microsoft Corporation. All rights reserved.
  tags: Azure ResourceManager ARM PSModule $(service-name)
  companyName: Microsoft Corporation
  requireLicenseAcceptance: true
  licenseUri: https://aka.ms/azps-license
  projectUri: https://github.com/Azure/azure-powershell
```

> Names
``` yaml
prefix: Azs
module-name: $(prefix).$(service-name)
namespace: Microsoft.Azure.PowerShell.Cmdlets.$(service-name)
```

> Folders
``` yaml
clear-output-folder: true
output-folder: .
```

``` yaml
require:
  - $(repo)/specification/azsadmin/resource-manager/user-subscriptions/readme.azsautogen.md

subject-prefix: ''
module-version: 0.0.1
sanitize-names: false

### File Renames 
module-name: Azs.Subscriptions 
csproj: Azs.Subscriptions.csproj 
psd1: Azs.Subscriptions.psd1 
psm1: Azs.Subscriptions.psm1

directive:
  ## Set default parameter value
  - where:
      verb: New
      subject: Subscription
      parameter-name: State
    set:
      default:
        script: Write-Output "Enabled"
  - where:
      verb: New
      subject: Subscription
      parameter-name: SubscriptionId
    set:
      default:
        script: "$([Guid]::NewGuid().ToString())"
  ## variant removal (parameter *Definition*) from all New cmdlets -- parameter set Create
  - where:
      verb: New
      variant: Create
    remove: true
```