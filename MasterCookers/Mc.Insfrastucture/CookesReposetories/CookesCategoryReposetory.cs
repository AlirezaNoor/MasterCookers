using _01.Framewoerk.MyReposeory;
using CookesCategores;
using Mc.Insfrastucture.DbContext;

namespace Mc.Insfrastucture.CookesReposetories
{
    public class CookesCategoryReposetory: Reposetory<long,CookesCategores.CookesCategores>, ICookesCategoryReposetory
    {
        private readonly MyContext _myContext;

        public CookesCategoryReposetory(MyContext myContext):base(myContext)
        {
            _myContext = myContext;
        }



  
    }
}