using Microsoft.EntityFrameworkCore;

namespace _01.Framewoerk.MyReposeory
{
    public class Reposetory<Tkey,T>:IReposetory<Tkey,T> where T : class
    {
        private readonly DbContext _context;

        public Reposetory(DbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add<T>(entity);
        }

        public T Get(Tkey id)
        {
            return _context.Find<T>(id);
        }

        public List<T> list()
        {
            return _context.Set<T>().ToList();
        }
    }
}
