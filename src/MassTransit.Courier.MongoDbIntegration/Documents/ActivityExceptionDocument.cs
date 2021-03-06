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
namespace MassTransit.Courier.MongoDbIntegration.Documents
{
    using System;
    using Contracts;


    public class ActivityExceptionDocument
    {
        public ActivityExceptionDocument(ActivityException activityException)
        {
            ActivityTrackingNumber = activityException.ActivityTrackingNumber;
            HostAddress = activityException.HostAddress;
            MachineName = activityException.MachineName;
            ProcessId = activityException.ProcessId;
            ProcessName = activityException.ProcessName;
            ActivityName = activityException.Name;
            Timestamp = activityException.Timestamp;

            if (activityException.ExceptionInfo != null)
                ExceptionInfo = new ExceptionInfoDocument(activityException.ExceptionInfo);
        }

        public string ActivityName { get; private set; }
        public Guid ActivityTrackingNumber { get; private set; }
        public Uri HostAddress { get; private set; }
        public string MachineName { get; private set; }
        public string ProcessName { get; private set; }
        public int ProcessId { get; private set; }
        public DateTime Timestamp { get; private set; }
        public ExceptionInfoDocument ExceptionInfo { get; private set; }
    }
}