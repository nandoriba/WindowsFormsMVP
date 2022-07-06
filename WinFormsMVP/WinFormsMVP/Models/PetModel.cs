using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WinFormsMVP.Models
{
    public class PetModel
    {

        //Fields
        private int id;
        private string? name;
        private string? type;
        private string? colours;

        //Properties
        [DisplayName("Pet ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("Pet Name")]
        [Required(ErrorMessage = "Pet Name is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet Name must be between 3 and 50 characters")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet Type is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet Type must be between 3 and 50 character")]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        [DisplayName("Pet Colours")]
        [Required(ErrorMessage = "Pet Colours is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet Colours must be between 3 and 50 character")]
        public string Colours
        {
            get { return colours; }
            set { colours = value; }
        }
    }
}
