using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Motorbike
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Image_link { get; set; }


        public Motorbike(string Id, string Name, int Price, string status, string description, string image_link)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Status = status;
            this.Description = description;
            this.Image_link = image_link;
        }

    }
}
