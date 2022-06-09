using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mc.Domin.Cookes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mc.Insfrastucture.Mapping
{
    public class CookesMapping:IEntityTypeConfiguration<Cookes>
    {
        public void Configure(EntityTypeBuilder<Cookes> builder)
        {
            builder.ToTable("Cookess");
            builder.Property(x => x.Title);
            builder.Property(x => x.IsDeleted);
            builder.Property(x => x.Datatime);
            builder.Property(x => x.contant);
            builder.Property(x => x.image);
            builder.Property(x => x.shortdicriptio);
            builder.HasOne(x => x.CookesCategores).WithMany(x => x.Cookes).HasForeignKey(x => x.categoryId);

        }
    }
}
