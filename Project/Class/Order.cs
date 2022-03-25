using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Class
{
    public class Order
    {
        public int Id { get; set; }
        public string Produc { get; set; }
        public string Service { get; set; }
        public float Price { get; set; }
        public bool Status { get; set; }

        public Order(int id, string product, string service, float price, bool status)
        {
            Id = id;
            Produc = product;
            Service = service;
            Price = price;
            Status = status;
        }

    }
}
