using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Framewoerk.MyReposeory;
using Mc.Domin.Comment;
using Mc.Insfrastucture.DbContext;

namespace Mc.Insfrastucture
{
    public class CommetReposetory: Reposetory<long,Cooment>, ICommetReposetory 
    {
        private readonly MyContext _context;

        public CommetReposetory(MyContext context): base(context)
        {
            _context=context;
        }


    
    }
}
