using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AcmeActivity.Data;
using AcmeActivityManager.Application.ViewModels;

namespace AcmeActivity.Controllers
{
    public class SignUpController : Controller
    {
        private readonly ActivityDbContext _context;

        public SignUpController(ActivityDbContext context)
        {
            _context = context;
        }

        // GET: SignUp
        public async Task<IActionResult> Index()
        {
            return View(await _context.SignUpViewModel.ToListAsync());
        }

        // GET: SignUp/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SignUp/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SignUpViewModel signUpViewModel)
        {
            if (!ModelState.IsValid) return View(signUpViewModel);


            signUpViewModel.Id = Guid.NewGuid();
            _context.Add(signUpViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            
        }

        private bool SignUpViewModelExists(Guid id)
        {
            return _context.SignUpViewModel.Any(e => e.Id == id);
        }
    }
}
