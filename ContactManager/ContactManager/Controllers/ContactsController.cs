using ContactManager.Models;
using ContactManager.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace ContactManager.Controllers
{
    public class ContactsController : Controller
    {

        private ApplicationDbContext _context;


        public ContactsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Contacts
        public ActionResult Create()
        {
            var viewModel = new PersonFormViewModel
            {
                Genders = _context.Genders.ToList()
            };
            return View(viewModel);
        }
    }
}