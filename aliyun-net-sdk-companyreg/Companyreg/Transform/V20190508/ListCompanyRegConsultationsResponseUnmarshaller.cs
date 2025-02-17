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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.companyreg.Model.V20190508;

namespace Aliyun.Acs.companyreg.Transform.V20190508
{
    public class ListCompanyRegConsultationsResponseUnmarshaller
    {
        public static ListCompanyRegConsultationsResponse Unmarshall(UnmarshallerContext context)
        {
			ListCompanyRegConsultationsResponse listCompanyRegConsultationsResponse = new ListCompanyRegConsultationsResponse();

			listCompanyRegConsultationsResponse.HttpResponse = context.HttpResponse;
			listCompanyRegConsultationsResponse.RequestId = context.StringValue("ListCompanyRegConsultations.RequestId");
			listCompanyRegConsultationsResponse.TotalItemNum = context.IntegerValue("ListCompanyRegConsultations.TotalItemNum");
			listCompanyRegConsultationsResponse.CurrentPageNum = context.IntegerValue("ListCompanyRegConsultations.CurrentPageNum");
			listCompanyRegConsultationsResponse.PageSize = context.IntegerValue("ListCompanyRegConsultations.PageSize");
			listCompanyRegConsultationsResponse.TotalPageNum = context.IntegerValue("ListCompanyRegConsultations.TotalPageNum");
			listCompanyRegConsultationsResponse.PrePage = context.BooleanValue("ListCompanyRegConsultations.PrePage");
			listCompanyRegConsultationsResponse.NextPage = context.BooleanValue("ListCompanyRegConsultations.NextPage");

			List<ListCompanyRegConsultationsResponse.ListCompanyRegConsultations_CompanyRegConsultation> listCompanyRegConsultationsResponse_data = new List<ListCompanyRegConsultationsResponse.ListCompanyRegConsultations_CompanyRegConsultation>();
			for (int i = 0; i < context.Length("ListCompanyRegConsultations.Data.Length"); i++) {
				ListCompanyRegConsultationsResponse.ListCompanyRegConsultations_CompanyRegConsultation companyRegConsultation = new ListCompanyRegConsultationsResponse.ListCompanyRegConsultations_CompanyRegConsultation();
				companyRegConsultation.BizId = context.StringValue("ListCompanyRegConsultations.Data["+ i +"].BizId");
				companyRegConsultation.ConsultInfo = context.StringValue("ListCompanyRegConsultations.Data["+ i +"].ConsultInfo");
				companyRegConsultation.GmtModified = context.LongValue("ListCompanyRegConsultations.Data["+ i +"].GmtModified");
				companyRegConsultation.City = context.StringValue("ListCompanyRegConsultations.Data["+ i +"].City");

				listCompanyRegConsultationsResponse_data.Add(companyRegConsultation);
			}
			listCompanyRegConsultationsResponse.Data = listCompanyRegConsultationsResponse_data;
        
			return listCompanyRegConsultationsResponse;
        }
    }
}
