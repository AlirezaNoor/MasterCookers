namespace Mc.Query
{
    public interface IQuery
    {
        List<DtailsViewmodel> list();
        DtailsViewmodel GetById(long id);
    }
}