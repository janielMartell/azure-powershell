﻿// ----------------------------------------------------------------------------------
//
// Copyright 2012 Microsoft Corporation
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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.WindowsAzure.Commands.Storage.Common;
using Microsoft.Azure.Storage.Blob;
using Microsoft.Azure.Cosmos.Table;

namespace Microsoft.WindowsAzure.Commands.Storage.Test.Common
{
    /// <summary>
    /// Unit test for Access Policy helper
    /// </summary>
    [TestClass]
    public class AccessPolicyHelperTest : StorageTestBase
    {
        [TestMethod]
        public void ValidateSetupAccessPolicyPermissionTest()
        {
            SharedAccessBlobPolicy blobAccessPolicy = new SharedAccessBlobPolicy();
            AccessPolicyHelper.SetupAccessPolicyPermission(blobAccessPolicy, null);
            Assert.AreEqual(blobAccessPolicy.Permissions, SharedAccessBlobPermissions.None);
            AccessPolicyHelper.SetupAccessPolicyPermission(blobAccessPolicy, "");
            Assert.AreEqual(blobAccessPolicy.Permissions, SharedAccessBlobPermissions.None);
            AccessPolicyHelper.SetupAccessPolicyPermission(blobAccessPolicy, "D");
            Assert.AreEqual(blobAccessPolicy.Permissions, SharedAccessBlobPermissions.Delete);

            SharedAccessTablePolicy tableAccessPolicy = new SharedAccessTablePolicy();
            AccessPolicyHelper.SetupAccessPolicyPermission(tableAccessPolicy, null);
            Assert.AreEqual(tableAccessPolicy.Permissions, SharedAccessTablePermissions.None);
            AccessPolicyHelper.SetupAccessPolicyPermission(tableAccessPolicy, "");
            Assert.AreEqual(tableAccessPolicy.Permissions, SharedAccessTablePermissions.None);
            AccessPolicyHelper.SetupAccessPolicyPermission(tableAccessPolicy, "ar");
            Assert.AreEqual(tableAccessPolicy.Permissions, SharedAccessTablePermissions.Add | SharedAccessTablePermissions.Query);
        }

        [TestMethod]
        public void SetupAccessPolicyLifeTimeTest()
        {
            DateTime? start = DateTime.Now;
            DateTime? end = start.Value.AddHours(1.0);
            DateTimeOffset? testStart = null;
            DateTimeOffset? testEnd = null;
            AccessPolicyHelper.SetupAccessPolicyLifeTime(start, end, out testStart, out testEnd);
            Assert.AreEqual(testStart.Value.UtcDateTime.ToString(), start.Value.ToUniversalTime().ToString());
            Assert.AreEqual(testEnd.Value.UtcDateTime.ToString(), end.Value.ToUniversalTime().ToString());
            AssertThrows<ArgumentException>(() => SasTokenHelper.SetupAccessPolicyLifeTime(end, start, out testStart, out testEnd, true));
        }

        [TestMethod]
        public void SetupAccessPolicyTest()
        {
            DateTime? start = DateTime.Now;
            DateTime? end = start.Value.AddHours(1.0);

            SharedAccessBlobPolicy blobAccessPolicy = new SharedAccessBlobPolicy();
            AccessPolicyHelper.SetupAccessPolicy(blobAccessPolicy, start, end, "a");
            Assert.AreEqual(blobAccessPolicy.SharedAccessStartTime.Value.UtcDateTime.ToString(), start.Value.ToUniversalTime().ToString());
            Assert.AreEqual(blobAccessPolicy.SharedAccessExpiryTime.Value.UtcDateTime.ToString(), end.Value.ToUniversalTime().ToString());
            Assert.AreEqual(blobAccessPolicy.Permissions, SharedAccessBlobPermissions.Add);

            SharedAccessTablePolicy tableAccessPolicy = new SharedAccessTablePolicy();
            AccessPolicyHelper.SetupAccessPolicy(tableAccessPolicy, null, end, "d", true);
            Assert.AreEqual(tableAccessPolicy.SharedAccessStartTime, null);
            Assert.AreEqual(tableAccessPolicy.SharedAccessExpiryTime.Value.UtcDateTime.ToString(), end.Value.ToUniversalTime().ToString());
            Assert.AreEqual(tableAccessPolicy.Permissions, SharedAccessTablePermissions.Delete);
        }
    }
}
