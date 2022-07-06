using WinFormsMVP.Views;
using WinFormsMVP.Models;
using WinFormsMVP.Repositories;

namespace WinFormsMVP.Presenters
{
    public class MainPresenter
    {
        private IMainView _mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            _mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this._mainView.ShowPetView += ShowPetView;
            
        }

        private void ShowPetView(object? sender, EventArgs e)
        {
            IPetView view = PetView.GetInstance((MainView)_mainView);
            IPetRepository petRepository = new PetRepository(sqlConnectionString);
            new PetPresenter(view, petRepository);
        }
    }
}
