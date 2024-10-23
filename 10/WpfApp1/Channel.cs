using System.Collections.Generic;

namespace WpfApp1
{
    //1 этап: определение модели

    internal sealed class Channel // настройки канала
    {
        public int Id { get; set; }
        public string Title { get; set; } //название канала
        public string Description { get; set; } //описание канала
        public string Link { get; set; } //ссылка на канал
        public string Copyright { get; set; } //копирайт
        public ICollection<Item> Items { get; set; }

        public Channel()
        {
            Items = new List<Item>();
        }
        public override string ToString()
        {
            return Title;
        }
    }
}