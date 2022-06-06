namespace Mc.ApplicationContracts.Comment
{
    public interface ICommentApplction
    {
        List<CommentViewmodel> list();
        void create(CreateComment command);
        void Cancell(long id);
        void aplidet(long id);

    }
}
