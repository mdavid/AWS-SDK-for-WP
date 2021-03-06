/*
   Copyright 2011 Microsoft Corp.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.

*/

/*******************************************************************************
 *  AWS SDK for WP7
 */

using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Adds the specified permission(s) to a queue for the specified principal(s). This allows for sharing access to the queue.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2009-02-01/", IsNullable = false)]
    public class AddPermissionRequest
    {
        private string queueUrlField;
        private string labelField;
        private List<string> awsAccountIdField;
        private List<string> actionNameField;

        /// <summary>
        /// Gets and sets the QueueUrl property.
        /// The URL associated with the Amazon SQS queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueueUrl")]
        public string QueueUrl
        {
            get { return this.queueUrlField; }
            set { this.queueUrlField = value; }
        }

        /// <summary>
        /// Sets the QueueUrl property
        /// </summary>
        /// <param name="queueUrl">The URL associated with the Amazon SQS queue.</param>
        /// <returns>this instance</returns>
        public AddPermissionRequest WithQueueUrl(string queueUrl)
        {
            this.queueUrlField = queueUrl;
            return this;
        }

        /// <summary>
        /// Checks if QueueUrl property is set
        /// </summary>
        /// <returns>true if QueueUrl property is set</returns>
        public bool IsSetQueueUrl()
        {
            return this.queueUrlField != null;
        }

        /// <summary>
        /// Gets and sets the Label property.
        /// The unique identification of the permission you're setting. Maximum 80 characters; alphanumeric characters, hyphens (-),
        /// and underscores (_) are allowed.
        /// </summary>
        [XmlElementAttribute(ElementName = "Label")]
        public string Label
        {
            get { return this.labelField; }
            set { this.labelField = value; }
        }

        /// <summary>
        /// Sets the Label property
        /// </summary>
        /// <param name="label">The unique identification of the permission you're setting. Maximum 80 characters; alphanumeric characters, hyphens (-),
        /// and underscores (_) are allowed.</param>
        /// <returns>this instance</returns>
        public AddPermissionRequest WithLabel(string label)
        {
            this.labelField = label;
            return this;
        }

        /// <summary>
        /// Checks if Label property is set
        /// </summary>
        /// <returns>true if Label property is set</returns>
        public bool IsSetLabel()
        {
            return this.labelField != null;
        }

        /// <summary>
        /// Gets and sets the AWSAccountId property.
        /// The AWS account number of the principal who will be given permission. The principal must have an AWS account, but does
        /// not need to be signed up for Amazon SQS.
        /// </summary>
        [XmlElementAttribute(ElementName = "AWSAccountId")]
        public List<string> AWSAccountId
        {
            get
            {
                if (this.awsAccountIdField == null)
                {
                    this.awsAccountIdField = new List<string>();
                }
                return this.awsAccountIdField;
            }
        }

        /// <summary>
        /// Sets the AWSAccountId property
        /// </summary>
        /// <param name="list">The AWS account number of the principal who will be given permission. The principal must have an AWS account, but does
        /// not need to be signed up for Amazon SQS.</param>
        /// <returns>this instance</returns>
        public AddPermissionRequest WithAWSAccountId(params string[] list)
        {
            foreach (string item in list)
            {
                AWSAccountId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if AWSAccountId property is set
        /// </summary>
        /// <returns>true if AWSAccountId property is set</returns>
        public bool IsSetAWSAccountId()
        {
            return (AWSAccountId.Count > 0);
        }

        /// <summary>
        /// Gets and sets the ActionName property.
        /// The action you want to allow for the specified principal. For more information about these actions, see Understanding
        /// Permissions in the Amazon SQS Developer Guide.
        ///
        /// Valid values are: * | SendMessage | ReceiveMessage | DeleteMessage | ChangeMessageVisibility | GetQueueAttributes
        /// </summary>
        [XmlElementAttribute(ElementName = "ActionName")]
        public List<string> ActionName
        {
            get
            {
                if (this.actionNameField == null)
                {
                    this.actionNameField = new List<string>();
                }
                return this.actionNameField;
            }
        }

        /// <summary>
        /// Sets the ActionName property
        /// </summary>
        /// <param name="list">The action you want to allow for the specified principal. For more information about these actions, see Understanding
        /// Permissions in the Amazon SQS Developer Guide.
        ///
        /// Valid values are: * | SendMessage | ReceiveMessage | DeleteMessage | ChangeMessageVisibility | GetQueueAttributes</param>
        /// <returns>this instance</returns>
        public AddPermissionRequest WithActionName(params string[] list)
        {
            foreach (string item in list)
            {
                ActionName.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ActionName property is set
        /// </summary>
        /// <returns>true if ActionName property is set</returns>
        public bool IsSetActionName()
        {
            return (ActionName.Count > 0);
        }

    }
}
