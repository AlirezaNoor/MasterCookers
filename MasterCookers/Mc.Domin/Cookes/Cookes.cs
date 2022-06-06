using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc.Domin.Cookes
{
    public class Cookes
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public string shortdicriptio { get; private set; }
        public string contant { get; private set; }
        public string image { get; private set; }
        public long categoryId { get; private set; }
        public CookesCategores.CookesCategores CookesCategores { get; private set; }
        public bool IsDeleted { get;  private set; }
        public DateTime DateTime { get; private set; }

        public Cookes(string Title, string shortdicriptio, string contant, string image, long categoryId)
        {
            this.Title = Title;
            this.shortdicriptio = shortdicriptio;
            this.contant = contant;
            this.image = image;
            this.categoryId = categoryId;
            this.IsDeleted = false;
            DateTime=DateTime.Now;
        }

        protected Cookes()
        {
        }

        public void Edited(string Title, string shortdicriptio, string contant, string image, long categoryId)
        {
            this.Title = Title;
            this.shortdicriptio = shortdicriptio;
            this.contant = contant;
            this.image = image;
            this.categoryId = categoryId;
            this.IsDeleted = false;
            DateTime = DateTime.Now;
        }
    }
    
}
