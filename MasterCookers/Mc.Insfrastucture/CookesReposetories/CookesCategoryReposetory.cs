using CookesCategores;
using Mc.Insfrastucture.DbContext;

namespace Mc.Insfrastucture.CookesReposetories
{
    public class CookesCategoryReposetory: ICookesCategoryReposetory
    {
        private readonly MyContext _myContext;

        public CookesCategoryReposetory(MyContext myContext)
        {
            _myContext = myContext;
        }

        public void Create(CookesCategores.CookesCategores entity)
        {
            _myContext.cookescategores.Add(entity);
            SaveChanges();
        }

        public CookesCategores.CookesCategores get(long id)
        {
           return _myContext.cookescategores.FirstOrDefault(x => x.Id == id);
        }

        public List<CookesCategores.CookesCategores> GetAll()
        {
            return _myContext.cookescategores.ToList();
        }

     

        public void SaveChanges()
        {
            _myContext.SaveChanges();
        }

  
    }
}