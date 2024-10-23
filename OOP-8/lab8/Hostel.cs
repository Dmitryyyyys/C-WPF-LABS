using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class Hostel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Students> Student { get; set; }
        public Hostel()
        {
            Student = new List<Students>();
        }
    }
}
