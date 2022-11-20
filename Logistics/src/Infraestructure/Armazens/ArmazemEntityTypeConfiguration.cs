using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Logistics.Domain.Subjects;

namespace Logistics.Infrastructure.Subjects
{
    internal class SubjectEntityTypeConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            //builder.ToTable("Subjects",SchemaNames.Logistics);
            //builder.HasKey(b => b.Id);
            
            //builder.Property<SubjectCode>("IdSubject").IsRequired();
            //.HasColumnName("Id")
            //.IsRequired();

            //builder.Property<SubjectCode>("IdSubject").IsRequired();
            //builder.HasIndex(b => b.IdSubject).IsUnique();

        }
    }
}
