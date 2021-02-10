using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01464696_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        // <summary>
        // returns 10 more than the integer input
        // inputs for the assignment: 21, 0, -9
        // results for the assignment: 31, 10, 1
        // GET api/AddTen/id
        public int Get(int id)
        {
            return (id + 10);
        }

    }
}
