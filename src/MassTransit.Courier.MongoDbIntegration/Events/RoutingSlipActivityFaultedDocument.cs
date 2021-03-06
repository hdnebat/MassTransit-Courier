﻿// Copyright 2007-2013 Chris Patterson
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Courier.MongoDbIntegration.Events
{
    using System;
    using Contracts;
    using Documents;


    public class RoutingSlipActivityFaultedDocument :
        RoutingSlipEventDocument
    {
        public RoutingSlipActivityFaultedDocument(RoutingSlipActivityFaulted message)
            : base(message.Timestamp)
        {
            ActivityName = message.ActivityName;
            ActivityTrackingNumber = message.ActivityTrackingNumber;
            if (message.ExceptionInfo != null)
                ExceptionInfo = new ExceptionInfoDocument(message.ExceptionInfo);
        }

        public string ActivityName { get; private set; }
        public Guid ActivityTrackingNumber { get; private set; }
        public ExceptionInfoDocument ExceptionInfo { get; private set; }
    }
}