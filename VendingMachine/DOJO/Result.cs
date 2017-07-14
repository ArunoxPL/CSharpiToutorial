using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOJO
{
    public class Result
    {
        public Item? Item { get; set; } //czmu tu jest ? -  bo może być null
        public IEnumerable<Coin> Change { get; set; }
    }
}
