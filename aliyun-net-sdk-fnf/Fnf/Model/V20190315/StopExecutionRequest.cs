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
using Aliyun.Acs.fnf.Transform;
using Aliyun.Acs.fnf.Transform.V20190315;

namespace Aliyun.Acs.fnf.Model.V20190315
{
    public class StopExecutionRequest : RpcAcsRequest<StopExecutionResponse>
    {
        public StopExecutionRequest()
            : base("fnf", "2019-03-15", "StopExecution", "fnf", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string executionName;

		private string requestId;

		private string cause;

		private string flowName;

		private string error;

		public string ExecutionName
		{
			get
			{
				return executionName;
			}
			set	
			{
				executionName = value;
				DictionaryUtil.Add(QueryParameters, "ExecutionName", value);
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
				DictionaryUtil.Add(QueryParameters, "RequestId", value);
			}
		}

		public string Cause
		{
			get
			{
				return cause;
			}
			set	
			{
				cause = value;
				DictionaryUtil.Add(QueryParameters, "Cause", value);
			}
		}

		public string FlowName
		{
			get
			{
				return flowName;
			}
			set	
			{
				flowName = value;
				DictionaryUtil.Add(QueryParameters, "FlowName", value);
			}
		}

		public string Error
		{
			get
			{
				return error;
			}
			set	
			{
				error = value;
				DictionaryUtil.Add(QueryParameters, "Error", value);
			}
		}

        public override StopExecutionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StopExecutionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
