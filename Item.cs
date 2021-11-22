using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kur
{
    public abstract class Item
    {
        public string name {get; set;}
        public int count {get; set;}
        public int price {get; set;}
        public string model {get; set;}
    }
}