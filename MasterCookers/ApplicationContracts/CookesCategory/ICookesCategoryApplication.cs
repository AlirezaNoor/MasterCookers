namespace Mc.ApplicationContracts.CookesCategory
{
    public interface ICookesCategoryApplication
    {
        List<CookesCategoryViewmodel> List();
        void CreateCategory(CreateCategory command);
        void EditedCategory(EditCategory command);
        EditCategory filled(long id);
        void Active(long id);
        void Deactive(long id);
    }
}
