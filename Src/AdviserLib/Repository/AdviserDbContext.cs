using System.Data.Entity;

namespace EdlinSoftware.Adviser.Repository
{
    public partial class AdviserStorage : DbContext
    {
        public AdviserStorage()
            : base("name=AdviserStorage")
        {
        }

        public DbSet<AttachedFile> AttachedFiles { get; set; }
        public DbSet<AttachedLink> AttachedLinks { get; set; }
        public DbSet<Code> Codes { get; set; }
        public DbSet<FileContent> FileContents { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Text> Texts { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Code>()
               .HasMany(c => c.Platforms)
               .WithMany()
               .Map(m =>
               {
                   // Ссылка на промежуточную таблицу
                   m.ToTable("PlatformsOfCodes");

                   // Настройка внешних ключей промежуточной таблицы
                   m.MapLeftKey("CodeId");
                   m.MapRightKey("PlatformId");
               });

            modelBuilder.Entity<Topic>()
                .HasOptional(t => t.Parent)
                .WithMany(t => t.SubTopics)
                .Map(m =>
                {
                    m.MapKey("ParentId");
                });
        }
    }

}
