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
using NUnit.Framework;
using bedrock.collections;
using bedrock.util;
namespace test.bedrock.collections
{
    /// <summary>
    ///    Summary description for TemplateTest.
    /// </summary>
    [RCS(@"$Header$")]
    public class TrieNodeTest : TestCase
    {
        public TrieNodeTest(string name) : base(name) {}
        public static ITest Suite
        {
            get { return new TestSuite(typeof(TrieNodeTest)); }
        }
        public void Test_Main() 
        {
            System.Text.Encoding ENC = System.Text.Encoding.Default;
            TrieNode n = new TrieNode(null, 0);
            byte[] key = ENC.GetBytes("test");
            TrieNode current = n;
            for (int i=0; i<key.Length; i++)
            {
                byte b = key[i];
                current = current[b, true];
            }
            current.Value = "foo";
            AssertEquals(ENC.GetString(key), ENC.GetString(current.Key));
        }
    }
}