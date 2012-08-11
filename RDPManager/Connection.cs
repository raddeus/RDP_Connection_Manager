using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RDPManager
{

    [XmlRoot("Connection")]
    public class Connection
    {

        public Connection()
        {
            name = String.Empty;
            Address = String.Empty;
            Port = String.Empty;
            Username = String.Empty;
            Password = String.Empty;
        }
        [XmlElement("Name")]
        public string name { get; set; }
        [XmlElement("Address")]
        public string Address { get; set; }
        [XmlElement("Port")]
        public string Port { get; set; }
        [XmlElement("Username")]
        public string Username { get; set; }
        [XmlElement("Password")]
        public string Password { get; set; }
    }

}
