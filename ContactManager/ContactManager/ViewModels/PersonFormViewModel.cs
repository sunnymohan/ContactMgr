using ContactManager.Models;
using System;
using System.Collections.Generic;

namespace ContactManager.ViewModels
{
    public class PersonFormViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set;}

        public byte GenderId { get; set; }

        public IEnumerable<Gender> Genders { get; set; }

    }


}