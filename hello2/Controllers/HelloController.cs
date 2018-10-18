using hello2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace hello2.Controllers
{
    public class HelloController : ApiController
    {
        private IGreeter _greeter;

        public HelloController(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public string Get()
        {
            return _greeter.SayHello();
        }
    }
}