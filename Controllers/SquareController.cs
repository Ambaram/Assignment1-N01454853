using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// returns square of the input integer using GET method
        /// <example> GET api/Square/2</examle>
        /// <example> GET api/Square/-2</example>
        /// <example> GET api/Square/10</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns> returns square of the input</returns>
        public double GETsquare(int id)
        {
            return (Math.Pow(id, 2));
        }
    }
}
