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

namespace Aliyun.Acs.BssOpenApi
{
    public class Endpoint
    {
        public static Dictionary<string, string> endpointMap = new Dictionary<string, string>() 
        {
            { "cn-shenzhen", "business.aliyuncs.com" },
            { "cn-beijing", "business.aliyuncs.com" },
            { "ap-south-1", "business.ap-southeast-1.aliyuncs.com" },
            { "eu-west-1", "business.ap-southeast-1.aliyuncs.com" },
            { "ap-northeast-1", "business.ap-southeast-1.aliyuncs.com" },
            { "me-east-1", "business.ap-southeast-1.aliyuncs.com" },
            { "cn-chengdu", "business.aliyuncs.com" },
            { "cn-qingdao", "business.aliyuncs.com" },
            { "cn-shanghai", "business.aliyuncs.com" },
            { "cn-hongkong", "business.aliyuncs.com" },
            { "ap-southeast-1", "business.ap-southeast-1.aliyuncs.com" },
            { "ap-southeast-2", "business.ap-southeast-1.aliyuncs.com" },
            { "ap-southeast-3", "business.ap-southeast-1.aliyuncs.com" },
            { "eu-central-1", "business.ap-southeast-1.aliyuncs.com" },
            { "cn-huhehaote", "business.aliyuncs.com" },
            { "ap-southeast-5", "business.ap-southeast-1.aliyuncs.com" },
            { "us-east-1", "business.ap-southeast-1.aliyuncs.com" },
            { "cn-zhangjiakou", "business.aliyuncs.com" },
            { "us-west-1", "business.ap-southeast-1.aliyuncs.com" },
            { "cn-hangzhou", "business.aliyuncs.com" },
        };

        public static string endpointRegionalType = "regional";
    }
}
