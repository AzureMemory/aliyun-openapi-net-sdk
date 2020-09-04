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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vcs;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class ListPersonTraceRequest : RpcAcsRequest<ListPersonTraceResponse>
    {
        public ListPersonTraceRequest()
            : base("Vcs", "2020-05-15", "ListPersonTrace")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string corpId;

		private string groupId;

		private string endTime;

		private string startTime;

		private string pageNumber;

		private string pageSize;

		private string dataSourceId;

		private string personId;

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
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
				DictionaryUtil.Add(BodyParameters, "GroupId", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(BodyParameters, "StartTime", value);
			}
		}

		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value);
			}
		}

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value);
			}
		}

		public string DataSourceId
		{
			get
			{
				return dataSourceId;
			}
			set	
			{
				dataSourceId = value;
				DictionaryUtil.Add(BodyParameters, "DataSourceId", value);
			}
		}

		public string PersonId
		{
			get
			{
				return personId;
			}
			set	
			{
				personId = value;
				DictionaryUtil.Add(BodyParameters, "PersonId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListPersonTraceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListPersonTraceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}