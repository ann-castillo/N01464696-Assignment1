using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01464696_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// the objective is to output 3 strings that descibred the total hosting cost. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>descibres the total hosting cost </returns>


        public string Get(int id)
        {
            int day = id
            int fortnight = 14;
            int HST = decimal(0.13*fortnight)


            string message1 = id + " fortnights at $5.50/FN = $" + id*5.50 + "CAD"
            string message2 = "HST 13% ="
            return message1 + message2 + message3

        }

    }
}
