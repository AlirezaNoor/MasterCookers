using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Framewoerk.MyReposeory;
using Mc.Domin.Cookes;
using Mc.Insfrastucture.DbContext;

namespace Mc.Insfrastucture.CookesReposetories
{
    public class CookerReposetoy: Reposetory<long,Cookes> ,ICookerReposetoy
        
    {
        private readonly MyContext _context;

        public CookerReposetoy(MyContext context) :base(context)
        {
            _context = context;
        }


    }
}
