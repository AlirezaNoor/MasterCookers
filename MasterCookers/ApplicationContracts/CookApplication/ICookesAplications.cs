namespace Mc.ApplicationContracts.CookApplication
{
    public interface ICookesAplications
    {
        void Createcookes(CreateCookes command);
        List<CookesViewModels> list();
        void EditedCookes(EditCookes command);
        EditCookes Filded(long id);
    }
}
