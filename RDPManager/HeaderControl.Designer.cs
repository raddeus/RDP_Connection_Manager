namespace RDPManager
{
    partial class HeaderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnEditConnection = new System.Windows.Forms.Button();
            this.btnNewConnection = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBox1, "Client");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(65, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(190, 21);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBox2, "Connection");
            // 
            // btnEditConnection
            // 
            this.btnEditConnection.BackgroundImage = global::RDPManager.Properties.Resources.editIconSmall;
            this.btnEditConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditConnection.Location = new System.Drawing.Point(31, 28);
            this.btnEditConnection.Name = "btnEditConnection";
            this.btnEditConnection.Size = new System.Drawing.Size(28, 28);
            this.btnEditConnection.TabIndex = 17;
            this.btnEditConnection.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEditConnection, "Edit Connection");
            this.btnEditConnection.UseVisualStyleBackColor = true;
            this.btnEditConnection.Click += new System.EventHandler(this.btnEditConnection_Click);
            // 
            // btnNewConnection
            // 
            this.btnNewConnection.BackgroundImage = global::RDPManager.Properties.Resources.addIconSmall;
            this.btnNewConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewConnection.Location = new System.Drawing.Point(0, 28);
            this.btnNewConnection.Name = "btnNewConnection";
            this.btnNewConnection.Size = new System.Drawing.Size(28, 28);
            this.btnNewConnection.TabIndex = 16;
            this.btnNewConnection.TabStop = false;
            this.toolTip1.SetToolTip(this.btnNewConnection, "New Connection");
            this.btnNewConnection.UseVisualStyleBackColor = true;
            this.btnNewConnection.Click += new System.EventHandler(this.btnNewConnection_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackgroundImage = global::RDPManager.Properties.Resources.editIconSmall;
            this.btnEditClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditClient.Location = new System.Drawing.Point(31, 0);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(28, 28);
            this.btnEditClient.TabIndex = 15;
            this.btnEditClient.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEditClient, "Edit Client");
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnNewClient
            // 
            this.btnNewClient.BackgroundImage = global::RDPManager.Properties.Resources.addIconSmall;
            this.btnNewClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewClient.Location = new System.Drawing.Point(0, 0);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(28, 28);
            this.btnNewClient.TabIndex = 14;
            this.btnNewClient.TabStop = false;
            this.btnNewClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnNewClient, "New Client");
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::RDPManager.Properties.Resources.customIcon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(373, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button1, "Direct Connection");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.BackgroundImage = global::RDPManager.Properties.Resources.fullscreen;
            this.btnFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFullScreen.Location = new System.Drawing.Point(317, 3);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(50, 50);
            this.btnFullScreen.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnFullScreen, "Fullscreen");
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImage = global::RDPManager.Properties.Resources.playIcon;
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConnect.Location = new System.Drawing.Point(261, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(50, 50);
            this.btnConnect.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnConnect, "Connect");
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // HeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditConnection);
            this.Controls.Add(this.btnNewConnection);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnFullScreen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnConnect);
            this.Name = "HeaderControl";
            this.Size = new System.Drawing.Size(919, 56);
            this.Load += new System.EventHandler(this.HeaderControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnEditConnection;
        private System.Windows.Forms.Button btnNewConnection;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
