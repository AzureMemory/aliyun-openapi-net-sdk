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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class GetCloudMetricLogsResponse : AcsResponse
	{

		private string requestId;

		private List<GetCloudMetricLogs_MetricLog> metricLogs;

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

		public List<GetCloudMetricLogs_MetricLog> MetricLogs
		{
			get
			{
				return metricLogs;
			}
			set	
			{
				metricLogs = value;
			}
		}

		public class GetCloudMetricLogs_MetricLog
		{

			private int? time;

			private string instanceId;

			private string hostname;

			private string networkInterface;

			private string diskDevice;

			private string metricData;

			public int? Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
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

			public string Hostname
			{
				get
				{
					return hostname;
				}
				set	
				{
					hostname = value;
				}
			}

			public string NetworkInterface
			{
				get
				{
					return networkInterface;
				}
				set	
				{
					networkInterface = value;
				}
			}

			public string DiskDevice
			{
				get
				{
					return diskDevice;
				}
				set	
				{
					diskDevice = value;
				}
			}

			public string MetricData
			{
				get
				{
					return metricData;
				}
				set	
				{
					metricData = value;
				}
			}
		}
	}
}
