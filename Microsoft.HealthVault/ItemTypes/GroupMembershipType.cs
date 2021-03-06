// Copyright (c) Microsoft Corporation.  All rights reserved.
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Xml;
using System.Xml.XPath;
using Microsoft.HealthVault.Exceptions;
using Microsoft.HealthVault.Helpers;

namespace Microsoft.HealthVault.ItemTypes
{
    /// <summary>
    /// Represents a group membership.
    /// </summary>
    ///
    public class GroupMembershipType : ItemBase
    {
        /// <summary>
        /// Constructs a new instance of the <see cref="GroupMembershipType"/> class with
        /// default values.
        /// </summary>
        ///
        public GroupMembershipType()
        {
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="GroupMembershipType"/> class with the specified
        /// name.
        /// </summary>
        ///
        /// <param name="name">
        /// The group name.
        /// </param>
        ///
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="name"/> is <b>null</b>.
        /// </exception>
        ///
        /// <exception cref="ArgumentException">
        /// If <paramref name="name"/> is empty.
        /// </exception>
        ///
        public GroupMembershipType(CodableValue name)
        {
            Name = name;
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="GroupMembershipType"/> class with the specified
        /// name and value.
        /// </summary>
        ///
        /// <param name="name">
        /// The name of the group type.
        /// </param>
        ///
        /// <param name="value">
        /// The value the member has for the group type.
        /// </param>
        ///
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="name"/> is <b>null</b>.
        /// </exception>
        ///
        /// <exception cref="ArgumentException">
        /// If <paramref name="name"/> is empty.
        /// </exception>
        ///
        /// <exception cref="ArgumentException">
        /// If <paramref name="value"/> is <b>null</b>.
        /// </exception>
        ///
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="value"/> is empty.
        /// </exception>
        ///
        public GroupMembershipType(CodableValue name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Populates the data for the group membership type from the XML.
        /// </summary>
        ///
        /// <param name="navigator">
        /// The XML node representing the group membership type.
        /// </param>
        ///
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="navigator"/> parameter is <b>null</b>.
        /// </exception>
        ///
        public override void ParseXml(XPathNavigator navigator)
        {
            Validator.ThrowIfNavigatorNull(navigator);

            CodableValue name = new CodableValue();
            name.ParseXml(navigator.SelectSingleNode("name"));
            _name = name;
            _value = navigator.SelectSingleNode("value").Value;
        }

        /// <summary>
        /// Writes the group membership type data to the specified XML writer.
        /// </summary>
        ///
        /// <param name="nodeName">
        /// The name of the outer element for the group membership type.
        /// </param>
        ///
        /// <param name="writer">
        /// The XmlWriter to write the group membership type to.
        /// </param>
        ///
        /// <exception cref="ArgumentException">
        /// The <paramref name="nodeName"/> parameter is <b>null</b> or empty.
        /// </exception>
        ///
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="writer"/> parameter is <b>null</b>.
        /// </exception>
        ///
        /// <exception cref="ThingSerializationException">
        /// If <see cref="Name"/>  or <see cref="Value"/> is <b>null</b> or empty.
        /// </exception>
        ///
        public override void WriteXml(string nodeName, XmlWriter writer)
        {
            Validator.ThrowIfStringNullOrEmpty(nodeName, "nodeName");
            Validator.ThrowIfWriterNull(writer);
            Validator.ThrowSerializationIfNull(_name, Resources.GroupMembershipTypeNameNotSet);

            if (string.IsNullOrEmpty(_value))
            {
                throw new ThingSerializationException(Resources.GroupMembershipTypeNameNotSet);
            }

            writer.WriteStartElement(nodeName);

            _name.WriteXml("name", writer);
            writer.WriteElementString("value", _value);

            writer.WriteEndElement();
        }

        /// <summary>
        /// Gets or sets the group membership name.
        /// </summary>
        ///
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="value"/> is <b>null</b>.
        /// </exception>
        ///
        /// <exception cref="ArgumentException">
        /// If <paramref name="value"/> is empty.
        /// </exception>
        ///
        public CodableValue Name
        {
            get { return _name; }

            set
            {
                Validator.ThrowIfArgumentNull(value, nameof(Name), Resources.GroupMembershipTypeNameMandatory);
                Validator.ThrowIfStringNullOrEmpty(value.Text, "Name");
                _name = value;
            }
        }

        private CodableValue _name;

        /// <summary>
        /// Gets or sets the group membership value.
        /// </summary>
        ///
        /// <exception cref="ArgumentException">
        /// If <paramref name="value"/> is <b>null</b>.
        /// </exception>
        ///
        /// <exception cref="ArgumentException">
        /// If <paramref name="value"/> is <b>null</b>, empty, or contains only whitespace.
        /// </exception>
        ///
        public string Value
        {
            get { return _value; }

            set
            {
                Validator.ThrowIfArgumentNull(value, nameof(Value), Resources.GroupMembershipTypeValueMandatory);
                Validator.ThrowIfStringIsWhitespace(value, "Value");
                _value = value;
            }
        }

        private string _value;

        /// <summary>
        /// Gets a string representation of the group membership type.
        /// </summary>
        ///
        /// <returns>
        /// A string representing the group membership type.
        /// </returns>
        ///
        public override string ToString()
        {
            return
                string.Format(
                    Resources.NameEqualsValue,
                    Name.ToString(),
                    Value);
        }
    }
}
