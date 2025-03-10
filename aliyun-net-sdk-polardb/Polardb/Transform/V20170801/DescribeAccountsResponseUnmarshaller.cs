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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeAccountsResponseUnmarshaller
    {
        public static DescribeAccountsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccountsResponse describeAccountsResponse = new DescribeAccountsResponse();

			describeAccountsResponse.HttpResponse = context.HttpResponse;
			describeAccountsResponse.RequestId = context.StringValue("DescribeAccounts.RequestId");

			List<DescribeAccountsResponse.DescribeAccounts_DBAccount> describeAccountsResponse_accounts = new List<DescribeAccountsResponse.DescribeAccounts_DBAccount>();
			for (int i = 0; i < context.Length("DescribeAccounts.Accounts.Length"); i++) {
				DescribeAccountsResponse.DescribeAccounts_DBAccount dBAccount = new DescribeAccountsResponse.DescribeAccounts_DBAccount();
				dBAccount.AccountName = context.StringValue("DescribeAccounts.Accounts["+ i +"].AccountName");
				dBAccount.AccountStatus = context.StringValue("DescribeAccounts.Accounts["+ i +"].AccountStatus");
				dBAccount.AccountDescription = context.StringValue("DescribeAccounts.Accounts["+ i +"].AccountDescription");
				dBAccount.AccountType = context.StringValue("DescribeAccounts.Accounts["+ i +"].AccountType");
				dBAccount.PrivilegeExceeded = context.StringValue("DescribeAccounts.Accounts["+ i +"].PrivilegeExceeded");

				List<DescribeAccountsResponse.DescribeAccounts_DBAccount.DescribeAccounts_DatabasePrivilege> dBAccount_databasePrivileges = new List<DescribeAccountsResponse.DescribeAccounts_DBAccount.DescribeAccounts_DatabasePrivilege>();
				for (int j = 0; j < context.Length("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges.Length"); j++) {
					DescribeAccountsResponse.DescribeAccounts_DBAccount.DescribeAccounts_DatabasePrivilege databasePrivilege = new DescribeAccountsResponse.DescribeAccounts_DBAccount.DescribeAccounts_DatabasePrivilege();
					databasePrivilege.DBName = context.StringValue("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges["+ j +"].DBName");
					databasePrivilege.AccountPrivilege = context.StringValue("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges["+ j +"].AccountPrivilege");

					dBAccount_databasePrivileges.Add(databasePrivilege);
				}
				dBAccount.DatabasePrivileges = dBAccount_databasePrivileges;

				describeAccountsResponse_accounts.Add(dBAccount);
			}
			describeAccountsResponse.Accounts = describeAccountsResponse_accounts;
        
			return describeAccountsResponse;
        }
    }
}
