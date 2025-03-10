// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Environment Variable for the container</summary>
    public partial class CustomServiceEnvironmentVariables :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ICustomServiceEnvironmentVariables,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ICustomServiceEnvironmentVariablesInternal
    {

        /// <summary>Creates an new <see cref="CustomServiceEnvironmentVariables" /> instance.</summary>
        public CustomServiceEnvironmentVariables()
        {

        }
    }
    /// Environment Variable for the container
    public partial interface ICustomServiceEnvironmentVariables :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEnvironmentVariable>
    {

    }
    /// Environment Variable for the container
    internal partial interface ICustomServiceEnvironmentVariablesInternal

    {

    }
}