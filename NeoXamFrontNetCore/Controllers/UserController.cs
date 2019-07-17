using System;
using System.Collections.Generic;
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
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        private UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {

            var user = _userService.Get(id);

            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                user.IsCompleted = false;
                user.Role = "Utilisateur";
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User user)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

       
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login(string email, string password)
        {

            try
            {
                User user = await _userService.Login(email, password);
                if (user == null)
                {
                    return View();
                }
                else
                {
                    switch (user.Role)
                    {
                        case "":
                            break;
                        case "a":
                            break;
                        case "b":
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {

                return View();
            }


            return View();
        }
    }
}