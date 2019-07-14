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
        public async Task<IActionResult> Create(Departement departement)
        {
            try
            {
               if (departement != null && !string.IsNullOrEmpty( departement.Libelle))
                {
                   
                   await _departementSerivce.AddAsync(departement);
                }
                else
                {
                    return View();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Departement/Edit/5
        public async  Task<IActionResult> Edit(int id)
        {
            List<Departement> departements = new List<Departement>();
            departements = await _departementSerivce.GetAll();
            return View(departements.FirstOrDefault(d=>d.Code==id) );
        }

        // POST: Departement/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Departement departement)
        {
            try
            {
                if (departement != null)
                {
                    await _departementSerivce.Update(id, departement);
                }
                else
                {
                    return View();
                }
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

   
        
    
        public async Task<IActionResult> Delete(long id)
        {
            try
            {

                await _departementSerivce.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}