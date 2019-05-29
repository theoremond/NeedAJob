using biblio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio.Mappings
{
    /// <see cref="Formation"/>
    public class FormationFluent : EntityTypeConfiguration<Formation>
    {
        public FormationFluent()
        {
            ToTable("FORMATION");
            HasKey(k => k.IdFormation);

            Property(p => p.IdEmployeFormation)
               .HasColumnName("ID_EMPLOYE_FORMATION")
               .IsRequired()
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.IdEmployeFormation)
                .HasColumnName("ID_EMPLOYE_FORMATION")
                .IsRequired();

            Property(p => p.IntituleFormation)
                .HasColumnName("INITUTLE_FORMATION")
                .IsOptional();

            Property(p => p.DateFormation)
                .HasColumnName("DATE_FORMATION")
                .IsOptional();
        }
    }
}
