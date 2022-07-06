using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMVP.Views
{
    public partial class PetView : Form, IPetView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;                

        //Constructor
        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePetList);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchPet.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) 
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };        
        }

        //Properties
        public string PetId
        {
            get { return txtPetId.Text; }
            set { txtPetId.Text = value; }
        }
        public string PetName
        {
            get { return txtPetName.Text; }
            set { txtPetName.Text = value; }
        }
        public string PetType
        {
            get { return txtPetType.Text; }
            set { txtPetType.Text = value; }
        }
        public string PetColours
        {
            get { return txtPetColour.Text; }
            set { txtPetColour.Text = value; }
        }
        public string SearchValue 
        {
            get { return txtSearchPet.Text; }
            set { txtSearchPet.Text = value;   }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
            
        public bool IsSuccessFull 
        { 
            get { return isSuccessful;  }
            set { isSuccessful = value; }
        }
        public string Message {
            get { return message; }
            set { message = value; }
        }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Method
        public void SetPetListBindingSource(BindingSource petlist)
        {
            dataGridViewPet.DataSource = petlist;
        }

        //Singleton patttern (Open a single form instance)
        private static PetView instance;
        public static PetView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PetView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
        
    }
}
