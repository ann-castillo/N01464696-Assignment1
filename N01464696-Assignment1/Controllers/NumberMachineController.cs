using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01464696_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        // <summary>
        // returns a value after applying four mathematical operators
        // GET api/NumberMachine/id
        // GET api/NumberMachine/10 == return 18
        // GET api/NumberMachine/-5 == return 3
        // GET api/NumberMachine/30 == return 38

        public int Get(int id)
        {
            return (id + 10 / 4 * 5 - 2);
        }
    }
}
