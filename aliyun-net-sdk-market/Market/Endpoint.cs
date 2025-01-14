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

namespace Aliyun.Acs.Market
{
    public class Endpoint
    {
        public static Dictionary<string, string> endpointMap = new Dictionary<string, string>() 
        {
            { "cn-shenzhen", "market.aliyuncs.com" },
            { "cn-beijing", "market.aliyuncs.com" },
            { "ap-south-1", "market.ap-southeast-1.aliyuncs.com" },
            { "eu-west-1", "market.ap-southeast-1.aliyuncs.com" },
            { "ap-northeast-1", "market.ap-southeast-1.aliyuncs.com" },
            { "me-east-1", "market.ap-southeast-1.aliyuncs.com" },
            { "cn-chengdu", "market.aliyuncs.com" },
            { "cn-qingdao", "market.aliyuncs.com" },
            { "cn-shanghai", "market.aliyuncs.com" },
            { "cn-hongkong", "market.aliyuncs.com" },
            { "ap-southeast-2", "market.ap-southeast-1.aliyuncs.com" },
            { "ap-southeast-3", "market.ap-southeast-1.aliyuncs.com" },
            { "eu-central-1", "market.ap-southeast-1.aliyuncs.com" },
            { "cn-huhehaote", "market.aliyuncs.com" },
            { "ap-southeast-5", "market.ap-southeast-1.aliyuncs.com" },
            { "us-east-1", "market.ap-southeast-1.aliyuncs.com" },
            { "cn-zhangjiakou", "market.aliyuncs.com" },
            { "us-west-1", "market.ap-southeast-1.aliyuncs.com" },
            { "cn-hangzhou", "market.aliyuncs.com" },
        };

        public static string endpointRegionalType = "regional";
    }
}
