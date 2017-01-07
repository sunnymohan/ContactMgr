using System;

namespace ContactManager.Models
{
    public class Person
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }


        public Gender Gender { get; set; }

        public byte GenderId { get; set; }



    }
}