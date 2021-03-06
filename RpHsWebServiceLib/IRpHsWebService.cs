﻿/*******************************************************************************
 * Copyright 2015 Keith Cassidy
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 ******************************************************************************/

using System.ServiceModel;
using System.ServiceModel.Web;

namespace RpHsWebServiceLib
{
    [ServiceContract(Name = "RpHsWebService")]
    public interface IRpHsWebService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = Routing.RunActionListRoute,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        bool RunActionList(string actionListName);

        [OperationContract]
        [WebGet(UriTemplate = Routing.GetStatusRoute, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        AlarmStatus GetStatus();
    }
}