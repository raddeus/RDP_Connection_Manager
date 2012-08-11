using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace RDPManager
{
    [XmlRoot("Client")]
    public class Client
    {


        public Client()
        {
            name = String.Empty;

        }
        [XmlArrayItemAttribute("Connection")]
        public List<Connection> connections { get; set; }

        [XmlElement("Name")]
        public string name { get; set; }


        public bool connectionExists(Connection c)
        {
            return connectionExists(c.name);
        }
        public bool connectionExists(string name)
        {

            foreach (Connection conn in this.connections) // Loop through List with foreach
            {
                if (conn.name == name)
                {
                    return true;
                }
            }
            return false;
        }
        private Connection getConnection(Connection c)
        {
            foreach (Connection conn in this.connections) // Loop through List with foreach
            {
                if (conn.name == c.name)
                {
                    return conn;
                }
            }
            return null;
        }

        internal void removeConnection(Connection currentConnection)
        {
            connections.Remove(getConnection(currentConnection));
        }


        [XmlElement("Notes")]
        public string notes
        {
  get; set; 
        }


    }
}
