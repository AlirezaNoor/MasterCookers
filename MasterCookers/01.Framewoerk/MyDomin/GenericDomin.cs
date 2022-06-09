namespace _01.Framewoerk.MyDomin
{
    public class GenericDomin<T>
    {
        public T Id { get; set; }
        public DateTime Datatime { get; set; }

        public GenericDomin(DateTime datatime)
        {
            Datatime = datatime;
        }

        protected GenericDomin()
        {
        }
    }
}
