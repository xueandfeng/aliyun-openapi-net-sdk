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
    public class DescribeBackupTasksRequest : RpcAcsRequest<DescribeBackupTasksResponse>
    {
        public DescribeBackupTasksRequest()
            : base("Rds", "2014-08-15", "DescribeBackupTasks", "rds", "openAPI")
        {
        }

		private string backupJobId;

		private long? resourceOwnerId;

		private string flag;

		private string resourceOwnerAccount;

		private string clientToken;

		private string ownerAccount;

		private string dBInstanceId;

		private string backupMode;

		private long? ownerId;

		private string backupJobStatus;

		public string BackupJobId
		{
			get
			{
				return backupJobId;
			}
			set	
			{
				backupJobId = value;
				DictionaryUtil.Add(QueryParameters, "BackupJobId", value);
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

		public string Flag
		{
			get
			{
				return flag;
			}
			set	
			{
				flag = value;
				DictionaryUtil.Add(QueryParameters, "Flag", value);
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

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
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

		public string BackupMode
		{
			get
			{
				return backupMode;
			}
			set	
			{
				backupMode = value;
				DictionaryUtil.Add(QueryParameters, "BackupMode", value);
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

		public string BackupJobStatus
		{
			get
			{
				return backupJobStatus;
			}
			set	
			{
				backupJobStatus = value;
				DictionaryUtil.Add(QueryParameters, "BackupJobStatus", value);
			}
		}

        public override DescribeBackupTasksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeBackupTasksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
