using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01464696_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        // <summary>
        // returns "Hello World!" in command prompt
        // will not run through google chrome
        // GET api/Greeting
        public string Post (int id)
        {
            return "Hello World!";
        }

        // <summary>
        // returns greetings to id people
        // inputs for the assignement: 3, 6, 0
        // results: "Greetings to 3, 6, 0 people!
        // GET api/Greeting/id
        public string Get (int id)
        {
            return "Greetings to " + id + " people!";
        }

    }
}
