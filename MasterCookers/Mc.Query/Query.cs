using Mc.Insfrastucture.DbContext;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace Mc.Query
{
    public class Query: IQuery
    {
        private readonly MyContext _context;

        public Query(MyContext context)
        {
            _context = context;
        }

        public List<DtailsViewmodel> list()
        {
            return _context.Cookess.Include(x => x.CookesCategores).Select(x => new DtailsViewmodel()
            {
                id = x.Id,
                Title = x.Title,
                contant = x.contant,
                image = x.image,
                Categorytiltle = x.CookesCategores.Title,
                shortdicriptio = x.shortdicriptio,
                Datatime = x.DateTime.ToString(CultureInfo.InvariantCulture),
            }).ToList();
        }

        public DtailsViewmodel GetById(long id)
        {
            var model = _context.Cookess.Include(x => x.CookesCategores).FirstOrDefault(x => x.Id == id);
            return new DtailsViewmodel()
            {
id = model.Id,
                Title = model.Title,
                Datatime = model.DateTime.ToString(CultureInfo.InvariantCulture),
                contant = model.contant,
                Categorytiltle = model.CookesCategores.Title,
                image = model.image,
                shortdicriptio = model.shortdicriptio
            };
        }
    }
}
