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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class GetSmsConfigRequest : RpcAcsRequest<GetSmsConfigResponse>
    {
        public GetSmsConfigRequest()
            : base("CCC", "2017-07-05", "GetSmsConfig")
        {
        }

		private string instanceId;

		private List<int?> scenarios;

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public List<int?> Scenarios
		{
			get
			{
				return scenarios;
			}

			set
			{
				scenarios = value;
				for (int i = 0; i < scenarios.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Scenario." + (i + 1) , scenarios[i]);
				}
			}
		}

        public override GetSmsConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetSmsConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
