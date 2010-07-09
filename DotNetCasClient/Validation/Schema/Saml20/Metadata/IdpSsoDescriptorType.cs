﻿/*
 * Licensed to Jasig under one or more contributor license
 * agreements. See the NOTICE file distributed with this work
 * for additional information regarding copyright ownership.
 * Jasig licenses this file to you under the Apache License,
 * Version 2.0 (the "License"); you may not use this file
 * except in compliance with the License. You may obtain a
 * copy of the License at:
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using DotNetCasClient.Validation.Schema.Saml20.Assertion.Attribute;

namespace DotNetCasClient.Validation.Schema.Saml20.Metadata
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:tc:SAML:2.0:metadata")]
    [XmlRoot("IDPSSODescriptor", Namespace="urn:oasis:names:tc:SAML:2.0:metadata", IsNullable=false)]
    public class IdpSsoDescriptorType : SsoDescriptorType {
        [XmlElement("SingleSignOnService")]
        public EndpointType[] SingleSignOnService
        {
            get;
            set;
        }

        [XmlElement("NameIDMappingService")]
        public EndpointType[] NameIdMappingService
        {
            get;
            set;
        }

        [XmlElement("AssertionIDRequestService")]
        public EndpointType[] AssertionIdRequestService
        {
            get;
            set;
        }

        [XmlElement("AttributeProfile", DataType="anyURI")]
        public string[] AttributeProfile
        {
            get;
            set;
        }

        [XmlElement("Attribute", Namespace="urn:oasis:names:tc:SAML:2.0:assertion")]
        public AttributeType[] Attribute
        {
            get;
            set;
        }

        [XmlAttribute]
        public bool WantAuthnRequestsSigned
        {
            get;
            set;
        }

        [XmlIgnore]
        public bool WantAuthnRequestsSignedSpecified
        {
            get;
            set;
        }
    }
}