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
    public class GetCallMeasureSummaryReportRequest : RpcAcsRequest<GetCallMeasureSummaryReportResponse>
    {
        public GetCallMeasureSummaryReportRequest()
            : base("CCC", "2017-07-05", "GetCallMeasureSummaryReport")
        {
        }

		private string intervalType;

		private int? month;

		private int? year;

		private int? pageSize;

		private int? day;

		private int? pageNumber;

		public string IntervalType
		{
			get
			{
				return intervalType;
			}
			set	
			{
				intervalType = value;
				DictionaryUtil.Add(QueryParameters, "IntervalType", value);
			}
		}

		public int? Month
		{
			get
			{
				return month;
			}
			set	
			{
				month = value;
				DictionaryUtil.Add(QueryParameters, "Month", value.ToString());
			}
		}

		public int? Year
		{
			get
			{
				return year;
			}
			set	
			{
				year = value;
				DictionaryUtil.Add(QueryParameters, "Year", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public int? Day
		{
			get
			{
				return day;
			}
			set	
			{
				day = value;
				DictionaryUtil.Add(QueryParameters, "Day", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

        public override GetCallMeasureSummaryReportResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetCallMeasureSummaryReportResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
