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
    public class CreatePredictiveJobGroupRequest : RpcAcsRequest<CreatePredictiveJobGroupResponse>
    {
        public CreatePredictiveJobGroupRequest()
            : base("CCC", "2017-07-05", "CreatePredictiveJobGroup")
        {
			Method = MethodType.POST;
        }

		private string instanceId;

		private bool? isDraft;

		private string skillGroupId;

		private string strategyJson;

		private string name;

		private string description;

		private bool? timingSchedule;

		private List<string> jobsJsons;

		private string jobFilePath;

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

		public bool? IsDraft
		{
			get
			{
				return isDraft;
			}
			set	
			{
				isDraft = value;
				DictionaryUtil.Add(QueryParameters, "IsDraft", value.ToString());
			}
		}

		public string SkillGroupId
		{
			get
			{
				return skillGroupId;
			}
			set	
			{
				skillGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SkillGroupId", value);
			}
		}

		public string StrategyJson
		{
			get
			{
				return strategyJson;
			}
			set	
			{
				strategyJson = value;
				DictionaryUtil.Add(QueryParameters, "StrategyJson", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public bool? TimingSchedule
		{
			get
			{
				return timingSchedule;
			}
			set	
			{
				timingSchedule = value;
				DictionaryUtil.Add(QueryParameters, "TimingSchedule", value.ToString());
			}
		}

		public List<string> JobsJsons
		{
			get
			{
				return jobsJsons;
			}

			set
			{
				jobsJsons = value;
				for (int i = 0; i < jobsJsons.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"JobsJson." + (i + 1) , jobsJsons[i]);
				}
			}
		}

		public string JobFilePath
		{
			get
			{
				return jobFilePath;
			}
			set	
			{
				jobFilePath = value;
				DictionaryUtil.Add(QueryParameters, "JobFilePath", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreatePredictiveJobGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreatePredictiveJobGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
