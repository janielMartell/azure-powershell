﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.WindowsAzure.Commands.Storage.Common;
using System.Globalization;
using System.Management.Automation;
using System.Security.Permissions;
using Microsoft.WindowsAzure.Commands.Common.Storage.ResourceModel;
using Azure.Storage.Files.Shares;
using Azure.Storage.Files.Shares.Models;

namespace Microsoft.WindowsAzure.Commands.Storage.File.Cmdlet
{
    [Cmdlet("Set", Azure.Commands.ResourceManager.Common.AzureRMConstants.AzurePrefix + "StorageShareQuota", DefaultParameterSetName = Constants.ShareNameParameterSetName), OutputType(typeof(AzureStorageFileShare))]
    public class SetAzureStorageShareQuota : AzureStorageFileCmdletBase
    {
        [Alias("N", "Name")]
        [Parameter(Position = 0, Mandatory = true,
            HelpMessage = "Share name",
            ParameterSetName = Constants.ShareNameParameterSetName,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string ShareName { get; set; }

        [Parameter(
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = Constants.ShareParameterSetName,
            HelpMessage = "ShareClient object indicated the share whose quota to set.")]
        [ValidateNotNull]
        public ShareClient ShareClient { get; set; }

        [Alias("QuotaGiB")]
        [Parameter(Position = 1, Mandatory = true,
            HelpMessage = "Share Quota")]
        public int Quota { get; set; }

        // Overwrite the useless parameter
        public override SwitchParameter DisAllowTrailingDot { get; set; }

        /// <summary>
        /// execute command
        /// </summary>
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public override void ExecuteCmdlet()
        {
            ShareClient share;

            switch (this.ParameterSetName)
            {
                case Constants.ShareNameParameterSetName:
                    NamingUtil.ValidateShareName(this.ShareName, false);
                    share = Util.GetTrack2ShareReference(this.ShareName,
                                (AzureStorageContext)this.Context,
                                null,
                                ClientOptions);
                    break;

                case Constants.ShareParameterSetName:
                    CheckContextForObjectInput((AzureStorageContext)this.Context);
                    share = this.ShareClient;
                    break;

                default:
                    throw new PSArgumentException(string.Format(CultureInfo.InvariantCulture, "Invalid parameter set name: {0}", this.ParameterSetName));
            }

            ShareProperties shareProperties = share.GetProperties(this.CmdletCancellationToken).Value;

            if (shareProperties.QuotaInGB != this.Quota)
            {
                share.SetQuota(this.Quota);
                shareProperties = share.GetProperties(this.CmdletCancellationToken).Value;
            }

            WriteObject( new AzureStorageFileShare(share, (AzureStorageContext)this.Context, shareProperties, ClientOptions));
        }
    }
}
