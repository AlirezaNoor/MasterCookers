using _01.Framewoerk.UnitOfWork;
using Mc.Insfrastucture.DbContext;
using Microsoft.EntityFrameworkCore;

namespace Mc.Insfrastucture.UnitOfWork
{
    public class IUnitOfWorkEf :IUnitOfWork
    {
        private readonly MyContext _context;

        public IUnitOfWorkEf(MyContext context)
        {
            _context = context;
        }

        public void BiginTran()
        {
            _context.Database.BeginTransaction();
        }

        public void ComitedTran()
        {
         _context.Database.CommitTransaction();
         _context.SaveChanges();
        }

        public void RollBack()
        {
        _context.Database.RollbackTransaction();
        }
    }
}
