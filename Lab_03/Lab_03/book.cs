using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab_02
{
    [Serializable]
    public enum Format
    {
        TXT,
        PDF,
        FB2,
        EPUB
    }

    public class book
    {
        private object izd;
        private string text1;
        private string text2;
        private int v;
        private object udc;

        public Format Format { get; set; }

        [Required(ErrorMessage = "Размер должен быть указан.")]
        [Range(1, int.MaxValue, ErrorMessage = "Размер должен быть больше нуля.")]
        public int Sizee { get; set; }

        [Required(ErrorMessage = "Название книги должно быть указано.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "УДК должен быть указан.")]
        [RegularExpression(@"^\d{1,4}$", ErrorMessage = "УДК должен состоять из не более 4 цифр.")]
        public string UDC { get; set; }

        [Required(ErrorMessage = "Количество страниц должно быть указано.")]
        [Range(1, int.MaxValue, ErrorMessage = "Количество страниц должно быть больше нуля.")]
        public int Page { get; set; }

        [Required(ErrorMessage = "Год издания должен быть указан.")]
        [Range(1900, int.MaxValue, ErrorMessage = "Год издания должен быть больше 1900.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Издательство должно быть указано.")]
        public string Izd { get; set; }
        [Required(ErrorMessage = "Дата обязательна")]
        public DateTime Date { get; set; }

        public Author Authors { get; set; }
        [JsonConstructor]

        public book(Format format, int sizee, string name, string udc, int page, int year, string FIO, string country, int ID, string izd, DateTime date)
        {
            Format = format;
            Sizee = sizee;
            Name = name;
            UDC = udc;
            Page = page;
            Year = year;
            Authors = new Author(FIO, country, ID);
            Izd = izd;
            Date = date;
        }
        

        public book(Format format, int sizee, string name, string udc, int page, int year, string izd, string text1, string text2, int v)
        {
            Format = format;
            Sizee = sizee;
            Name = name;
            UDC = udc;
            Page = page;
            Year = year;
            Izd = izd;
            this.izd = izd;
            this.text1 = text1;
            this.text2 = text2;
            this.v = v;
        }
        
        public book(Format format, int sizee, string name, object udc, int page, int year, string izd, string text1, string text2, int v)
        {
            Format = format;
            Sizee = sizee;
            Name = name;
            this.udc = udc;
            Page = page;
            Year = year;
            this.izd = izd;
            this.text1 = text1;
            this.text2 = text2;
            this.v = v;
        }

        public override string ToString()
        {
            return $"Format: {Format}, Size: {Sizee}, Name: {Name}, UDC: {UDC}, Year: {Year}, Izd: {Izd}, Date: {Date}\n";
        }
    }
}
