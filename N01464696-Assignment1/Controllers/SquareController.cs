using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01464696_Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        // <summary>
        // returns the square value of the integer input
        // inputs = 2, -2, 10
        // results = 4, 4, 100
        // GET api/Square/id
        public int Get (int id)
        {
            return (id*id);
        }
    }
}
