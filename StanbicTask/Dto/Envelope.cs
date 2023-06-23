using System.Xml.Serialization;

namespace StanbicTask.Dto
{
    [XmlRoot(ElementName = "Envelop")]
    public class Envelope
    {
        [XmlElement(ElementName = "Body")]
        public Body Body { get; set; }
    }

    public class Body
    {
        [XmlElement(ElementName = "name enquirysingleitem")]
        public NameEnquirySingleItem NameEnquirySingleItem { get; set; }
    }
    public class NameEnquirySingleItem
    {
        [XmlElement(ElementName = "request")]
        public Request Request { get; set; }
    }


    public class Request
    {
        [XmlElement(ElementName = "NESingleRequest")]
        public NESingleRequest NESingleRequest { get; set; }
    }
    public class NESingleRequest
    {
        [XmlElement(ElementName = "SessionId")]
        public string SessionId { get; set; }

        [XmlElement(ElementName = "DestinationInstitutionCode")]
        public string DestinationInstitutionCode { get; set; }

        [XmlElement(ElementName = "ChannelCode")]
        public string ChannelCode { get; set; }

        [XmlElement(ElementName = "AccountNumber")]
        public string AccountNumber { get; set; }
    }
}
