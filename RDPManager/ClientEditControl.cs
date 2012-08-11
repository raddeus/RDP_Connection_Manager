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
    public partial class ClientEditControl : UserControl
    {
        private bool isNew = true;
        public Form1 parentWindow { get; set; }
        public Client currentClient { get; set; }

        public ClientEditControl()
        {
            InitializeComponent();
        }

        public void populateScreenNew()
        {
            this.isNew = true;
            lblEditNew.Text = "New Client: ";
            lblClientName.Text = "";
            txtName.Text = "";
            textBox1.Text = "";
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
        }

        public void populateScreenEdit(Client c)
        {
            this.isNew = false;
            this.currentClient = c;
            lblEditNew.Text = "Edit Client: ";
            lblClientName.Text = c.name;
            txtName.Text = c.name;
            textBox1.Text = c.notes;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.isNew)
            {
                if (txtName.Text.Length > 3)
                {
                    if (parentWindow != null)
                    {
                        parentWindow.headerControl1.addClient(this.getNewClient());
                        this.closeWindow();
                    }
                }
                else
                {
                    MessageBox.Show("Name must be at least 3 characters long.");
                }
            }
            else if(currentClient!=null)
            {
                parentWindow.headerControl1.editClient(currentClient, this.getNewClient());
            }
            closeWindow();
        }



        private Client getNewClient()
        {
            Client c = new Client();
            c.name = txtName.Text;
            c.notes = textBox1.Text;
            return c;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Would you like to permanently delete this Client?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (currentClient != null && parentWindow != null)
                {
                    parentWindow.headerControl1.deleteClient(currentClient);
                }
                else
                {
                    if (this.isNew)
                    {
                        MessageBox.Show("Cannot delete a client that hasn't been created.");
                    }
                    else
                    {
                        MessageBox.Show("Could not find client to delete.");
                    }
                }

                closeWindow();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblEditNew_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.closeWindow();
        }
        private void closeWindow()
        {
                       this.Visible = false;
                       this.SendToBack();
        }
    }
}
