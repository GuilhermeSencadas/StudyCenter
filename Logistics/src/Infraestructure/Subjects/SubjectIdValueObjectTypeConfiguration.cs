using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Logistics.Domain.Subjects;

namespace Logistics.Infrastructure.Subjects
{
    internal class SubjectCodeValueObjectTypeConfiguration : IEntityTypeConfiguration<SubjectCode>
    {
        public void Configure(EntityTypeBuilder<SubjectCode> builder)
        {
            //builder.ToTable("SubjectCodes",SchemaNames.Logistics);
            builder.Property<int>("Id").IsRequired();//Id is a shadow property
            builder.HasKey("Id"); //Id is a shadow property
        }
    }
}
