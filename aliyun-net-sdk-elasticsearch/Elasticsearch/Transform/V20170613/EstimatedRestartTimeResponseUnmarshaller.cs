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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class EstimatedRestartTimeResponseUnmarshaller
    {
        public static EstimatedRestartTimeResponse Unmarshall(UnmarshallerContext context)
        {
			EstimatedRestartTimeResponse estimatedRestartTimeResponse = new EstimatedRestartTimeResponse();

			estimatedRestartTimeResponse.HttpResponse = context.HttpResponse;
			estimatedRestartTimeResponse.RequestId = context.StringValue("EstimatedRestartTime.RequestId");

			EstimatedRestartTimeResponse.EstimatedRestartTime_Result result = new EstimatedRestartTimeResponse.EstimatedRestartTime_Result();
			result._Value = context.LongValue("EstimatedRestartTime.Result.value");
			result.Unit = context.StringValue("EstimatedRestartTime.Result.unit");
			estimatedRestartTimeResponse.Result = result;
        
			return estimatedRestartTimeResponse;
        }
    }
}
