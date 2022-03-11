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
        public string Load { get; set; }

        public Motorbike(string Id, string Name, int Price, string load)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Load = load;
        }

    }
}
