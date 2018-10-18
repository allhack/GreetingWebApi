using hello2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace hello2.Controllers
{
    public class HiController : ApiController
    {
        private IGreeter _greeter;

        public HiController(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public string Get()
        {
            return _greeter.SayHello();
        }
    }
}
