using _01.Framewoerk.MyDomin;

namespace Mc.Domin.Comment
{
    public class Cooment:GenericDomin<long>
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string contant { get; private set; }
        public long  statuse { get; private set; }
        public long Cookesid { get; private set; }

        public Cooment(string name, string email, string contant, long cookesid)
        {
            Name = name;
            Email = email;
            this.contant = contant;
            Cookesid = cookesid;
            statuse = Statuses.dontsea;


        }

        public void Cancell()
        {
            this.statuse = Statuses.sea;
        }

        public void aplait()
        {
            this.statuse = Statuses.applieded;
        }


        protected Cooment()
        {
        }
    }

}
