using System.Globalization;
using _01.Framewoerk.UnitOfWork;
using Mc.ApplicationContracts.Comment;
using Mc.Domin.Comment;

namespace Mc.Application
{
    public class CommentApplction: ICommentApplction
    {
        private readonly ICommetReposetory _reposetory;
        private readonly IUnitOfWork _unitOfWork;
        public CommentApplction(ICommetReposetory reposetory, IUnitOfWork unitOfWork)
        {
            _reposetory = reposetory;
            _unitOfWork = unitOfWork;
        }

        public List<CommentViewmodel> list()
        {
            return _reposetory.list().Select(x => new CommentViewmodel()
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
            _unitOfWork.BiginTran();
            var model = new Cooment(command.Name, command.Email, command.contant, command.Cookesid);
            _reposetory.Create(model);
            _unitOfWork.ComitedTran();
        }

        public void Cancell(long id)
        {
            _unitOfWork.BiginTran();
            var Comment=_reposetory.Get(id);
            Comment.Cancell();
            // _reposetory.SaveChanges();
            _unitOfWork.ComitedTran();
        }

        public void aplidet(long id)
        {
            _unitOfWork.BiginTran();
            var comment = _reposetory.Get(id);
            comment.aplait();
            // _reposetory.SaveChanges();
            _unitOfWork.ComitedTran();
        }


    }
}
