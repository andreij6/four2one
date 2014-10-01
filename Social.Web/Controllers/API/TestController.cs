using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Social.Web.Controllers.API
{
    [RoutePrefix("Verify")]
    [AllowAnonymous]
    public class TestController : ApiController
    {
        [Route("Address")]
        [HttpPost]
        public string Address()
        {
            string result =
                    @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"">" +
                        "<soapenv:Body>" +
                            @"<notificationsResponse xmlns=""http://soap.sforce.com/2005/09/outbound"">" +
                                "<Ack>true</Ack>" +
                            "</notificationsResponse>" +
                        "</soapenv:Body>" +
                    "</soapenv:Envelope>";

            return result;
        }
    }
}
