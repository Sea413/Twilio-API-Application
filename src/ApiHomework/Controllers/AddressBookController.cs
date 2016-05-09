using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ApiHomework.Models;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using System.Security.Claims;


namespace ApiHomework.Controllers
{
    [Authorize]
    public class AddressBookController : Controller
    {
        private readonly ApiHomeworkDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AddressBookController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApiHomeworkDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Contacts.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Contact contact)
        {
            var currentUser = await _userManager.FindByIdAsync(User.GetUserId());
            contact.ApplicationUser = currentUser;
            _db.Contacts.Add(contact);
            _db.SaveChanges();
            return RedirectToAction("Setup");
        }
    }
}
