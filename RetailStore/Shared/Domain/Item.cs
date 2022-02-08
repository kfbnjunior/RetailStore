using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore.Shared.Domain
{
    public class Item : BaseDomainModel
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
