/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.polardb.Transform;
using Aliyun.Acs.polardb.Transform.V20170801;

namespace Aliyun.Acs.polardb.Model.V20170801
{
    public class ModifyDBClusterAccessWhitelistRequest : RpcAcsRequest<ModifyDBClusterAccessWhitelistResponse>
    {
        public ModifyDBClusterAccessWhitelistRequest()
            : base("polardb", "2017-08-01", "ModifyDBClusterAccessWhitelist", "polardb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string dBClusterId;

		private string ownerAccount;

		private string securityIps;

		private string dBClusterIPArrayName;

		private long? ownerId;

		private string dBClusterIPArrayAttribute;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterId", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string SecurityIps
		{
			get
			{
				return securityIps;
			}
			set	
			{
				securityIps = value;
				DictionaryUtil.Add(QueryParameters, "SecurityIps", value);
			}
		}

		public string DBClusterIPArrayName
		{
			get
			{
				return dBClusterIPArrayName;
			}
			set	
			{
				dBClusterIPArrayName = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterIPArrayName", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string DBClusterIPArrayAttribute
		{
			get
			{
				return dBClusterIPArrayAttribute;
			}
			set	
			{
				dBClusterIPArrayAttribute = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterIPArrayAttribute", value);
			}
		}

        public override ModifyDBClusterAccessWhitelistResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBClusterAccessWhitelistResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
