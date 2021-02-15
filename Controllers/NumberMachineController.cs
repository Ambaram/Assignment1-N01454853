using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// returns an integer after perfprming 4 mathematical operations 
        /// over the input integer using GET method
        /// <example> GET api/NumberMachine/10</example>
        /// <example> GET api/Number Machine/-5</example>
        /// <example> GET api/NumberMachine/30</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>returns ((((input/input)*input)+input)-input)</returns>
        public int GETNumberMachine(int id)
        {
            return ((((id / id) * id) + id) - id);
        }
    }
}