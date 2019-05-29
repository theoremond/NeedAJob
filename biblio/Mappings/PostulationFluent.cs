using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblio.Entities;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace biblio.Mappings
{
    /// <see cref="Postulation"/>
    public class PostulationFluent : EntityTypeConfiguration<Postulation>
    {
        public PostulationFluent()
        {
            ToTable("POSTULATION");
            HasKey(k => new { k.IdOffrePostulation, k.IdEmployePostulation });

            Property(p => p.IdOffrePostulation)
               .HasColumnName("ID_OFFRE_POSTULATION")
               .IsRequired();

            Property(p => p.IdEmployePostulation)
               .HasColumnName("ID_EMPLOYE_POSTULATION")
               .IsRequired();

            Property(p => p.StatutPostulation)
                .HasColumnName("ID_EMPLOYE_EXPERIENCES")
                .IsRequired();

            Property(p => p.DatePostulation)
                .HasColumnName("DATE_POSTULATION")
                .IsOptional();
        }
    }
}
