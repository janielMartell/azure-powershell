---
external help file: Az.Cdn-help.xml
Module Name: Az.Cdn
online version: https://learn.microsoft.com/powershell/module/az.Cdn/new-AzFrontDoorCdnRuleUrlSigningActionObject
schema: 2.0.0
---

# New-AzFrontDoorCdnRuleUrlSigningActionObject

## SYNOPSIS
Create an in-memory object for UrlSigningAction.

## SYNTAX

```
New-AzFrontDoorCdnRuleUrlSigningActionObject -Name <DeliveryRuleAction> [-ParameterAlgorithm <Algorithm>]
 [-ParameterNameOverride <IUrlSigningParamIdentifier[]>] [-ProgressAction <ActionPreference>]
 [<CommonParameters>]
```

## DESCRIPTION
Create an in-memory object for UrlSigningAction.

## EXAMPLES

### Example 1: Create an in-memory object for UrlSigningAction
```powershell
New-AzFrontDoorCdnRuleUrlSigningActionObject -Name rule01
```

```output
Name
----
rule01
```

Create an in-memory object for UrlSigningAction

## PARAMETERS

### -Name
The name of the action for the delivery rule.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeliveryRuleAction
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParameterAlgorithm
Algorithm to use for URL signing.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Algorithm
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParameterNameOverride
Defines which query string parameters in the url to be considered for expires, key id etc.
.
To construct, see NOTES section for PARAMETERNAMEOVERRIDE properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IUrlSigningParamIdentifier[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgressAction
{{ Fill ProgressAction Description }}

```yaml
Type: System.Management.Automation.ActionPreference
Parameter Sets: (All)
Aliases: proga

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.UrlSigningAction

## NOTES

## RELATED LINKS
