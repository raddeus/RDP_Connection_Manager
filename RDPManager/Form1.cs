using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSTSCLib;
using System.Xml.Serialization;
using System.IO;

namespace RDPManager
{

    public partial class Form1 : Form
    {
        public bool connected { get; set; }
        public bool panelCollapsed { get; set; }
        public Form1()
        {
            panelCollapsed = false;
            InitializeComponent();
            headerControl1.ParentWindow = this;
            clientEditControl1.parentWindow = this;
            connectionEditControl1.parentWindow = this;
            customConnectionControl1.parentWindow = this;
        }

        internal void connect(Client client, Connection connection)
        {
            if (connected)
            {
                RDPClient.Disconnect();
            }
            else
            {
                RDPClient.Server = connection.Address;
                RDPClient.UserName = connection.Username;
                try
                {
                    RDPClient.AdvancedSettings2.RDPPort = Convert.ToInt32(connection.Port);
                }
                catch (Exception)
                {

                    MessageBox.Show("Could not parse integer from port field of connection, make sure your port is a valid port integer");
                }
                RDPClient.AdvancedSettings2.SmartSizing = true;
                RDPClient.DesktopHeight = Screen.FromControl(this).Bounds.Height;
                RDPClient.DesktopWidth = Screen.FromControl(this).Bounds.Width;
                if (client!= null)
                RDPClient.FullScreenTitle = "Client: "+client.name+" Connection: "+connection.name;
                else
                    RDPClient.FullScreenTitle = "RDP Direct Connection";
                IMsTscNonScriptable secured = (IMsTscNonScriptable)RDPClient.GetOcx();
                secured.ClearTextPassword = connection.Password;
                try
                {
                    RDPClient.Connect();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error: Invalid Connection - Check Connection settings for: Client: "+client.name+" Connection: "+connection.name+".");
                }
            }
        }

        internal void toggleFullScreen()
        {
            RDPClient.FullScreen = !RDPClient.FullScreen;
        }

        internal void toggleHeader()
        {
            panelCollapsed = !panelCollapsed;
            splitContainer1.Panel1Collapsed = panelCollapsed;
            //btnPanelShow.Visible = !b;
            if (panelCollapsed)
            {
                btnPanelShow.BackgroundImage = global::RDPManager.Properties.Resources.expand;
                //btnPanelShow.SendToBack();
            }
            else
            {
                btnPanelShow.BackgroundImage = global::RDPManager.Properties.Resources.collapse;
                //btnPanelShow.BringToFront();
            }
        }

        private void testRDPSTUFF()
        {
            RDPClient.AdvancedSettings2.DisplayConnectionBar = true;
        }

        private void btnPanelShow_Click(object sender, EventArgs e)
        {
            toggleHeader();
        }

        private void RDPClient_OnConnecting(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox1.SendToBack();
            //headerControl1.setConnectText("Connecting...");
            headerControl1.btnConnect.BackgroundImage = global::RDPManager.Properties.Resources.connectingIcon;
            connected = true;
            headerControl1.btnConnect.UseWaitCursor = true;
            //headerControl1.btnConnect. = false;
        }

        private void RDPClient_OnConnected(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox1.SendToBack();
            //headerControl1.setConnectText("Disconnect");
            headerControl1.btnConnect.BackgroundImage = global::RDPManager.Properties.Resources.stopIcon;
            connected = true;
            headerControl1.btnConnect.UseWaitCursor = false;
            //headerControl1.btnConnect.Enabled = true;
        }

        private void RDPClient_OnDisconnected(object sender, AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent e)
        {
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            headerControl1.btnConnect.BackgroundImage = global::RDPManager.Properties.Resources.playIcon;
            btnPanelShow.BringToFront();
            //headerControl1.setConnectText("Connect");
            connected = false;
            headerControl1.btnConnect.UseWaitCursor = false;
            //headerControl1.btnConnect.Enabled = true;
        }
    }
}
