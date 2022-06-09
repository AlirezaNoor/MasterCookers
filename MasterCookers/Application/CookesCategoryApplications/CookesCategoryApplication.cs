using System.Globalization;
using _01.Framewoerk.UnitOfWork;
using Mc.ApplicationContracts.CookesCategory;
using CookesCategores;

namespace Mc.Application.CookesCategoryApplications
{
    public class CookesCategoryApplication: ICookesCategoryApplication

    {
        private readonly ICookesCategoryReposetory _categoryReposetory;
        private readonly IUnitOfWork _unitOfWork;

        public CookesCategoryApplication(ICookesCategoryReposetory categoryReposetory, IUnitOfWork unitOfWork)
        {
            _categoryReposetory = categoryReposetory;
            _unitOfWork = unitOfWork;
        }

        public void CreateCategory(CreateCategory command)
        {
            _unitOfWork.BiginTran();
            var cat = new CookesCategores.CookesCategores(command.title);
            _categoryReposetory.Create(cat);
            _unitOfWork.ComitedTran();
        }

        public void EditedCategory(EditCategory command)
        {
            _unitOfWork.BiginTran();
           var category= _categoryReposetory.Get(command.Id);
           category.Edited(command.title);
               // _categoryReposetory.SaveChanges();
               _unitOfWork.ComitedTran();
        }

        public EditCategory filled(long id)
        {
            var my=_categoryReposetory.Get(id);
 
            return new EditCategory
            {
                Id = my.Id,
                title = my.Title,

            };
             
        }

        public void Active(long id)
        {
            _unitOfWork.BiginTran();
           var category1= _categoryReposetory.Get(id);
           category1.Active();
           // _categoryReposetory.SaveChanges();
           _unitOfWork.ComitedTran();
        }

        public void Deactive(long id)
        {
            _unitOfWork.BiginTran();
            var category1 = _categoryReposetory.Get(id);
            category1.deactive();
            // _categoryReposetory.SaveChanges();
            _unitOfWork.ComitedTran();
        }


        public List<CookesCategoryViewmodel> List()
        {
            return _categoryReposetory.list().Select(x => new CookesCategoryViewmodel()
            {
                Title = x.Title,
                Id = x.Id,
                Datatime = x.Datatime.ToString(CultureInfo.InvariantCulture),
                IsDeleted = x.IsDeleted,
            }).ToList();
        }
    }
}
