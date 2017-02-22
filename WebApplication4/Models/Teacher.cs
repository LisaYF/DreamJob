using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Tname { get; set; }
        public int Tbatch { get; set; }
        public string Tsubject { get; set; }
    }
}