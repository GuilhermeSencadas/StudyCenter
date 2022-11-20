using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Logistics.Domain.Subjects;

namespace Logistics.Infrastructure.Subjects
{
    internal class SubjectEntityTypeConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(subject => subject.Id);
            builder.OwnsOne(x => x.Code, code =>
                    {
                        code.Property(x => x.Code).IsRequired();
                    });
            builder.OwnsOne(x => x.Name, name =>
                     {
                         name.Property(x => x.Name).IsRequired();
                     });

            builder.OwnsOne(x => x.Description, description =>
                    {
                        description.Property(x => x.Descripion);
                    });         
            builder.ToTable("Subjects");

        }
    }
}
