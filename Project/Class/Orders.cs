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
        public bool Status { get; set; }

        public Orders(int id, string product, string service, float price, bool status)
        {
            Id = id;
            Product = product;
            Service = service;
            Price = price;
            Status = status;
        }

    }
}
