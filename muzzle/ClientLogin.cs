﻿/* --------------------------------------------------------------------------
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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace muzzle
{
	/// <summary>
	/// A login form for client connections.
	/// </summary>
	/// <example>
    /// ClientLogin l = new ClientLogin();
    ///        
    /// l.User = jc.User;
    /// l.Port = jc.Port;
    /// l.Server = jc.Server;
    /// l.Password = jc.Password;
    /// 
    /// if (l.ShowDialog(this) == DialogResult.OK) 
    /// {
    ///     jc.User = l.User;
    ///     jc.Port = l.Port;
    ///     jc.Server = l.Server;
    ///     jc.Password = l.Password;
    ///     jc.Connect();
    /// }
	/// </example>
    public class ClientLogin : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPass;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        /// <summary>
        /// Create a Client Login dialog box
        /// </summary>
		public ClientLogin()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        /// <summary>
        /// The user name for the connection
        /// </summary>
        public string User
        {
            get { return txtUser.Text; }
            set { txtUser.Text = value; }
        }

        /// <summary>
        /// The server name for the connection
        /// </summary>
        public string Server
        {
            get { return txtServer.Text; }
            set { txtServer.Text = value; }
        }

        /// <summary>
        /// The password for the connection
        /// </summary>
        public string Password
        {
            get { return txtPass.Text; }
            set { txtPass.Text = value; }
        }

        /// <summary>
        /// The port number for the connection
        /// </summary>
        public int Port
        {
            get { return int.Parse(txtPort.Text); }
            set { txtPort.Text = value.ToString(); }
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(103, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(67, 8);
            this.txtUser.Name = "txtUser";
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(67, 70);
            this.txtServer.Name = "txtServer";
            this.txtServer.TabIndex = 6;
            this.txtServer.Text = "";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(67, 101);
            this.txtPort.Name = "txtPort";
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "5222";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(67, 39);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.TabIndex = 9;
            this.txtPass.Text = "";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // ClientLogin
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(176, 171);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.txtPass,
                                                                          this.label4,
                                                                          this.txtPort,
                                                                          this.txtServer,
                                                                          this.txtUser,
                                                                          this.button2,
                                                                          this.button1,
                                                                          this.label3,
                                                                          this.label2,
                                                                          this.label1});
            this.Name = "ClientLogin";
            this.Text = "Login";
            this.ResumeLayout(false);

        }
		#endregion

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
	}
}