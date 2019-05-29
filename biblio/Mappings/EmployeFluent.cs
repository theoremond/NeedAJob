using System;
using biblio.Entities;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio.Mappings
{
    /// <see cref="Employe"/> 
    public class EmployeFluent : EntityTypeConfiguration<Employe>
    {
        public EmployeFluent()
        {
            ToTable("EMPLOYE");
            HasKey(k => k.IdEmploye);

            Property(p => p.NomEmploye)
                .HasColumnName("NOM_EMPLOYE")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.PrenomEmploye)
                .HasColumnName("PRENOM_EMPLOYE")
                .IsOptional();

            Property(p => p.DateDeNaissanceEmploye)
                .HasColumnName("DATE_DE_NAISSANCE_EMPLOYE")
                .IsOptional();

            Property(p => p.AncienneteEmploye)
                .HasColumnName("ANCIENNETE_EMPLOYE")
                .IsOptional();

            Property(p => p.BiographieEmploye)
                .HasColumnName("BIOGRAPHIE_EMPLOYE")
                .IsOptional();
        }
    }
}
