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
	public class ListInvocationResultsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListInvocationResults_InvocationResult> invocationResults;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<ListInvocationResults_InvocationResult> InvocationResults
		{
			get
			{
				return invocationResults;
			}
			set	
			{
				invocationResults = value;
			}
		}

		public class ListInvocationResults_InvocationResult
		{

			private bool? success;

			private string commandId;

			private string instanceId;

			private string invokeRecordStatus;

			private string finishedTime;

			private int? exitCode;

			private string message;

			public bool? Success
			{
				get
				{
					return success;
				}
				set	
				{
					success = value;
				}
			}

			public string CommandId
			{
				get
				{
					return commandId;
				}
				set	
				{
					commandId = value;
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

			public string InvokeRecordStatus
			{
				get
				{
					return invokeRecordStatus;
				}
				set	
				{
					invokeRecordStatus = value;
				}
			}

			public string FinishedTime
			{
				get
				{
					return finishedTime;
				}
				set	
				{
					finishedTime = value;
				}
			}

			public int? ExitCode
			{
				get
				{
					return exitCode;
				}
				set	
				{
					exitCode = value;
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
		}
	}
}
