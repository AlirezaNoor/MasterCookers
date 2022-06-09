using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Framewoerk.UnitOfWork
{
    public interface IUnitOfWork
    {
        void BiginTran();
        void ComitedTran();
        void RollBack();
    }
}
