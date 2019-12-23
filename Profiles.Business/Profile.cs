using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace Profiles.Business
{
    [Serializable()]
    [XmlRoot("Profile")]
    public class Profile
    {
        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlElement("FirstName")]
        public string FirstName { get; set; }

        [XmlElement("LastName")]
        public string LastName { get; set; }

        [XmlElement("SPIERole")]
        public string SPIERole { get; set; }

        [XmlElement("Company")]
        public string Company { get; set; }

        [XmlElement("JobTitle")]
        public string JobTitle { get; set; }

        [XmlElement("Photo")]
        public string PictureFileName { get; set; }
    }
}
