using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Serivces;

namespace NeoXamFrontNetCore.Controllers
{
    public class UserController : Controller
    {
       // private readonly IHttpContextAccessor _httpContextAccessor;
       // private ISession _session => HttpContext.Session;
        private static string sessionId = "userId";
        private static string sessionRole = "userRole";

        private UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
         
            
        }
        // GET: User
        public async Task<IActionResult> Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(sessionRole)))
            {
                return View("Login");
            }
            var listeUsers = await _userService.GetAll();
            return View(listeUsers.Where(r=>!r.IsCompleted));
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(sessionRole)))
            {
                return View("Login");
            }
            var user =await _userService.Get(id);

            return View(user);
        }

        // GET: User/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)
        {
            try
            {
                user.IsCompleted = false;
                user.Role = "Utilisateur";
                user.Adresse = new Address { Pays = "Tunisie", CodePostale = 2046, Numero = 36, Rue = "Khaled ibn walid", Ville = "Tunis" };
                // TODO: Add insert logic here
                await _userService.AddAsync(user);
                return RedirectToAction(nameof(Login));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(sessionRole)))
            {
                return View("Login");
            }

            var user = await _userService.Get(id);
            
            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, User user)
        {
            try
            {

                await _userService.Update(id,user);

                return RedirectToAction(nameof(Details),new { id=id});
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(sessionRole)))
            {
                return View("Login");
            }
            await  _userService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile photo,int id)
        {

            if (photo != null && photo.Length != 0)
            {
                var fileName = Path.GetFileName(photo.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName);
                using (var fileSrteam = new FileStream(filePath, FileMode.Create))
                {
                    await photo.CopyToAsync(fileSrteam);
                }

                User ui = await _userService.Get(id);
                ui.Photo = fileName;
                ui.Adresse = new Address { Pays = "Tunisie", CodePostale = 2046, Numero = 36, Rue = "Khaled ibn walid", Ville = "Tunis" };
             

             await   _userService.Update(id, ui);
            }
            else
            {

            } 
            return RedirectToAction(nameof(Details),new { id});
        }
        public async Task<IActionResult> Login()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(sessionRole)))
            {
                return View();
            }
            else
            {
                return RedirectToAction(nameof(Details), new { id = HttpContext.Session.GetInt32(sessionId) });
            }
           
        }

        [HttpPost]

        public async Task<IActionResult> Login(string email, string password)
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString(sessionRole)))
            {
                return RedirectToAction(nameof(Details), new { id = HttpContext.Session.GetInt32(sessionId) });
            }
            try
            {
                User user = await _userService.Login(email, password);
                if (user == null)
                {
                    return View();
                }
                else
                {
                    HttpContext.Session.SetString(sessionRole, user.Role);
                    HttpContext.Session.SetInt32(sessionId, (int)user.Id);
                    return RedirectToAction(nameof(Details),new { id = HttpContext.Session.GetInt32(sessionId) });
                   
                }
            }
            catch
            {

                return View();
            }


          
        }
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.SetString(sessionRole, null);
            HttpContext.Session.SetInt32(sessionId, 0);

            return RedirectToAction(nameof(Login));
        }
    }
}