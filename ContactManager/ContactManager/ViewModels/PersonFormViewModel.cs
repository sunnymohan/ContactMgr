using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.ViewModels
{
    public class PersonFormViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [FutureDate]
        public string DateOfBirth { get; set; }

        public DateTime GetDateOfBirth()
        {
            return DateTime.Parse(string.Format("{0}", DateOfBirth));
        }

        [Required]
        public byte GenderId { get; set; }

        public IEnumerable<Gender> Genders { get; set; }

    }


}