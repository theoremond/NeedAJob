using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblio.Entities;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace biblio.Mappings
{
    /// <see cref="Experience"/>
    public class ExperienceFluent : EntityTypeConfiguration<Experience>
    {
        public ExperienceFluent()
        {
            ToTable("EXPERIENCE");
            HasKey(k => k.IdExperience);

            Property(p => p.IdExperience)
                .HasColumnName("ID_EXPERIENCES")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.IdEmployeExperience)
                .HasColumnName("ID_EMPLOYE_EXPERIENCES")
                .IsRequired();

            Property(p => p.IntituleExperience)
                .HasColumnName("INITUTLE_EXPERIENCE")
                .IsOptional();

            Property(p => p.DateExperience)
                .HasColumnName("DATE_EXPERIENCE")
                .IsOptional();
        }
    }
}
