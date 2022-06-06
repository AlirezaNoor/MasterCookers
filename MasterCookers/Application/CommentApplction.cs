using System.Globalization;
using Mc.ApplicationContracts.Comment;
using Mc.Domin.Comment;

namespace Mc.Application
{
    public class CommentApplction: ICommentApplction
    {
        private readonly ICommetReposetory _reposetory;

        public CommentApplction(ICommetReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public List<CommentViewmodel> list()
        {
            return _reposetory.GetAll().Select(x => new CommentViewmodel()
            {
                Id = x.Id,
                Datatime = x.Datatime.ToString(CultureInfo.InvariantCulture),
                contant = x.contant,
                Cookesid = x.Cookesid,
                statuse = x.statuse,
                Email = x.Email,
                Name = x.Name,


            }).ToList();
        }

        public void create(CreateComment command)
        {
            var model = new Cooment(command.Name, command.Email, command.contant, command.Cookesid);
            _reposetory.Create(model);
        }

        public void Cancell(long id)
        {
            var Comment=_reposetory.getbyid(id);
            Comment.Cancell();
            _reposetory.SaveChanges();
        }

        public void aplidet(long id)
        {
            var comment = _reposetory.getbyid(id);
            comment.aplait();
            _reposetory.SaveChanges();
        }


    }
}
