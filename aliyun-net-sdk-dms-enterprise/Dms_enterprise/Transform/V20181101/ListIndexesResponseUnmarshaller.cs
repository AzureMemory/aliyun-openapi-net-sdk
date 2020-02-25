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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListIndexesResponseUnmarshaller
    {
        public static ListIndexesResponse Unmarshall(UnmarshallerContext context)
        {
			ListIndexesResponse listIndexesResponse = new ListIndexesResponse();

			listIndexesResponse.HttpResponse = context.HttpResponse;
			listIndexesResponse.RequestId = context.StringValue("ListIndexes.RequestId");
			listIndexesResponse.Success = context.BooleanValue("ListIndexes.Success");
			listIndexesResponse.ErrorMessage = context.StringValue("ListIndexes.ErrorMessage");
			listIndexesResponse.ErrorCode = context.StringValue("ListIndexes.ErrorCode");

			List<ListIndexesResponse.ListIndexes_Index> listIndexesResponse_indexList = new List<ListIndexesResponse.ListIndexes_Index>();
			for (int i = 0; i < context.Length("ListIndexes.IndexList.Length"); i++) {
				ListIndexesResponse.ListIndexes_Index index = new ListIndexesResponse.ListIndexes_Index();
				index.IndexId = context.StringValue("ListIndexes.IndexList["+ i +"].IndexId");
				index.TableId = context.StringValue("ListIndexes.IndexList["+ i +"].TableId");
				index.IndexName = context.StringValue("ListIndexes.IndexList["+ i +"].IndexName");
				index.IndexType = context.StringValue("ListIndexes.IndexList["+ i +"].IndexType");
				index.IndexComment = context.StringValue("ListIndexes.IndexList["+ i +"].IndexComment");

				listIndexesResponse_indexList.Add(index);
			}
			listIndexesResponse.IndexList = listIndexesResponse_indexList;
        
			return listIndexesResponse;
        }
    }
}
