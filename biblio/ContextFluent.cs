using biblio.Entities;
using biblio.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace biblio
{
    public class ContextFluent : DbContext
    {
        public ContextFluent() : base("name=NeedAJob")
        {
            Database.SetInitializer<ContextFluent>(new DropCreateDatabaseIfModelChanges<ContextFluent>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            /**modelBuilder.Configurations.Add(new EmployeFluent());
            modelBuilder.Configurations.Add(new ExperienceFluent());
            modelBuilder.Configurations.Add(new FormationFluent());
            modelBuilder.Configurations.Add(new OffreFluent());
            modelBuilder.Configurations.Add(new PostulationFluent());
            modelBuilder.Configurations.Add(new StatutFluent());
            **/
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Employe> Employes { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<Offre> Offres { get; set; }
        public DbSet<Postulation> Postulations { get; set; }
        public DbSet<Statut> Statuts { get; set; }
    }
}
