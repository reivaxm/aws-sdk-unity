//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

/*
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// <code>PutRecords</code> results.
    /// </summary>
    public partial class PutRecordsResponse : AmazonWebServiceResponse
    {
        private int? _failedRecordCount;
        private List<PutRecordsResultEntry> _records = new List<PutRecordsResultEntry>();

        /// <summary>
        /// Gets and sets the property FailedRecordCount. 
        /// <para>
        /// The number of unsuccessfully processed records in a <code>PutRecords</code> request.
        /// </para>
        /// </summary>
        public int FailedRecordCount
        {
            get { return this._failedRecordCount.GetValueOrDefault(); }
            set { this._failedRecordCount = value; }
        }

        // Check to see if FailedRecordCount property is set
        internal bool IsSetFailedRecordCount()
        {
            return this._failedRecordCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// An array of successfully and unsuccessfully processed record results, correlated with
        /// the request by natural ordering. A record that is successfully added to your Amazon
        /// Kinesis stream includes <code>SequenceNumber</code> and <code>ShardId</code> in the
        /// result. A record that fails to be added to your Amazon Kinesis stream includes <code>ErrorCode</code>
        /// and <code>ErrorMessage</code> in the result.
        /// </para>
        /// </summary>
        public List<PutRecordsResultEntry> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && this._records.Count > 0; 
        }

    }
}