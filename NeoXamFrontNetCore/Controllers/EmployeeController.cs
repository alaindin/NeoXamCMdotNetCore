using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Serivces;


namespace NeoXamFrontNetCore.Controllers
{
    public class EmployeeController : Controller
    {

        private EmployeeService _empservice;
        public EmployeeController(EmployeeService empservice)
        {
            this._empservice = empservice;

        }
        // GET: Employee
        public ActionResult Index()
        {

            var test = _empservice.GetAll().Result;
            return View(test);
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var emp =await _empservice.Get(id);
            return View(emp);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee emp)
        {
            try
            {
                if (emp != null)
                {

                    await _empservice.AddAsync(emp);
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

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee emp)
        {
            try
            {
                if (emp != null)
                {
                    await _empservice.Update(id, emp);
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

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(long id)
        {
            try
            {

                await _empservice.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


    }
}