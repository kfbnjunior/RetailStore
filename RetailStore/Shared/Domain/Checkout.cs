using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore.Shared.Domain
{
    public class Checkout : BaseDomainModel
    {
        public virtual Item Item { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
