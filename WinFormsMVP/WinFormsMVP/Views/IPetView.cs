namespace WinFormsMVP.Views
{
    public interface IPetView
    {
        //Properties - Fields
        string PetId { get; set;  }
        string PetName { get; set; }
        string PetType { get; set; }
        string PetColours { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessFull { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetPetListBindingSource(BindingSource petlist);
        void Show(); //Optional
        
    }
}
