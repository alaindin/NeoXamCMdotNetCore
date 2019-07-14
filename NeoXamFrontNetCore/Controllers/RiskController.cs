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
    public class RiskController : Controller
    {
        private RiskService _riskService;
        public RiskController(RiskService riskService)
        {
            _riskService = riskService;
        }
        // GET: Risk
        public async Task<ActionResult> Index()
        {
            List<Risk> risks = new List<Risk>();
            risks = await _riskService.GetAll();


            return View(risks);
        }

        // GET: Risk/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Risk/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Risk/Create
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

        // GET: Risk/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Risk/Edit/5
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

        // GET: Risk/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Risk/Delete/5
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