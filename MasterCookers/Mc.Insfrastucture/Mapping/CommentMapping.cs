using Mc.Domin.Comment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mc.Insfrastucture.Mapping
{
    public class CommentMapping:IEntityTypeConfiguration<Cooment>
    {
        public void Configure(EntityTypeBuilder<Cooment> builder)
        {
            builder.ToTable("comments");
            builder.Property(x => x.Cookesid);
            builder.Property(x => x.Id);
            builder.Property(x => x.Datatime);
            builder.Property(x => x.Email);
            builder.Property(x => x.Name);
            builder.Property(x => x.contant);
            builder.Property(x => x.statuse);
        }
    }
}
