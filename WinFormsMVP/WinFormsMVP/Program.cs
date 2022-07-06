using System.Windows.Forms;
using WinFormsMVP.Models;
using WinFormsMVP.Presenters;
using WinFormsMVP.Repositories;
using WinFormsMVP.Views;

namespace WinFormsMVP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            string sqlconnectionString = "";
            IMainView view = new MainView();
            IPetRepository petRepository = new PetRepository(sqlconnectionString);
            new MainPresenter(view, sqlconnectionString);
            Application.Run((Form)view);
        }
    }
}