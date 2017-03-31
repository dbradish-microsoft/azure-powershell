// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Represents the response to a List Azure SQL Active Directory
    /// Administrators request.
    /// </summary>
    public partial class ServerAdministratorListResponse : AzureOperationResponse, IEnumerable<ServerAdministrator>
    {
        private IList<ServerAdministrator> _administrators;
        
        /// <summary>
        /// Optional. Gets or sets the list of Azure SQL Server Active
        /// Directory Administrators for the server.
        /// </summary>
        public IList<ServerAdministrator> Administrators
        {
            get { return this._administrators; }
            set { this._administrators = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ServerAdministratorListResponse
        /// class.
        /// </summary>
        public ServerAdministratorListResponse()
        {
            this.Administrators = new LazyList<ServerAdministrator>();
        }
        
        /// <summary>
        /// Gets the sequence of Administrators.
        /// </summary>
        public IEnumerator<ServerAdministrator> GetEnumerator()
        {
            return this.Administrators.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Administrators.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
