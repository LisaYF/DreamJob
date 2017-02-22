using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication4.Models
{
    public class Dbresume:DbContext
    {
        public DbSet<resume> res { get; set; }
    }
}