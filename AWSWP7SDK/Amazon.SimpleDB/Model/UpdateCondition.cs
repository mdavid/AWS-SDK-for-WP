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

using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model
{
    ///<summary>
    ///Describes the condition used to perform a conditional PutAttributes
    ///or conditional DeleteAttributes.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class UpdateCondition
    {
        private string nameField;
        private string valueField;
        private bool? existsField;

        /// <summary>
        /// Gets and sets the Name property.
        /// The name of the attribute used for the conditional check.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The name of the attribute used for the conditional check.</param>
        /// <returns>this instance</returns>
        public UpdateCondition WithName(string name)
        {
            this.nameField = name;
            return this;
        }

        /// <summary>
        /// Checks if Name property is set
        /// </summary>
        /// <returns>true if Name property is set</returns>
        public bool IsSetName()
        {
            return this.nameField != null;
        }

        /// <summary>
        /// Gets and sets the Value property.
        /// The value of the attribute used for the conditional check.
        /// </summary>
        [XmlElementAttribute(ElementName = "Value")]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

        /// <summary>
        /// Sets the Value property
        /// </summary>
        /// <param name="value">The value of the attribute used for the conditional check.</param>
        /// <returns>this instance</returns>
        public UpdateCondition WithValue(string value)
        {
            this.valueField = value;
            return this;
        }

        /// <summary>
        /// Checks if Value property is set
        /// </summary>
        /// <returns>true if Value property is set</returns>
        public bool IsSetValue()
        {
            return this.valueField != null;
        }

        /// <summary>
        /// Gets and sets the Exists property.
        /// Check for the existence of the attribute used for the conditional check.
        /// If this field is unspecified or true, UpdateCondition.Value must be set to a value.
        /// If this field is false, UpdateCondition.Value should not have a value assigned to it.
        /// If no value is associated with this field, SimpleDB uses a default value of 'true'
        /// </summary>
        [XmlElementAttribute(ElementName = "Exists")]
        public bool Exists
        {
            get { return this.existsField.GetValueOrDefault(); }
            set { this.existsField = value; }
        }

        /// <summary>
        /// Sets the Exists property
        /// </summary>
        /// <param name="exists">Check for the existence of the attribute used for the conditional check.
        /// If this field is unspecified or true, UpdateCondition.Value must be set to a value.
        /// If this field is false, UpdateCondition.Value should not have a value assigned to it.
        /// If no value is associated with this field, SimpleDB uses a default value of 'true'</param>
        /// <returns>this instance</returns>
        public UpdateCondition WithExists(bool exists)
        {
            this.existsField = exists;
            return this;
        }

        /// <summary>
        /// Checks if Exists property is set
        /// </summary>
        /// <returns>true if Exists property is set</returns>
        public bool IsSetExists()
        {
            return this.existsField.HasValue;
        }

    }
}
