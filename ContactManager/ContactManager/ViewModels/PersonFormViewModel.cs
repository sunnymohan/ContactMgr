using ContactManager.Models;

using System.Collections.Generic;

namespace ContactManager.ViewModels
{
    public class PersonFormViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }

        public byte GenderId { get; set; }

        public IEnumerable<Gender> Genders { get; set; }

}

  
}