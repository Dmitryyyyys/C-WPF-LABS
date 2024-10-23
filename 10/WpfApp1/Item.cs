namespace WpfApp1
{
    internal class Item //статьи
    {
        public int Id { get; set; }
        public string Title { get; set; } //название статьи
        public string Link { get; set; } //ссылка
        public string Description { get; set; } //описание
        public string PubDate { get; set; } //дата публикации
        public int? ChannelId { get; set; }
        public virtual Channel Channel { get; set; }

        public Item()
        {
            Title = "";
            Link = "";
            Description = "";
            PubDate = "";
        }
    }
}