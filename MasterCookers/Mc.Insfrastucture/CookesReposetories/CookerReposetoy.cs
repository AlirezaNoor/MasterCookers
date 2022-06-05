using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mc.Domin.Cookes;
using Mc.Insfrastucture.DbContext;

namespace Mc.Insfrastucture.CookesReposetories
{
    public class CookerReposetoy: ICookerReposetoy
    {
        private readonly MyContext _context;

        public CookerReposetoy(MyContext context)
        {
            _context = context;
        }

        public void create(Cookes entity)
        {
            _context.Cookess.Add(entity);
            savechange();
        }

        public List<Cookes> GetAll()
        {
            return _context.Cookess.ToList();
        }

        public Cookes Edited(long id)
        {
            return _context.Cookess.FirstOrDefault(x => x.Id == id);
        }

        public void savechange()
        {
            _context.SaveChanges();
        }
    }
}
