using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// returns 10 more than the input integer using GET method
        /// <example> GET api/addTen/21 </example>
        /// <example> GET api/addTen/0 </example>
        /// <example> GET api/addTen/-9 </example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns> input+10 </returns>
        public int GetAddTen(int id)
        {
            return (id + 10);
        }
    }
}
