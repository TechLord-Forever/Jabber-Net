/* --------------------------------------------------------------------------
 *
 * License
 *
 * The contents of this file are subject to the Jabber Open Source License
 * Version 1.0 (the "License").  You may not copy or use this file, in either
 * source code or executable form, except in compliance with the License.  You
 * may obtain a copy of the License at http://www.jabber.com/license/ or at
 * http://www.opensource.org/.  
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied.  See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * Copyrights
 * 
 * Portions created by or assigned to Cursive Systems, Inc. are 
 * Copyright (c) 2002 Cursive Systems, Inc.  All Rights Reserved.  Contact
 * information for Cursive Systems, Inc. is available at http://www.cursive.net/.
 *
 * Portions Copyright (c) 2002 Joe Hildebrand.
 * 
 * Acknowledgements
 * 
 * Special thanks to the Jabber Open Source Contributors for their
 * suggestions and support of Jabber.
 * 
 * --------------------------------------------------------------------------*/
using System;
using System.Xml;

using bedrock.util;

namespace jabber.protocol.accept
{
    /// <summary>
    /// The type attribute
    /// </summary>
    public enum XdbType
    {
        /// <summary>
        /// None specified
        /// </summary>
        NONE = -1,
        /// <summary>
        /// type='get'
        /// </summary>
        get,
        /// <summary>
        /// type='set'
        /// </summary>
        set,
        /// <summary>
        /// type='result'
        /// </summary>
        result,
        /// <summary>
        /// type='error'
        /// </summary>
        error
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public enum XdbAction
    {
        /// <summary>
        /// None specified
        /// </summary>
        NONE = -1,
        /// <summary>
        /// action='check'
        /// </summary>
        check,
        /// <summary>
        /// action='insert'
        /// </summary>
        insert
    }

    /// <summary>
    /// The XDB packet.
    /// </summary>
    [RCS(@"$Header$")]
    public class Xdb : jabber.protocol.Packet
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doc"></param>
        public Xdb(XmlDocument doc) : base("xdb", doc)
        {
			ID = NextID();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="qname"></param>
        /// <param name="doc"></param>
        public Xdb(string prefix, XmlQualifiedName qname, XmlDocument doc) : 
            base(qname.Name, doc)
        {
        }

        /// <summary>
        /// The contents of the XDB packet
        /// </summary>
        public XmlElement Contents
        {
            get { return (XmlElement) this.FirstChild; }
            set 
            {
                this.InnerXml = "";
                AddChild(value);
            }
        }

        /// <summary>
        /// The type attribute
        /// </summary>
        public XdbType Type
        {
            get { return (XdbType) GetEnumAttr("type", typeof(XdbType)); }
            set 
            { 
                XdbType cur = this.Type;
                if (cur == value)
                    return;
                if (value == XdbType.NONE)
                {
                    RemoveAttribute("type");
                }
                else
                {
                    SetAttribute("type", value.ToString());
                }
            }
        }

        /// <summary>
        /// The action attribute
        /// </summary>
        public XdbAction Action
        {
            get { return (XdbAction) GetEnumAttr("action", typeof(XdbAction)); }
            set 
            { 
                XdbAction cur = this.Action;
                if (cur == value)
                    return;
                if (value == XdbAction.NONE)
                {
                    RemoveAttribute("action");
                }
                else
                {
                    SetAttribute("action", value.ToString());
                }
            }
        }

        /// <summary>
        /// The namespace to store/retrive from.
        /// </summary>
        public string NS
        {
            get { return GetAttribute("ns"); }
            set { SetAttribute("ns", value); }
        }
    }
}