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
using Aliyun.Acs.BssOpenApi;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class QueryInstanceBillRequest : RpcAcsRequest<QueryInstanceBillResponse>
    {
        public QueryInstanceBillRequest()
            : base("BssOpenApi", "2017-12-14", "QueryInstanceBill")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private bool? isBillingItem;

		private string productCode;

		private bool? isHideZeroCharge;

		private string subscriptionType;

		private int? pageSize;

		private string billingCycle;

		private long? ownerId;

		private int? pageNum;

		private string productType;

		public bool? IsBillingItem
		{
			get
			{
				return isBillingItem;
			}
			set	
			{
				isBillingItem = value;
				DictionaryUtil.Add(QueryParameters, "IsBillingItem", value.ToString());
			}
		}

		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
				DictionaryUtil.Add(QueryParameters, "ProductCode", value);
			}
		}

		public bool? IsHideZeroCharge
		{
			get
			{
				return isHideZeroCharge;
			}
			set	
			{
				isHideZeroCharge = value;
				DictionaryUtil.Add(QueryParameters, "IsHideZeroCharge", value.ToString());
			}
		}

		public string SubscriptionType
		{
			get
			{
				return subscriptionType;
			}
			set	
			{
				subscriptionType = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionType", value);
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

		public string BillingCycle
		{
			get
			{
				return billingCycle;
			}
			set	
			{
				billingCycle = value;
				DictionaryUtil.Add(QueryParameters, "BillingCycle", value);
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

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

        public override QueryInstanceBillResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryInstanceBillResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
