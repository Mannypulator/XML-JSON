# XML-JSON
THis is a simple project build with `asp.net core 7 web api`.
It aims to accept an XML payload, which is basically used for a soap service and return  the JSON format of it.

## Methods Implemented
* Get Requests `https://localhost:7135/api/EnvelopeContoller/getenvelopes.{format}` allows you to get a JSON response and an XML response depending on the `{format`} passed in the url
* Post Request `https://localhost:7135/api/EnvelopeContoller/postenvelopes.{format}` allows you to post a JSON payload or an XML giving either a JSON response or an XML response

# Sample XML Request for Post

        <Envelope xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/StanbicTask.Dto">
          <Body>
              <NameEnquirySingleItem>
                  <Request>
                      <NESingleRequest>
                          <AccountNumber>1234567890</AccountNumber>
                          <ChannelCode>XYZ</ChannelCode>
                          <DestinationInstitutionCode>ABC</DestinationInstitutionCode>
                          <SessionId>123456789</SessionId>
                      </NESingleRequest>
                  </Request>
              </NameEnquirySingleItem>
          </Body>
      </Envelope>

  
