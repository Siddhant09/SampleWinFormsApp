namespace WinFormsApp.Presenter
{
    public interface ISamplePresenter
    {
        List<EFModels.Color> GetColors();
        List<Models.User> GetUsers();
        void InsertUser(EFModels.User user);
        void DeleteUser(long? userId);
    }
}
