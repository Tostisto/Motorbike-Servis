using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Class
{
    public class Orders
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Product { get; set; }
        public string Service { get; set; }
        public float Price { get; set; }
        public int Status { get; set; }


        public Orders(){}

        public Orders(int userId, string product, string service, float price, int status)
        {
            UserId = userId;
            Product = product;
            Service = service;
            Price = price;
            Status = status;
        }

    }
}
