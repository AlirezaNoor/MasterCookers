using System.Reflection;

namespace CookesCategores
{
    public class CookesCategores
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public DateTime Datatime { get; private set; }
        public bool IsDeleted { get; private set; }

        public CookesCategores(string title)
        {

            Title = title;
            Datatime = DateTime.Now;
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
