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
        public async Task<ActionResult> Index()
        {
            List<Employee> employees = new List<Employee>();
            employees =await _empservice.GetAll();
            return View(employees);
        }

        // GET: Employee/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            List<Employee> emps = new List<Employee>();
            emps = await _empservice.GetAll();
            return View(emps.FirstOrDefault(d => d.Id == id));
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
                    emp.Adresse = new Address() { CodePostale = 2046};
                    
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

        // GET: Employee/Edit/{id}
        public  async Task<IActionResult>  Edit(int id)
        {

            List<Employee> emps = new List<Employee>();
            emps = await _empservice.GetAll();
            return View(emps.FirstOrDefault(d => d.Id == id));
            //Employee emp = await _empservice.Get(id);

            //return View(emp);
        }

        // POST: Employee/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee emp)
        {
            try
            {
                if (emp != null)
                {
                    emp.Adresse = new Address() { CodePostale = 2046 };
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

        // GET: Employee/Delete/{id}
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