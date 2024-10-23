using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    public class Author
    {
        public string FIO { get; set; }
        public string Country { get; set; }

        public int ID { get; set; }
        public Pages Page { get; set; }
        public enum Pages
        {
            Small = 5,
            Average = 25,
            Big= 45,
            VeryBig = 65,
            Huge= 85
        }
     

        public Author(string fio, string country, int id)
        {
            FIO = fio;
            Country = country;
            ID = id;
        }

        public override string ToString()
        {
            return $"фио: {FIO}, страна: {Country}, айди: {ID}";
        }

    }
}
