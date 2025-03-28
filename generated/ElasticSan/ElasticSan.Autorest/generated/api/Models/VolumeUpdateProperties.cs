// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Extensions;

    /// <summary>Volume response properties.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.DoNotFormat]
    public partial class VolumeUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ManagedBy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IManagedByInfo _managedBy;

        /// <summary>Parent resource information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IManagedByInfo ManagedBy { get => (this._managedBy = this._managedBy ?? new Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ManagedByInfo()); set => this._managedBy = value; }

        /// <summary>
        /// Resource ID of the resource managing the volume, this is a restricted field and can only be set for internal use.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public string ManagedByResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IManagedByInfoInternal)ManagedBy).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IManagedByInfoInternal)ManagedBy).ResourceId = value ?? null; }

        /// <summary>Internal Acessors for ManagedBy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IManagedByInfo Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeUpdatePropertiesInternal.ManagedBy { get => (this._managedBy = this._managedBy ?? new Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ManagedByInfo()); set { {_managedBy = value;} } }

        /// <summary>Backing field for <see cref="SizeGiB" /> property.</summary>
        private long? _sizeGiB;

        /// <summary>Volume size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public long? SizeGiB { get => this._sizeGiB; set => this._sizeGiB = value; }

        /// <summary>Creates an new <see cref="VolumeUpdateProperties" /> instance.</summary>
        public VolumeUpdateProperties()
        {

        }
    }
    /// Volume response properties.
    public partial interface IVolumeUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Resource ID of the resource managing the volume, this is a restricted field and can only be set for internal use.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource ID of the resource managing the volume, this is a restricted field and can only be set for internal use.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedByResourceId { get; set; }
        /// <summary>Volume size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Volume size.",
        SerializedName = @"sizeGiB",
        PossibleTypes = new [] { typeof(long) })]
        long? SizeGiB { get; set; }

    }
    /// Volume response properties.
    internal partial interface IVolumeUpdatePropertiesInternal

    {
        /// <summary>Parent resource information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IManagedByInfo ManagedBy { get; set; }
        /// <summary>
        /// Resource ID of the resource managing the volume, this is a restricted field and can only be set for internal use.
        /// </summary>
        string ManagedByResourceId { get; set; }
        /// <summary>Volume size.</summary>
        long? SizeGiB { get; set; }

    }
}