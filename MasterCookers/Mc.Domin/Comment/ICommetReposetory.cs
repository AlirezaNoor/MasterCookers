using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc.Domin.Comment
{
    public interface ICommetReposetory
    {
        List<Cooment> GetAll();
        void Create(Cooment entity);
        Cooment getbyid(long id);
        void SaveChanges();
    }
}
