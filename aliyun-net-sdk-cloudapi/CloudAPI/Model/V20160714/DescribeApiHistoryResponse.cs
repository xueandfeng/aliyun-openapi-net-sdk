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

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeApiHistoryResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private string groupId;

		private string groupName;

		private string stageName;

		private string apiId;

		private string apiName;

		private string description;

		private string historyVersion;

		private string status;

		private string visibility;

		private string authType;

		private string resultType;

		private string resultSample;

		private string failResultSample;

		private string deployedTime;

		private string allowSignatureMethod;

		private string resultBodyModel;

		private bool? forceNonceCheck;

		private bool? disableInternet;

		private List<DescribeApiHistory_ErrorCodeSample> errorCodeSamples;

		private List<DescribeApiHistory_ResultDescription> resultDescriptions;

		private List<DescribeApiHistory_SystemParameter> systemParameters;

		private List<DescribeApiHistory_CustomSystemParameter> customSystemParameters;

		private List<DescribeApiHistory_ConstantParameter> constantParameters;

		private List<DescribeApiHistory_RequestParameter> requestParameters;

		private List<DescribeApiHistory_ServiceParameter> serviceParameters;

		private List<DescribeApiHistory_ServiceParameterMap> serviceParametersMap;

		private DescribeApiHistory_RequestConfig requestConfig;

		private DescribeApiHistory_ServiceConfig serviceConfig;

		private DescribeApiHistory_OpenIdConnectConfig openIdConnectConfig;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
			}
		}

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
			}
		}

		public string StageName
		{
			get
			{
				return stageName;
			}
			set	
			{
				stageName = value;
			}
		}

		public string ApiId
		{
			get
			{
				return apiId;
			}
			set	
			{
				apiId = value;
			}
		}

		public string ApiName
		{
			get
			{
				return apiName;
			}
			set	
			{
				apiName = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public string HistoryVersion
		{
			get
			{
				return historyVersion;
			}
			set	
			{
				historyVersion = value;
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string Visibility
		{
			get
			{
				return visibility;
			}
			set	
			{
				visibility = value;
			}
		}

		public string AuthType
		{
			get
			{
				return authType;
			}
			set	
			{
				authType = value;
			}
		}

		public string ResultType
		{
			get
			{
				return resultType;
			}
			set	
			{
				resultType = value;
			}
		}

		public string ResultSample
		{
			get
			{
				return resultSample;
			}
			set	
			{
				resultSample = value;
			}
		}

		public string FailResultSample
		{
			get
			{
				return failResultSample;
			}
			set	
			{
				failResultSample = value;
			}
		}

		public string DeployedTime
		{
			get
			{
				return deployedTime;
			}
			set	
			{
				deployedTime = value;
			}
		}

		public string AllowSignatureMethod
		{
			get
			{
				return allowSignatureMethod;
			}
			set	
			{
				allowSignatureMethod = value;
			}
		}

		public string ResultBodyModel
		{
			get
			{
				return resultBodyModel;
			}
			set	
			{
				resultBodyModel = value;
			}
		}

		public bool? ForceNonceCheck
		{
			get
			{
				return forceNonceCheck;
			}
			set	
			{
				forceNonceCheck = value;
			}
		}

		public bool? DisableInternet
		{
			get
			{
				return disableInternet;
			}
			set	
			{
				disableInternet = value;
			}
		}

		public List<DescribeApiHistory_ErrorCodeSample> ErrorCodeSamples
		{
			get
			{
				return errorCodeSamples;
			}
			set	
			{
				errorCodeSamples = value;
			}
		}

		public List<DescribeApiHistory_ResultDescription> ResultDescriptions
		{
			get
			{
				return resultDescriptions;
			}
			set	
			{
				resultDescriptions = value;
			}
		}

		public List<DescribeApiHistory_SystemParameter> SystemParameters
		{
			get
			{
				return systemParameters;
			}
			set	
			{
				systemParameters = value;
			}
		}

		public List<DescribeApiHistory_CustomSystemParameter> CustomSystemParameters
		{
			get
			{
				return customSystemParameters;
			}
			set	
			{
				customSystemParameters = value;
			}
		}

		public List<DescribeApiHistory_ConstantParameter> ConstantParameters
		{
			get
			{
				return constantParameters;
			}
			set	
			{
				constantParameters = value;
			}
		}

		public List<DescribeApiHistory_RequestParameter> RequestParameters
		{
			get
			{
				return requestParameters;
			}
			set	
			{
				requestParameters = value;
			}
		}

		public List<DescribeApiHistory_ServiceParameter> ServiceParameters
		{
			get
			{
				return serviceParameters;
			}
			set	
			{
				serviceParameters = value;
			}
		}

		public List<DescribeApiHistory_ServiceParameterMap> ServiceParametersMap
		{
			get
			{
				return serviceParametersMap;
			}
			set	
			{
				serviceParametersMap = value;
			}
		}

		public DescribeApiHistory_RequestConfig RequestConfig
		{
			get
			{
				return requestConfig;
			}
			set	
			{
				requestConfig = value;
			}
		}

		public DescribeApiHistory_ServiceConfig ServiceConfig
		{
			get
			{
				return serviceConfig;
			}
			set	
			{
				serviceConfig = value;
			}
		}

		public DescribeApiHistory_OpenIdConnectConfig OpenIdConnectConfig
		{
			get
			{
				return openIdConnectConfig;
			}
			set	
			{
				openIdConnectConfig = value;
			}
		}

		public class DescribeApiHistory_ErrorCodeSample
		{

			private string code;

			private string message;

			private string description;

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}

		public class DescribeApiHistory_ResultDescription
		{

			private string id;

			private string pid;

			private bool? hasChild;

			private string key;

			private string name;

			private bool? mandatory;

			private string type;

			private string description;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Pid
			{
				get
				{
					return pid;
				}
				set	
				{
					pid = value;
				}
			}

			public bool? HasChild
			{
				get
				{
					return hasChild;
				}
				set	
				{
					hasChild = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public bool? Mandatory
			{
				get
				{
					return mandatory;
				}
				set	
				{
					mandatory = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}

		public class DescribeApiHistory_SystemParameter
		{

			private string parameterName;

			private string serviceParameterName;

			private string location;

			private string demoValue;

			private string description;

			public string ParameterName
			{
				get
				{
					return parameterName;
				}
				set	
				{
					parameterName = value;
				}
			}

			public string ServiceParameterName
			{
				get
				{
					return serviceParameterName;
				}
				set	
				{
					serviceParameterName = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string DemoValue
			{
				get
				{
					return demoValue;
				}
				set	
				{
					demoValue = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}

		public class DescribeApiHistory_CustomSystemParameter
		{

			private string parameterName;

			private string serviceParameterName;

			private string location;

			private string demoValue;

			private string description;

			public string ParameterName
			{
				get
				{
					return parameterName;
				}
				set	
				{
					parameterName = value;
				}
			}

			public string ServiceParameterName
			{
				get
				{
					return serviceParameterName;
				}
				set	
				{
					serviceParameterName = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string DemoValue
			{
				get
				{
					return demoValue;
				}
				set	
				{
					demoValue = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}

		public class DescribeApiHistory_ConstantParameter
		{

			private string serviceParameterName;

			private string constantValue;

			private string location;

			private string description;

			public string ServiceParameterName
			{
				get
				{
					return serviceParameterName;
				}
				set	
				{
					serviceParameterName = value;
				}
			}

			public string ConstantValue
			{
				get
				{
					return constantValue;
				}
				set	
				{
					constantValue = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}

		public class DescribeApiHistory_RequestParameter
		{

			private string apiParameterName;

			private string location;

			private string parameterType;

			private string required;

			private string defaultValue;

			private string demoValue;

			private long? maxValue;

			private long? minValue;

			private long? maxLength;

			private long? minLength;

			private string regularExpression;

			private string jsonScheme;

			private string enumValue;

			private string docShow;

			private int? docOrder;

			private string description;

			public string ApiParameterName
			{
				get
				{
					return apiParameterName;
				}
				set	
				{
					apiParameterName = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string ParameterType
			{
				get
				{
					return parameterType;
				}
				set	
				{
					parameterType = value;
				}
			}

			public string Required
			{
				get
				{
					return required;
				}
				set	
				{
					required = value;
				}
			}

			public string DefaultValue
			{
				get
				{
					return defaultValue;
				}
				set	
				{
					defaultValue = value;
				}
			}

			public string DemoValue
			{
				get
				{
					return demoValue;
				}
				set	
				{
					demoValue = value;
				}
			}

			public long? MaxValue
			{
				get
				{
					return maxValue;
				}
				set	
				{
					maxValue = value;
				}
			}

			public long? MinValue
			{
				get
				{
					return minValue;
				}
				set	
				{
					minValue = value;
				}
			}

			public long? MaxLength
			{
				get
				{
					return maxLength;
				}
				set	
				{
					maxLength = value;
				}
			}

			public long? MinLength
			{
				get
				{
					return minLength;
				}
				set	
				{
					minLength = value;
				}
			}

			public string RegularExpression
			{
				get
				{
					return regularExpression;
				}
				set	
				{
					regularExpression = value;
				}
			}

			public string JsonScheme
			{
				get
				{
					return jsonScheme;
				}
				set	
				{
					jsonScheme = value;
				}
			}

			public string EnumValue
			{
				get
				{
					return enumValue;
				}
				set	
				{
					enumValue = value;
				}
			}

			public string DocShow
			{
				get
				{
					return docShow;
				}
				set	
				{
					docShow = value;
				}
			}

			public int? DocOrder
			{
				get
				{
					return docOrder;
				}
				set	
				{
					docOrder = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}

		public class DescribeApiHistory_ServiceParameter
		{

			private string serviceParameterName;

			private string location;

			private string parameterType;

			public string ServiceParameterName
			{
				get
				{
					return serviceParameterName;
				}
				set	
				{
					serviceParameterName = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string ParameterType
			{
				get
				{
					return parameterType;
				}
				set	
				{
					parameterType = value;
				}
			}
		}

		public class DescribeApiHistory_ServiceParameterMap
		{

			private string serviceParameterName;

			private string requestParameterName;

			public string ServiceParameterName
			{
				get
				{
					return serviceParameterName;
				}
				set	
				{
					serviceParameterName = value;
				}
			}

			public string RequestParameterName
			{
				get
				{
					return requestParameterName;
				}
				set	
				{
					requestParameterName = value;
				}
			}
		}

		public class DescribeApiHistory_RequestConfig
		{

			private string requestProtocol;

			private string requestHttpMethod;

			private string requestPath;

			private string bodyFormat;

			private string postBodyDescription;

			private string requestMode;

			private string bodyModel;

			public string RequestProtocol
			{
				get
				{
					return requestProtocol;
				}
				set	
				{
					requestProtocol = value;
				}
			}

			public string RequestHttpMethod
			{
				get
				{
					return requestHttpMethod;
				}
				set	
				{
					requestHttpMethod = value;
				}
			}

			public string RequestPath
			{
				get
				{
					return requestPath;
				}
				set	
				{
					requestPath = value;
				}
			}

			public string BodyFormat
			{
				get
				{
					return bodyFormat;
				}
				set	
				{
					bodyFormat = value;
				}
			}

			public string PostBodyDescription
			{
				get
				{
					return postBodyDescription;
				}
				set	
				{
					postBodyDescription = value;
				}
			}

			public string RequestMode
			{
				get
				{
					return requestMode;
				}
				set	
				{
					requestMode = value;
				}
			}

			public string BodyModel
			{
				get
				{
					return bodyModel;
				}
				set	
				{
					bodyModel = value;
				}
			}
		}

		public class DescribeApiHistory_ServiceConfig
		{

			private string serviceProtocol;

			private string serviceAddress;

			private string serviceHttpMethod;

			private string servicePath;

			private int? serviceTimeout;

			private string mock;

			private string mockResult;

			private string serviceVpcEnable;

			private int? mockStatusCode;

			private List<DescribeApiHistory_MockHeader> mockHeaders;

			private DescribeApiHistory_VpcConfig vpcConfig;

			private DescribeApiHistory_FunctionComputeConfig functionComputeConfig;

			public string ServiceProtocol
			{
				get
				{
					return serviceProtocol;
				}
				set	
				{
					serviceProtocol = value;
				}
			}

			public string ServiceAddress
			{
				get
				{
					return serviceAddress;
				}
				set	
				{
					serviceAddress = value;
				}
			}

			public string ServiceHttpMethod
			{
				get
				{
					return serviceHttpMethod;
				}
				set	
				{
					serviceHttpMethod = value;
				}
			}

			public string ServicePath
			{
				get
				{
					return servicePath;
				}
				set	
				{
					servicePath = value;
				}
			}

			public int? ServiceTimeout
			{
				get
				{
					return serviceTimeout;
				}
				set	
				{
					serviceTimeout = value;
				}
			}

			public string Mock
			{
				get
				{
					return mock;
				}
				set	
				{
					mock = value;
				}
			}

			public string MockResult
			{
				get
				{
					return mockResult;
				}
				set	
				{
					mockResult = value;
				}
			}

			public string ServiceVpcEnable
			{
				get
				{
					return serviceVpcEnable;
				}
				set	
				{
					serviceVpcEnable = value;
				}
			}

			public int? MockStatusCode
			{
				get
				{
					return mockStatusCode;
				}
				set	
				{
					mockStatusCode = value;
				}
			}

			public List<DescribeApiHistory_MockHeader> MockHeaders
			{
				get
				{
					return mockHeaders;
				}
				set	
				{
					mockHeaders = value;
				}
			}

			public DescribeApiHistory_VpcConfig VpcConfig
			{
				get
				{
					return vpcConfig;
				}
				set	
				{
					vpcConfig = value;
				}
			}

			public DescribeApiHistory_FunctionComputeConfig FunctionComputeConfig
			{
				get
				{
					return functionComputeConfig;
				}
				set	
				{
					functionComputeConfig = value;
				}
			}

			public class DescribeApiHistory_MockHeader
			{

				private string headerName;

				private string headerValue;

				public string HeaderName
				{
					get
					{
						return headerName;
					}
					set	
					{
						headerName = value;
					}
				}

				public string HeaderValue
				{
					get
					{
						return headerValue;
					}
					set	
					{
						headerValue = value;
					}
				}
			}

			public class DescribeApiHistory_VpcConfig
			{

				private string name;

				private string vpcId;

				private string instanceId;

				private int? port;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string VpcId
				{
					get
					{
						return vpcId;
					}
					set	
					{
						vpcId = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public int? Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
					}
				}
			}

			public class DescribeApiHistory_FunctionComputeConfig
			{

				private string regionId;

				private string serviceName;

				private string functionName;

				private string roleArn;

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				public string ServiceName
				{
					get
					{
						return serviceName;
					}
					set	
					{
						serviceName = value;
					}
				}

				public string FunctionName
				{
					get
					{
						return functionName;
					}
					set	
					{
						functionName = value;
					}
				}

				public string RoleArn
				{
					get
					{
						return roleArn;
					}
					set	
					{
						roleArn = value;
					}
				}
			}
		}

		public class DescribeApiHistory_OpenIdConnectConfig
		{

			private string openIdApiType;

			private string idTokenParamName;

			private string publicKeyId;

			private string publicKey;

			public string OpenIdApiType
			{
				get
				{
					return openIdApiType;
				}
				set	
				{
					openIdApiType = value;
				}
			}

			public string IdTokenParamName
			{
				get
				{
					return idTokenParamName;
				}
				set	
				{
					idTokenParamName = value;
				}
			}

			public string PublicKeyId
			{
				get
				{
					return publicKeyId;
				}
				set	
				{
					publicKeyId = value;
				}
			}

			public string PublicKey
			{
				get
				{
					return publicKey;
				}
				set	
				{
					publicKey = value;
				}
			}
		}
	}
}
