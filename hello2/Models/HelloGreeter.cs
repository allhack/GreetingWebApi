﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hello2.Models
{
    public class HelloGreeter : IGreeter
    {
        public string SayHello()
        {
            return "Hello!";
        }
    }
}