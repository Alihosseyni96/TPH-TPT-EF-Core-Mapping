using Microsoft.EntityFrameworkCore;
using TPH_TPT_EF_Core_Mapping.Model.TPH_MappingModels;
using TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels;

namespace TPH_TPT_EF_Core_Mapping.Model
{
    public class EFCoreMappingContext : DbContext
    {
        public EFCoreMappingContext(DbContextOptions option):base(option)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //to Configure Ef We have TPT Pattern
            modelBuilder.Entity<Animal>().ToTable("Animals");
            modelBuilder.Entity<Dog>().ToTable("Dogs");
            modelBuilder.Entity<Cat>().ToTable("Cats");

            base.OnModelCreating(modelBuilder);
        }

        #region TPH
        public DbSet<Person> People { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }

        #endregion


        #region TPT
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Cat> Cats { get; set; }

        #endregion


        public DbSet<Category> Categories { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
