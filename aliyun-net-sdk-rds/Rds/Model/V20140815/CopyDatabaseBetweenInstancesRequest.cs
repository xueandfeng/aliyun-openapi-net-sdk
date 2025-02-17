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
    public class CopyDatabaseBetweenInstancesRequest : RpcAcsRequest<CopyDatabaseBetweenInstancesResponse>
    {
        public CopyDatabaseBetweenInstancesRequest()
            : base("Rds", "2014-08-15", "CopyDatabaseBetweenInstances", "rds", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string restoreTime;

		private string backupId;

		private string syncUserPrivilege;

		private string dbNames;

		private string targetDBInstanceId;

		private string dBInstanceId;

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

		public string RestoreTime
		{
			get
			{
				return restoreTime;
			}
			set	
			{
				restoreTime = value;
				DictionaryUtil.Add(QueryParameters, "RestoreTime", value);
			}
		}

		public string BackupId
		{
			get
			{
				return backupId;
			}
			set	
			{
				backupId = value;
				DictionaryUtil.Add(QueryParameters, "BackupId", value);
			}
		}

		public string SyncUserPrivilege
		{
			get
			{
				return syncUserPrivilege;
			}
			set	
			{
				syncUserPrivilege = value;
				DictionaryUtil.Add(QueryParameters, "SyncUserPrivilege", value);
			}
		}

		public string DbNames
		{
			get
			{
				return dbNames;
			}
			set	
			{
				dbNames = value;
				DictionaryUtil.Add(QueryParameters, "DbNames", value);
			}
		}

		public string TargetDBInstanceId
		{
			get
			{
				return targetDBInstanceId;
			}
			set	
			{
				targetDBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "TargetDBInstanceId", value);
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

        public override CopyDatabaseBetweenInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CopyDatabaseBetweenInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
