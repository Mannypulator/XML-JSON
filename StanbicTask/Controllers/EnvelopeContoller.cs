using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StanbicTask.Dto;
using System.Xml.Linq;

namespace StanbicTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvelopeContoller : ControllerBase
    {
        
        [HttpPost("postevelopes.{format}"), FormatFilter]
        public IActionResult Post([FromBody] Envelope request)
        {
            
            if (ModelState.IsValid)
            {
                return Ok(request);
            }

            return BadRequest("Pass in a valid xml payload!");
        }

        [HttpGet("getenvelopes.{format}"),FormatFilter]

        public IActionResult Get()
        {
            List<Envelope> envelopeList = new List<Envelope>();

            // Create the first envelope object with sample data
            Envelope envelope1 = new Envelope
            {
                Body = new Body
                {
                    NameEnquirySingleItem = new NameEnquirySingleItem
                    {
                        Request = new Request
                        {
                            NESingleRequest = new NESingleRequest
                            {
                                SessionId = "123456789",
                                DestinationInstitutionCode = "ABC",
                                ChannelCode = "XYZ",
                                AccountNumber = "1234567890"
                            }
                        }
                    }
                }
            };

            envelopeList.Add(envelope1);

            Envelope envelope2 = new Envelope
            {
                Body = new Body
                {
                    NameEnquirySingleItem = new NameEnquirySingleItem
                    {
                        Request = new Request
                        {
                            NESingleRequest = new NESingleRequest
                            {
                                SessionId = "987654321",
                                DestinationInstitutionCode = "DEF",
                                ChannelCode = "PQR",
                                AccountNumber = "0987654321"
                            }
                        }
                    }
                }
            };

            envelopeList.Add(envelope2);

            return Ok(envelopeList);

        }
    }

    


}
