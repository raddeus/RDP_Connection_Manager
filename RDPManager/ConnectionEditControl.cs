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
    public partial class ConnectionEditControl : UserControl
    {

        private bool isNew = true;
        public Form1 parentWindow { get; set; }
        public Client currentClient { get; set; }
        public Connection currentConnection { get; set; }

        public ConnectionEditControl()
        {
            InitializeComponent();
        }


        public void populateScreenNew(Client cl)
        {
            this.isNew = true;
            this.currentClient = cl;
            lblEditNew.Text = "New Connection: ";
            lblConnectionName.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
        }

        public void populateScreenEdit(Client cl, Connection c)
        {
            this.isNew = false;
            this.currentClient = cl;
            this.currentConnection = c;
            lblEditNew.Text = "Edit Connection: ";
            lblConnectionName.Text = c.name;
            txtName.Text = c.name;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.isNew)
            {
                if (txtName.Text.Length >= 3)
                {
                    if (parentWindow != null)
                    {
                        parentWindow.headerControl1.addConnection(this.currentClient, this.getNewConnection());
                        this.closeWindow();
                    }
                }
                else
                {
                    MessageBox.Show("Name must be at least 3 characters long.");
                }
            }
            else if (currentConnection != null)
            {
                parentWindow.headerControl1.editConnection(currentClient, this.currentConnection, this.getNewConnection());
            }
            closeWindow();
        }

        private Connection getNewConnection()
        {
            Connection c = new Connection();
            c.name = txtName.Text;
            c.Port = txtPort.Text;
            c.Username = txtUsername.Text;
            c.Password = txtPassword.Text;
            c.Address = txtAddress.Text;
            return c;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to permanently delete this Connection?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (currentClient != null && parentWindow != null)
                {
                    parentWindow.headerControl1.deleteConnection(currentClient, currentConnection);
                }
                else
                {
                    if (this.isNew)
                    {
                        MessageBox.Show("Cannot delete a connection that hasn't been created.");
                    }
                    else
                    {
                        MessageBox.Show("Could not find connection to delete.");
                    }
                }
                closeWindow();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeWindow();
        }

        private void closeWindow()
        {
            this.Visible = false;
            this.SendToBack();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
