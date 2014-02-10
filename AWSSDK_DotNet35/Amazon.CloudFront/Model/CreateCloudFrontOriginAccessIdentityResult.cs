/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> The returned result of the corresponding request. </para>
    /// </summary>
    public partial class CreateCloudFrontOriginAccessIdentityResult : AmazonWebServiceResponse
    {
        
        private CloudFrontOriginAccessIdentity cloudFrontOriginAccessIdentity;
        private string location;
        private string eTag;


        /// <summary>
        /// The origin access identity's information.
        ///  
        /// </summary>
        public CloudFrontOriginAccessIdentity CloudFrontOriginAccessIdentity
        {
            get { return this.cloudFrontOriginAccessIdentity; }
            set { this.cloudFrontOriginAccessIdentity = value; }
        }

        // Check to see if CloudFrontOriginAccessIdentity property is set
        internal bool IsSetCloudFrontOriginAccessIdentity()
        {
            return this.cloudFrontOriginAccessIdentity != null;
        }

        /// <summary>
        /// The fully qualified URI of the new origin access identity just created. For example:
        /// https://cloudfront.amazonaws.com/2010-11-01/origin-access-identity/cloudfront/E74FTE3AJFJ256A.
        ///  
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this.location != null;
        }

        /// <summary>
        /// The current version of the origin access identity created.
        ///  
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this.eTag != null;
        }
    }
}