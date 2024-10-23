using System.Data.Entity;

namespace WpfApp1
{
    //2 этап: контекст + паттерн Репозиторий

    internal class ChannelContext : DbContext
    {
        public ChannelContext()
            : base("DbConnection")
        { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<ChannelImage> ChannelImages { get; set; }
    }
}
