using IRRF.Domain.Entities;
using IRRF.Infraestructure.Data.Mapping.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IRRF.Infraestructure.Data.Mapping
{
    public class ContributorMapping : EntityBaseMapping<Contributor, int>
    {
        public override void Configure(EntityTypeBuilder<Contributor> builder)
        {
            //Definiação do Nome da Tabela
            builder.ToTable("Contributor");

            //Definição das propriedades dos campos no banco de dados
            builder.Property(x => x.Id)
                .HasColumnName("ContributorId")
                .ValueGeneratedOnAdd(); 

            builder.Property(x => x.Cpf)
                .HasColumnType("varchar(14)")
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.NumberDependents)
                .HasDefaultValueSql("0")
                .IsRequired();

            builder.Property(x => x.Salary)
                .IsRequired();

            builder.Property(x => x.IncomeTax)
                .IsRequired();

            builder.Property(x => x.Created)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            builder.Property(x => x.Updated)
                .IsRequired();

            //Criação do índice
            builder.HasIndex(x => x.Id)
                .HasName("IX_Contributor_ContributorId")
                .IsUnique();
        }
    }
}
