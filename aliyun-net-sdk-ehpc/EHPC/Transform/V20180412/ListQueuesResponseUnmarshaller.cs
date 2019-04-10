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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListQueuesResponseUnmarshaller
    {
        public static ListQueuesResponse Unmarshall(UnmarshallerContext context)
        {
			ListQueuesResponse listQueuesResponse = new ListQueuesResponse();

			listQueuesResponse.HttpResponse = context.HttpResponse;
			listQueuesResponse.RequestId = context.StringValue("ListQueues.RequestId");

			List<ListQueuesResponse.ListQueues_QueueInfo> listQueuesResponse_queues = new List<ListQueuesResponse.ListQueues_QueueInfo>();
			for (int i = 0; i < context.Length("ListQueues.Queues.Length"); i++) {
				ListQueuesResponse.ListQueues_QueueInfo queueInfo = new ListQueuesResponse.ListQueues_QueueInfo();
				queueInfo.QueueName = context.StringValue("ListQueues.Queues["+ i +"].QueueName");
				queueInfo.Type = context.StringValue("ListQueues.Queues["+ i +"].Type");

				listQueuesResponse_queues.Add(queueInfo);
			}
			listQueuesResponse.Queues = listQueuesResponse_queues;
        
			return listQueuesResponse;
        }
    }
}
