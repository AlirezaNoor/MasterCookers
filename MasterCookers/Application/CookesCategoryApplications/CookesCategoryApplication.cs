using System.Globalization;
using Mc.ApplicationContracts.CookesCategory;
using CookesCategores;

namespace Mc.Application.CookesCategoryApplications
{
    public class CookesCategoryApplication: ICookesCategoryApplication

    {
        private readonly ICookesCategoryReposetory _categoryReposetory;

        public CookesCategoryApplication(ICookesCategoryReposetory categoryReposetory)
        {
            _categoryReposetory = categoryReposetory;
        }

        public void CreateCategory(CreateCategory command)
        {

            var cat = new CookesCategores.CookesCategores(command.title);
            _categoryReposetory.Create(cat);
        }

        public void EditedCategory(EditCategory command)
        {
           var category= _categoryReposetory.get(command.Id);
           category.Edited(command.title);
               _categoryReposetory.SaveChanges();
        }

        public EditCategory filled(long id)
        {
            var my=_categoryReposetory.get(id);
 
            return new EditCategory
            {
                Id = my.Id,
                title = my.Title,

            };
             
        }


        public List<CookesCategoryViewmodel> List()
        {
            return _categoryReposetory.GetAll().Select(x => new CookesCategoryViewmodel()
            {
                Title = x.Title,
                Id = x.Id,
                Datatime = x.Datatime.ToString(CultureInfo.InvariantCulture),
                IsDeleted = x.IsDeleted,
            }).ToList();
        }
    }
}
