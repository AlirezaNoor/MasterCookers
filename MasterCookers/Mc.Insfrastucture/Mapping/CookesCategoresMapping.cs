using CookesCategores;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mc.Insfrastucture.Mapping
{
    public class CookesCategoresMapping:IEntityTypeConfiguration<CookesCategores.CookesCategores>
    {
        public void Configure(EntityTypeBuilder<CookesCategores.CookesCategores> builder)
        {
            builder.ToTable("CookesCategory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.Datatime);
            builder.Property(x =>x.IsDeleted );
        }
    }
}
