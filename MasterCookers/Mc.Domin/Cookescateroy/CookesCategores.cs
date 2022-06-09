using System.Reflection;
using _01.Framewoerk.MyDomin;
using Mc.Domin.Cookes;

namespace CookesCategores
{
    public class CookesCategores:GenericDomin<long>
    {
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public ICollection<Cookes> Cookes { get; private set; }

        public CookesCategores(string title)
        {
            Title = title;
            IsDeleted = false;
        }

        protected CookesCategores()
        {
        }

        public void Edited(string Title)
        {
            this.Title = Title;
        }

        public void deactive()
        {
            IsDeleted = true;

        }

        public void Active()
            {
                IsDeleted = false;
            }
        }
}
