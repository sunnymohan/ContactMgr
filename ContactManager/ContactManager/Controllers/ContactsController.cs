﻿using ContactManager.Models;
using ContactManager.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace ContactManager.Controllers
{
    public class ContactsController : Controller
    {

        private readonly ApplicationDbContext _context;


        public ContactsController()
        {
            _context = new ApplicationDbContext();
        }


        [Authorize]
        // GET: Contacts
        public ActionResult Create()
        {
            var viewModel = new PersonFormViewModel
            {
                Genders = _context.Genders.ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(PersonFormViewModel viewModel)
        {
            //var gender = _context.Genders.Single(g => g.Id == viewModel.GenderId);

            if (!ModelState.IsValid)
            {
                viewModel.Genders = _context.Genders.ToList();
                return View("Create", viewModel);
            }

            var contact = new Person
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                DateOfBirth = viewModel.GetDateOfBirth(),
                GenderId = viewModel.GenderId
            };

            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}