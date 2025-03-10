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
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = context.HttpResponse;
			describeRegionsResponse.RequestId = context.StringValue("DescribeRegions.RequestId");

			List<DescribeRegionsResponse.DescribeRegions_Region> describeRegionsResponse_regions = new List<DescribeRegionsResponse.DescribeRegions_Region>();
			for (int i = 0; i < context.Length("DescribeRegions.Regions.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_Region region = new DescribeRegionsResponse.DescribeRegions_Region();
				region.RegionId = context.StringValue("DescribeRegions.Regions["+ i +"].RegionId");

				List<DescribeRegionsResponse.DescribeRegions_Region.DescribeRegions_Zone> region_zones = new List<DescribeRegionsResponse.DescribeRegions_Region.DescribeRegions_Zone>();
				for (int j = 0; j < context.Length("DescribeRegions.Regions["+ i +"].Zones.Length"); j++) {
					DescribeRegionsResponse.DescribeRegions_Region.DescribeRegions_Zone zone = new DescribeRegionsResponse.DescribeRegions_Region.DescribeRegions_Zone();
					zone.ZoneId = context.StringValue("DescribeRegions.Regions["+ i +"].Zones["+ j +"].ZoneId");
					zone.VpcEnabled = context.BooleanValue("DescribeRegions.Regions["+ i +"].Zones["+ j +"].VpcEnabled");

					region_zones.Add(zone);
				}
				region.Zones = region_zones;

				describeRegionsResponse_regions.Add(region);
			}
			describeRegionsResponse.Regions = describeRegionsResponse_regions;
        
			return describeRegionsResponse;
        }
    }
}
