using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RDPManager
{
    public partial class CustomConnectionControl : UserControl
    {
        public CustomConnectionControl()
        {
            InitializeComponent();
        }

        internal void populateScreen()
        {
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connection c = new Connection();
            c.Address = txtAddress.Text;
            c.Port = txtPort.Text;
            c.Username = txtUsername.Text;
            c.Password = txtPassword.Text;


            if (parentWindow != null)
                parentWindow.connect(null, c);

            
            closeWindow();

        }

        private void closeWindow()
        {
            this.Visible = false;
            this.SendToBack();
        }

        public Form1 parentWindow { get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeWindow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtPort.Text = "3389";
            txtUsername.Text = "";
        }
    }
}
