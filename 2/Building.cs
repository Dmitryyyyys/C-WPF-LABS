using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    [Serializable]
    public class Building
    {
        public List<House> Houses { get; set; }
        public Address Address{get;set;}
        public Building()
        {
            Address = new Address();
            Houses = new List<House>();
        }
    }
}
