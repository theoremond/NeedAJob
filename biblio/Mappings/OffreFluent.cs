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
    /// <see cref="Offre"/>
    class OffreFluent : EntityTypeConfiguration<Offre>
    {
        public OffreFluent()
        {
            ToTable("OFFRE");
            HasKey(k => k.IdOffre);

            Property(p => p.IdOffre)
                .HasColumnName("IDOFFRE")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.IntituleOffre)
                .HasColumnName("INTITULEOFFRE")
                .IsOptional();

            Property(p => p.DateOffre)
                .HasColumnName("DATEOFFRE")
                .IsOptional();

            Property(p => p.SalaireOffre)
                .HasColumnName("SALAIREOFFRE")
                .IsOptional();

            Property(p => p.DescriptionOffre)
                .HasColumnName("DESCRIPTIONOFFRE")
                .IsOptional();

            Property(p => p.IdStatutOffre)
                .HasColumnName("IDSTATUTOFFRE")
                .IsOptional();

            Property(p => p.ResponsableOffre)
                .HasColumnName("RESPONSABLEOFFRE")
                .IsOptional();
        }
    }
}
