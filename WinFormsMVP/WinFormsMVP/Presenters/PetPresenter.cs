using WinFormsMVP.Models;
using WinFormsMVP.Views;

namespace WinFormsMVP.Presenters
{
    public class PetPresenter
    {
        //Fields
        private IPetView _view;
        private IPetRepository _petRepository;
        private BindingSource petsBindSource;
        private IEnumerable<PetModel> petList;

        //Constructor
        public PetPresenter(IPetView view, IPetRepository petRepository)
        {
            this.petsBindSource = new BindingSource();
            this._view = view;
            this._petRepository = petRepository;

            //Subscribe event handler methods to view events
            this._view.SearchEvent += SearchPet;
            this._view.AddNewEvent += AddNewPet;
            this._view.EditEvent += LoadSelectedPetToEdit;
            this._view.DeleteEvent += DeleteSelectedPet;
            this._view.SaveEvent += SavePet;
            this._view.CancelEvent += CancelAction;

            //Set pets binding source
            this._view.SetPetListBindingSource(petsBindSource);

            //Load pet list view
            LoadAllPetList();

            //Show view
            this._view.Show();

        }

        //Methods
        private void LoadAllPetList()
        {
            petList = _petRepository.GetAll();
            petsBindSource.DataSource = petList; //Set data source
        }
        private void SearchPet(object? sender, EventArgs e)
        {
            bool emptyValues = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (!emptyValues)            
                petList = _petRepository.GetByValue(this._view.SearchValue);            
            else
                petList = _petRepository.GetAll();

            petsBindSource.DataSource = petList; //Set data source
        }

        private void SavePet(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedPet(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedPetToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPet(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


    }
}
