namespace lab8
{
    using System.Data.Entity;
    public class Model1 : DbContext
    {
        public Model1(): base("name=Model1") {}
        public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}