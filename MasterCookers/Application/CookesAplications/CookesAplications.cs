using System.Globalization;
using Mc.ApplicationContracts.CookApplication;
using Mc.Domin.Cookes;

namespace Mc.Application.CookesAplications
{
    public class CookesAplications : ICookesAplications

    {
        private readonly ICookerReposetoy _cookerReposetoy;

        public CookesAplications(ICookerReposetoy cookerReposetoy)
        {
            _cookerReposetoy = cookerReposetoy;
        }

        public void Createcookes(CreateCookes command)
        {
            var model = new Cookes(command.Title, command.shortdicriptio, command.contant, command.image,
                command.categoryId);
            _cookerReposetoy.create(model);
        }

        public List<CookesViewModels> list()
        {
           return _cookerReposetoy.GetAll().Select(x => new CookesViewModels()
           {
               Id = x.Id,
               Title = x.Title,
            IsDeleted = x.IsDeleted,
            DateTime = x.DateTime.ToString(CultureInfo.InvariantCulture),
               
           }).ToList();

        }

        public void EditedCookes(EditCookes command)
        {
           var oneCookes= _cookerReposetoy.Edited(command.Id);
           var newCookes = new Cookes(command.Title, command.shortdicriptio, command.contant, command.image,
               command.categoryId);
           _cookerReposetoy.savechange();
        }

        public EditCookes Filded(long id)
        {
            var oneModel = _cookerReposetoy.Edited(id);
            return new EditCookes()
            {
                Id = oneModel.Id,
                Title = oneModel.Title,
                categoryId = oneModel.categoryId,
                contant = oneModel.contant,
                image = oneModel.image,
                shortdicriptio = oneModel.contant,
            };
        }
    }
}
