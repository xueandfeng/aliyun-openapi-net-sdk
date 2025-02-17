﻿/*
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

using Aliyun.Acs.Core.Retry.Util;

namespace Aliyun.Acs.Core.Retry.Condition
{
    public class RetryOnApiWithClientTokenCondition : IAlibabaRetryCondition
    {
        private const string ApiWithTokenSectionName = "RetryableAPIsWithClientToken";
        private readonly string configFile;

        public RetryOnApiWithClientTokenCondition(string configFile = "retry_config.json")
        {
            this.configFile = configFile;
        }

        public RetryCondition ShouldRetry(RetryPolicyContext retryPolicyContext)
        {
            var product = retryPolicyContext.Product;
            var version = retryPolicyContext.Version;
            var currentApiName = retryPolicyContext.ApiName;

            var loadFromJsonFile = new LoadFromJsonFile(configFile);
            var apiList = loadFromJsonFile.GetRetryableApiList(product, version, ApiWithTokenSectionName);

            if (apiList == null)
            {
                return RetryCondition.NoRetry;
            }

            var apiShouldRetry = apiList.Contains(currentApiName) ? RetryCondition.ShouldRetry : RetryCondition.NoRetry;

            return apiShouldRetry | RetryCondition.ShouldRetryWithThrottlingBackoff;
        }
    }
}
