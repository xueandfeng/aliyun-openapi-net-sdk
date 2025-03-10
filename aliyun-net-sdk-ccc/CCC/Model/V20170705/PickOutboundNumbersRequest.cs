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
    public class PickOutboundNumbersRequest : RpcAcsRequest<PickOutboundNumbersResponse>
    {
        public PickOutboundNumbersRequest()
            : base("CCC", "2017-07-05", "PickOutboundNumbers")
        {
        }

		private string instanceId;

		private int? count;

		private List<string> candidateNumbers;

		private string calleeNumber;

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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
				DictionaryUtil.Add(QueryParameters, "Count", value.ToString());
			}
		}

		public List<string> CandidateNumbers
		{
			get
			{
				return candidateNumbers;
			}

			set
			{
				candidateNumbers = value;
				for (int i = 0; i < candidateNumbers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"CandidateNumber." + (i + 1) , candidateNumbers[i]);
				}
			}
		}

		public string CalleeNumber
		{
			get
			{
				return calleeNumber;
			}
			set	
			{
				calleeNumber = value;
				DictionaryUtil.Add(QueryParameters, "CalleeNumber", value);
			}
		}

        public override PickOutboundNumbersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PickOutboundNumbersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
