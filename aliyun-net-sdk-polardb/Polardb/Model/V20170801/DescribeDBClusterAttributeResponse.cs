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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBClusterAttributeResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private string dBClusterNetworkType;

		private string vPCId;

		private string vSwitchId;

		private string payType;

		private string dBClusterId;

		private string dBClusterStatus;

		private string dBClusterDescription;

		private string engine;

		private string dBType;

		private string dBVersion;

		private string lockMode;

		private int? deletionLock;

		private string creationTime;

		private string expireTime;

		private string expired;

		private string maintainTime;

		private long? storageUsed;

		private int? storageMax;

		private string zoneIds;

		private long? sQLSize;

		private bool? isLatestVersion;

		private List<DescribeDBClusterAttribute_Tag> tags;

		private List<DescribeDBClusterAttribute_DBNode> dBNodes;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
			}
		}

		public string DBClusterNetworkType
		{
			get
			{
				return dBClusterNetworkType;
			}
			set	
			{
				dBClusterNetworkType = value;
			}
		}

		public string VPCId
		{
			get
			{
				return vPCId;
			}
			set	
			{
				vPCId = value;
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
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
			}
		}

		public string DBClusterStatus
		{
			get
			{
				return dBClusterStatus;
			}
			set	
			{
				dBClusterStatus = value;
			}
		}

		public string DBClusterDescription
		{
			get
			{
				return dBClusterDescription;
			}
			set	
			{
				dBClusterDescription = value;
			}
		}

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
			}
		}

		public string DBType
		{
			get
			{
				return dBType;
			}
			set	
			{
				dBType = value;
			}
		}

		public string DBVersion
		{
			get
			{
				return dBVersion;
			}
			set	
			{
				dBVersion = value;
			}
		}

		public string LockMode
		{
			get
			{
				return lockMode;
			}
			set	
			{
				lockMode = value;
			}
		}

		public int? DeletionLock
		{
			get
			{
				return deletionLock;
			}
			set	
			{
				deletionLock = value;
			}
		}

		public string CreationTime
		{
			get
			{
				return creationTime;
			}
			set	
			{
				creationTime = value;
			}
		}

		public string ExpireTime
		{
			get
			{
				return expireTime;
			}
			set	
			{
				expireTime = value;
			}
		}

		public string Expired
		{
			get
			{
				return expired;
			}
			set	
			{
				expired = value;
			}
		}

		public string MaintainTime
		{
			get
			{
				return maintainTime;
			}
			set	
			{
				maintainTime = value;
			}
		}

		public long? StorageUsed
		{
			get
			{
				return storageUsed;
			}
			set	
			{
				storageUsed = value;
			}
		}

		public int? StorageMax
		{
			get
			{
				return storageMax;
			}
			set	
			{
				storageMax = value;
			}
		}

		public string ZoneIds
		{
			get
			{
				return zoneIds;
			}
			set	
			{
				zoneIds = value;
			}
		}

		public long? SQLSize
		{
			get
			{
				return sQLSize;
			}
			set	
			{
				sQLSize = value;
			}
		}

		public bool? IsLatestVersion
		{
			get
			{
				return isLatestVersion;
			}
			set	
			{
				isLatestVersion = value;
			}
		}

		public List<DescribeDBClusterAttribute_Tag> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public List<DescribeDBClusterAttribute_DBNode> DBNodes
		{
			get
			{
				return dBNodes;
			}
			set	
			{
				dBNodes = value;
			}
		}

		public class DescribeDBClusterAttribute_Tag
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeDBClusterAttribute_DBNode
		{

			private string dBNodeId;

			private string zoneId;

			private string dBNodeStatus;

			private string creationTime;

			private string dBNodeClass;

			private string dBNodeRole;

			private int? maxIOPS;

			private int? maxConnections;

			public string DBNodeId
			{
				get
				{
					return dBNodeId;
				}
				set	
				{
					dBNodeId = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string DBNodeStatus
			{
				get
				{
					return dBNodeStatus;
				}
				set	
				{
					dBNodeStatus = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string DBNodeClass
			{
				get
				{
					return dBNodeClass;
				}
				set	
				{
					dBNodeClass = value;
				}
			}

			public string DBNodeRole
			{
				get
				{
					return dBNodeRole;
				}
				set	
				{
					dBNodeRole = value;
				}
			}

			public int? MaxIOPS
			{
				get
				{
					return maxIOPS;
				}
				set	
				{
					maxIOPS = value;
				}
			}

			public int? MaxConnections
			{
				get
				{
					return maxConnections;
				}
				set	
				{
					maxConnections = value;
				}
			}
		}
	}
}
