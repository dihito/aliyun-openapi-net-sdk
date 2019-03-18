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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.ImageSearch.Transform;
using Aliyun.Acs.ImageSearch.Transform.V20180120;

namespace Aliyun.Acs.ImageSearch.Model.V20180120
{
    public class DeleteItemRequest : RoaAcsRequest<DeleteItemResponse>
    {
        public DeleteItemRequest()
            : base("ImageSearch", "2018-01-20", "DeleteItem", "imagesearch", "openAPI")
        {
			UriPattern = "/item/delete";
			Method = MethodType.POST;
        }

		private string instanceName;

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(QueryParameters, "instanceName", value);
			}
		}

        public override DeleteItemResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteItemResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
