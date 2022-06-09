using System.Globalization;
using _01.Framewoerk.UnitOfWork;
using Mc.ApplicationContracts.CookApplication;
using Mc.Domin.Cookes;

namespace Mc.Application.CookesAplications
{
    public class CookesAplications : ICookesAplications

    {
        private readonly ICookerReposetoy _cookerReposetoy;
        private readonly IUnitOfWork _unitOfWork;
        public CookesAplications(ICookerReposetoy cookerReposetoy, IUnitOfWork unitOfWork)
        {
            _cookerReposetoy = cookerReposetoy;
            _unitOfWork = unitOfWork;
        }

        public void Createcookes(CreateCookes command)
        {
            _unitOfWork.BiginTran();
            var model = new Cookes(command.Title, command.shortdicriptio, command.contant, command.image,
                command.categoryId);
            _cookerReposetoy.Create(model);
            _unitOfWork.ComitedTran();
        }

        public List<CookesViewModels> list()
        {
           return _cookerReposetoy.list().Select(x => new CookesViewModels()
           {
               Id = x.Id,
               Title = x.Title,
            IsDeleted = x.IsDeleted,
            DateTime = x.Datatime.ToString(CultureInfo.InvariantCulture),
               
           }).ToList();

        }

        public void EditedCookes(EditCookes command)
        {
            _unitOfWork.BiginTran();
           var oneCookes= _cookerReposetoy.Get(command.Id);
           oneCookes.Edited(command.Title, command.shortdicriptio, command.contant, command.image,
               command.categoryId);
           // _cookerReposetoy.savechange();
           _unitOfWork.ComitedTran();
        }

        public EditCookes Filded(long id)
        {
            var oneModel = _cookerReposetoy.Get(id);
            return new EditCookes()
            {
                Id = oneModel.Id,
                Title = oneModel.Title,
                categoryId = oneModel.categoryId,
                contant = oneModel.contant,
                image = oneModel.image,
                shortdicriptio = oneModel.shortdicriptio,
            };
        }
    }
}
