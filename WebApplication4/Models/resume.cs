﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class resume
    {
        public int ID {get;set;}
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string education { get; set; }
        public string major { get; set; }
        public string introduction { get; set; }
    }
}