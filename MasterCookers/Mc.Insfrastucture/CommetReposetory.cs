using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mc.Domin.Comment;
using Mc.Insfrastucture.DbContext;

namespace Mc.Insfrastucture
{
    public class CommetReposetory: ICommetReposetory
    {
        private readonly MyContext _context;

        public CommetReposetory(MyContext context)
        {
            _context = context;
        }


        public List<Cooment> GetAll()
        {
            return _context.comment.ToList();
        }

        public void Create(Cooment entity)
        {
            _context.Add(entity);
            SaveChanges();
        }

        public Cooment getbyid(long id)
        {
            return _context.comment.FirstOrDefault(x => x.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
