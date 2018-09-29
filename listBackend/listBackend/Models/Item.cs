using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace listBackend.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public double Price { get; set; }

        public Item(string name)
        {
            Name = name;
        }
    }
}
