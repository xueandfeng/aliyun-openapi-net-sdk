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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifySecurityIpsRequest : RpcAcsRequest<ModifySecurityIpsResponse>
    {
        public ModifySecurityIpsRequest()
            : base("Rds", "2014-08-15", "ModifySecurityIps", "rds", "openAPI")
        {
        }

		private string dBInstanceIPArrayName;

		private long? resourceOwnerId;

		private string modifyMode;

		private string securityIps;

		private string securityGroupId;

		private string whitelistNetworkType;

		private string dBInstanceIPArrayAttribute;

		private string securityIPType;

		private string dBInstanceId;

		public string DBInstanceIPArrayName
		{
			get
			{
				return dBInstanceIPArrayName;
			}
			set	
			{
				dBInstanceIPArrayName = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceIPArrayName", value);
			}
		}

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

		public string ModifyMode
		{
			get
			{
				return modifyMode;
			}
			set	
			{
				modifyMode = value;
				DictionaryUtil.Add(QueryParameters, "ModifyMode", value);
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

		public string SecurityGroupId
		{
			get
			{
				return securityGroupId;
			}
			set	
			{
				securityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
			}
		}

		public string WhitelistNetworkType
		{
			get
			{
				return whitelistNetworkType;
			}
			set	
			{
				whitelistNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "WhitelistNetworkType", value);
			}
		}

		public string DBInstanceIPArrayAttribute
		{
			get
			{
				return dBInstanceIPArrayAttribute;
			}
			set	
			{
				dBInstanceIPArrayAttribute = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceIPArrayAttribute", value);
			}
		}

		public string SecurityIPType
		{
			get
			{
				return securityIPType;
			}
			set	
			{
				securityIPType = value;
				DictionaryUtil.Add(QueryParameters, "SecurityIPType", value);
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

        public override ModifySecurityIpsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySecurityIpsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
