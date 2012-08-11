namespace RDPManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPanelShow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerControl1 = new RDPManager.HeaderControl();
            this.RDPClient = new RDPManager.MsRdpClient4();
            this.connectionEditControl1 = new RDPManager.ConnectionEditControl();
            this.clientEditControl1 = new RDPManager.ClientEditControl();
            this.customConnectionControl1 = new RDPManager.CustomConnectionControl();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDPClient)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.headerControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnPanelShow);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.RDPClient);
            this.splitContainer1.Panel2.Controls.Add(this.connectionEditControl1);
            this.splitContainer1.Panel2.Controls.Add(this.clientEditControl1);
            this.splitContainer1.Panel2.Controls.Add(this.customConnectionControl1);
            this.splitContainer1.Size = new System.Drawing.Size(784, 562);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 99;
            this.splitContainer1.TabStop = false;
            // 
            // btnPanelShow
            // 
            this.btnPanelShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPanelShow.BackColor = System.Drawing.Color.Transparent;
            this.btnPanelShow.BackgroundImage = global::RDPManager.Properties.Resources.collapse;
            this.btnPanelShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPanelShow.Location = new System.Drawing.Point(367, 0);
            this.btnPanelShow.Margin = new System.Windows.Forms.Padding(0);
            this.btnPanelShow.Name = "btnPanelShow";
            this.btnPanelShow.Size = new System.Drawing.Size(50, 25);
            this.btnPanelShow.TabIndex = 1;
            this.btnPanelShow.TabStop = false;
            this.btnPanelShow.UseVisualStyleBackColor = false;
            this.btnPanelShow.Click += new System.EventHandler(this.btnPanelShow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RDPManager.Properties.Resources.rdpsplash;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // headerControl1
            // 
            this.headerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerControl1.Location = new System.Drawing.Point(0, 0);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.ParentWindow = null;
            this.headerControl1.Size = new System.Drawing.Size(784, 58);
            this.headerControl1.TabIndex = 0;
            this.headerControl1.TabStop = false;
            // 
            // RDPClient
            // 
            this.RDPClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RDPClient.Enabled = true;
            this.RDPClient.Location = new System.Drawing.Point(0, 0);
            this.RDPClient.Name = "RDPClient";
            this.RDPClient.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("RDPClient.OcxState")));
            this.RDPClient.Size = new System.Drawing.Size(784, 502);
            this.RDPClient.TabIndex = 0;
            this.RDPClient.OnConnecting += new System.EventHandler(this.RDPClient_OnConnecting);
            this.RDPClient.OnConnected += new System.EventHandler(this.RDPClient_OnConnected);
            this.RDPClient.OnDisconnected += new AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler(this.RDPClient_OnDisconnected);
            // 
            // connectionEditControl1
            // 
            this.connectionEditControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectionEditControl1.currentClient = null;
            this.connectionEditControl1.currentConnection = null;
            this.connectionEditControl1.Location = new System.Drawing.Point(0, 0);
            this.connectionEditControl1.Name = "connectionEditControl1";
            this.connectionEditControl1.parentWindow = null;
            this.connectionEditControl1.Size = new System.Drawing.Size(322, 175);
            this.connectionEditControl1.TabIndex = 4;
            this.connectionEditControl1.TabStop = false;
            this.connectionEditControl1.Visible = false;
            // 
            // clientEditControl1
            // 
            this.clientEditControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientEditControl1.currentClient = null;
            this.clientEditControl1.Location = new System.Drawing.Point(0, 0);
            this.clientEditControl1.Name = "clientEditControl1";
            this.clientEditControl1.parentWindow = null;
            this.clientEditControl1.Size = new System.Drawing.Size(317, 185);
            this.clientEditControl1.TabIndex = 3;
            this.clientEditControl1.TabStop = false;
            this.clientEditControl1.Visible = false;
            // 
            // customConnectionControl1
            // 
            this.customConnectionControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customConnectionControl1.Location = new System.Drawing.Point(0, 0);
            this.customConnectionControl1.Name = "customConnectionControl1";
            this.customConnectionControl1.parentWindow = null;
            this.customConnectionControl1.Size = new System.Drawing.Size(343, 109);
            this.customConnectionControl1.TabIndex = 5;
            this.customConnectionControl1.TabStop = false;
            this.customConnectionControl1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RDP Connection Manager";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDPClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public HeaderControl headerControl1;
        private System.Windows.Forms.Button btnPanelShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MsRdpClient4 RDPClient;
        public ConnectionEditControl connectionEditControl1;
        public ClientEditControl clientEditControl1;
        public CustomConnectionControl customConnectionControl1;

    }
}

