using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Outputs 3 strings which describe the total hosting cost using GET method
        /// <example> GET api/HostingCost/0 </example>
        /// <example> GET api/HostingCost/14 </example>
        /// <example> GET api/HostingCost/15 </example>
        /// <example> GET api/HostingCost/21 </example>
        /// <example> GET api/HostingCost/28 </example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns> fn+"fortnights at $ 5.50/FN= "+amount+" CAD","HST 13%= $"+HST+" CAD","Total= $"+Total+" CAD" </returns>
        public IEnumerable<string> HostingCost(double id)
        {
            double fn=Math.Round(Math.Floor(id/14)+1),2);
            double amount=Math.Round(5.50*fn,2);
            double HST=Math.Round((amount*13)/100,2));
            double Total=amount+HST;
            return new string[] {fn+"fortnights at $ 5.50/FN= "+amount+" CAD","HST 13%= $"+HST+" CAD","Total= $"+Total+" CAD"};
        }
    }
}

