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
    public class DepartementController : Controller
    {
        DepartementService _departementSerivce;

        public DepartementController(DepartementService departementSerivce)
        {
            _departementSerivce = departementSerivce;
        }
        // GET: Departement
        public async Task<ActionResult> Index()
        {
            List<Departement> departements = new List<Departement>();
            departements = await _departementSerivce.GetAll();
            return View(departements);
        }

        // GET: Departement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Departement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departement/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Departement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Departement/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: Departement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Departement/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}