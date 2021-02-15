using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns string when receiving a GET request 
        /// <example> GET api/Greeting/3</example>
        /// <example> GET api/Greeting/6</example>
        /// <example> GET api/Greeting/0</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>"Greeting to {id} people"</returns>
        public string GetGreeting(int id)
        {
            return "Greetings to " + id +" people!";
        }
    }
}
