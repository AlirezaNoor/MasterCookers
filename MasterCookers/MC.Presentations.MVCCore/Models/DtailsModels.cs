using Mc.ApplicationContracts.Comment;
using Mc.Query;

namespace MC.Presentations.MVCCore.Models
{
    public class DtailsModels
    {
        public DtailsViewmodel Dtails { get; set; }
        public List<CommentViewmodel> Comment { get; set; }
        public CreateComment  create { get; set; }
    }
}
