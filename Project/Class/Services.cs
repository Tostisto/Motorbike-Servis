using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Class
{
    public class Services
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string SPZ { get; set; }
        public string Shop { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public Services(int iD, string brand, string model, int year, string sPZ, string shop, string description, bool status)
        {
            ID = iD;
            Brand = brand;
            Model = model;
            Year = year;
            SPZ = sPZ;
            Shop = shop;
            Description = description;
            Status = status;
        }
    }
}
