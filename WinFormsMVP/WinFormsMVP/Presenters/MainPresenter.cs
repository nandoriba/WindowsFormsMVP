using WinFormsMVP.Views;
using WinFormsMVP.Models;
using WinFormsMVP.Repositories;


namespace WinFormsMVP.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowPetView += ShowPetsView;
        }

        private void ShowPetsView(object sender, EventArgs e)
        {
            IPetView view = PetView.GetInstace((MainView)mainView);
            IPetRepository repository = new PetRepository(sqlConnectionString);
            new PetPresenter(view, repository);
        }
    }
}
