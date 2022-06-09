using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Framewoerk.MyReposeory
{
    public interface IReposetory<in TKey, T>
    {
        void Create(T entity);
        T Get(TKey id);
        List<T> list();

    }
}
