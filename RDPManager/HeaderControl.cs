using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace RDPManager
{
    public partial class HeaderControl : UserControl
    {

        private List<Client> clientList;

        public HeaderControl()
        {
            InitializeComponent();
        }

        private void HeaderControl_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)//Dont try to deserialize at design-time
            {
                try
                {
                     deserializeData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Couldn't Open XML file. Attemping to create one.");
                    serializeData();
                }   
            }
        }

        private void serializeData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));

            XmlWriterSettings ws = new XmlWriterSettings();
            ws.NewLineHandling = NewLineHandling.Entitize;

            using (XmlWriter wr = XmlWriter.Create(@"data.xml", ws))
            {
                serializer.Serialize(wr, this.clientList);
                wr.Close();
            }

            deserializeData(); //Update again after serializing to show changes.
        }

        public void deserializeData()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Client>));
            TextReader textReader = new StreamReader(@"data.xml");
            List<Client> connectionList = (List<Client>)deserializer.Deserialize(textReader);
            textReader.Close();
            this.clientList = connectionList;
            this.comboBox1.DataSource = clientList;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.ValueMember = "name";
        }

        public void addClient(Client c)
        {
            deserializeData();
            if (!clientExists(c))
                clientList.Add(c);
            serializeData();
        }

        public void editClient(Client oldClient, Client newClient)
        {
            newClient.connections = oldClient.connections;
            deleteClient(oldClient);
            addClient(newClient);
        }

        public void deleteClient(Client c)
        {
            deserializeData();
            if (clientExists(c))
                clientList.Remove(getClient(c));
            else
                MessageBox.Show("Client Could not be deleted, not found");
            serializeData();
        }

        private Client getClient(Client c)
        {
            foreach (Client client in this.clientList) // Loop through List with foreach
            {
                if (client.name == c.name)
                {
                    return client;
                }
            }
            return null;
        }

        public bool clientExists(Client c){
            return clientExists(c.name);
        }
        public bool clientExists(string name)
        {

                        foreach (Client client in this.clientList) // Loop through List with foreach
            {
                if (client.name == name)
                {
                    return true;
                }
            }
                        return false;
        }

        public void addConnection(Client cl, Connection c)
        {
            deserializeData();
            if (clientExists(cl))
            {
                getClient(cl).connections.Add(c);
                serializeData();
            }
            else
            {
                MessageBox.Show("Could not find parent client for connection");
            }

        }

        internal void deleteConnection(Client currentClient, Connection currentConnection)
        {
            deserializeData();
            if (clientExists(currentClient))
            {
                Client cl = getClient(currentClient);
                if (cl.connectionExists(currentConnection))
                {
                    cl.removeConnection(currentConnection);
                    serializeData();
                }
                else
                {
                    MessageBox.Show("Could not find connection for client");
                }
            }
            else
                MessageBox.Show("Could not find parent client for connection.");
        }

        internal void editConnection(Client currentClient, Connection connection, Connection connection_2)
        {
            deleteConnection(currentClient, connection);
            addConnection(currentClient, connection_2);
        }

        private Form1 parentWindow;
        public Form1 ParentWindow
        {
            get { return parentWindow; }
            set { parentWindow = value; }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (parentWindow != null && (comboBox1.SelectedItem is Client) && (comboBox2.SelectedItem is Connection))
            {
                parentWindow.connect((Client)comboBox1.SelectedItem, (Connection)comboBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a valid Client and Connection from the dropdown boxes.");
            }


        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (parentWindow != null)
            {
                parentWindow.toggleFullScreen();
            }
        }

        private void btnHidePanel_Click(object sender, EventArgs e)
        {
            if (parentWindow != null)
            {
                parentWindow.toggleHeader();
            }
        }

        internal void setConnectText(string p)
        {
            btnConnect.Text = p;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client c = (Client)comboBox1.SelectedItem;
            comboBox2.DataSource = c.connections;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.ValueMember = "name";
            if (c.connections.Count == 0)
            {
                this.comboBox2.Text = "";
            }
        }

        private void setClientEditVisibility(bool visible)
        {
            if (visible)
            {
                parentWindow.clientEditControl1.BringToFront();
                setConnectionEditVisibility(false);
                setCustomConnectionVisibility(false);
            }
            else
                parentWindow.clientEditControl1.SendToBack();
            parentWindow.clientEditControl1.Visible = visible;
        }

        private void setConnectionEditVisibility(bool visible)
        {
            if (visible)
            {
                parentWindow.connectionEditControl1.BringToFront();
                setClientEditVisibility(false);
                setCustomConnectionVisibility(false);
            }
            else
                parentWindow.connectionEditControl1.SendToBack();

            parentWindow.connectionEditControl1.Visible = visible;
        }

        private void setCustomConnectionVisibility(bool visible)
        {
            if (visible)
            {
                parentWindow.customConnectionControl1.BringToFront();
                setConnectionEditVisibility(false);
                setClientEditVisibility(false);
            }
            else
                parentWindow.customConnectionControl1.SendToBack();
            parentWindow.customConnectionControl1.Visible = visible;
        }



        private void btnNewClient_Click(object sender, EventArgs e)
        {
            if (parentWindow != null)
            {
                parentWindow.clientEditControl1.populateScreenNew();
                setClientEditVisibility(true);
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (parentWindow != null && (comboBox1.SelectedItem is Client))
            {
                parentWindow.clientEditControl1.populateScreenEdit((Client)comboBox1.SelectedItem);
                setClientEditVisibility(true);
            }
        }

        private void btnNewConnection_Click(object sender, EventArgs e)
        {
            if (parentWindow != null && (comboBox1.SelectedItem is Client))
            {
                parentWindow.connectionEditControl1.populateScreenNew((Client)comboBox1.SelectedItem);
                setConnectionEditVisibility(true);

            }
        }

        private void btnEditConnection_Click(object sender, EventArgs e)
        {
            if (parentWindow != null && (comboBox1.SelectedItem is Client) && (comboBox2.SelectedItem is Connection))
            {
                parentWindow.connectionEditControl1.populateScreenEdit((Client)comboBox1.SelectedItem, (Connection)comboBox2.SelectedItem);
                setConnectionEditVisibility(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (parentWindow != null)
            {
                parentWindow.customConnectionControl1.populateScreen();
                setCustomConnectionVisibility(true);
            }
        }


       
    }
}
