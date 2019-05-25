using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblio.Entities;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace biblio.Mappings
{
    /// <see cref="Statut"/>
    public class StatutFluent : EntityTypeConfiguration<Statut>
    {
        public StatutFluent()
        {
            ToTable("STATUT");
            HasKey(k => k.IdStatut);

            Property(p => p.IdStatut)
               .HasColumnName("ID_STATUT")
               .IsRequired();

            Property(p => p.Libelle)
               .HasColumnName("LIBELLE")
               .IsRequired();
        }
    }
}
