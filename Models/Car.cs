using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarWeb.Models
{
    public class Car
    {
        public int ID { get; set; }
        public String Type { get; set; }
        public String Name { get; set; }
        public String Plate { get; set; }
        public decimal Price { get; set; }
        public String Description { get; set; }
    }

    public class CarDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}