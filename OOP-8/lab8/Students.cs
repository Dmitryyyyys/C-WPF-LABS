using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string S_name { get; set; }
        public int Age { get; set; }

        public ICollection<Hostel> Hostels { get; set; }
        internal Students()
        {
            Hostels = new List<Hostel>();
        }
    }
}
