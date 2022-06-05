using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc.Domin.Cookes
{
    public interface ICookerReposetoy
    {
        void create(Cookes entity);
        List<Cookes> GetAll();
        Cookes Edited(long id);
        void savechange();


    }
}
