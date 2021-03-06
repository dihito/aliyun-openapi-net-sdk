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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListTagSetsResponseUnmarshaller
    {
        public static ListTagSetsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTagSetsResponse listTagSetsResponse = new ListTagSetsResponse();

			listTagSetsResponse.HttpResponse = context.HttpResponse;
			listTagSetsResponse.RequestId = context.StringValue("ListTagSets.RequestId");
			listTagSetsResponse.NextMarker = context.StringValue("ListTagSets.NextMarker");

			List<ListTagSetsResponse.ListTagSets_SetsItem> listTagSetsResponse_sets = new List<ListTagSetsResponse.ListTagSets_SetsItem>();
			for (int i = 0; i < context.Length("ListTagSets.Sets.Length"); i++) {
				ListTagSetsResponse.ListTagSets_SetsItem setsItem = new ListTagSetsResponse.ListTagSets_SetsItem();
				setsItem.SetId = context.StringValue("ListTagSets.Sets["+ i +"].SetId");
				setsItem.Status = context.StringValue("ListTagSets.Sets["+ i +"].Status");
				setsItem.Photos = context.LongValue("ListTagSets.Sets["+ i +"].Photos");
				setsItem.CreateTime = context.StringValue("ListTagSets.Sets["+ i +"].CreateTime");
				setsItem.ModifyTime = context.StringValue("ListTagSets.Sets["+ i +"].ModifyTime");

				listTagSetsResponse_sets.Add(setsItem);
			}
			listTagSetsResponse.Sets = listTagSetsResponse_sets;
        
			return listTagSetsResponse;
        }
    }
}
