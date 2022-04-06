using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Class
{
    public class Services
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string SPZ { get; set; }
        public string Shop { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public Services() { }

        public Services(int userID, string brand, string model, int year, string sPZ, string shop, string description, string status)
        {
            UserID = userID;
            Brand = brand;
            Model = model;
            Year = year;
            SPZ = sPZ;
            Shop = shop;
            Description = description;
            Status = status;
        }

        public Services(int id, int userID, string brand, string model, int year, string sPZ, string shop, string description, string status)
        {
            Id = id;
            UserID = userID;
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
