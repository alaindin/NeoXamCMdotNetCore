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
        public async Task<ActionResult> Create(Risk risk)
        {
            try
            {
                if(risk !=null && string.IsNullOrEmpty(risk.Description)){
                    await _riskService.AddAsync(risk);

                    
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Risk/Edit/5
        public async Task<ActionResult> Edit(long id)
        {
            List<Risk> risks = new List<Risk>();
            risks=await _riskService.GetAll();

            return View(risks.FirstOrDefault(d=>d.Code==id));
        }

        // POST: Risk/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(long id, Risk risk)
        {
            try
            {
                if(risk != null)
                {
                    await _riskService.Update(id, risk);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Risk/Delete/5
        public async Task<ActionResult> Delete(long id)
        {
            await _riskService.Delete(id);

            return RedirectToAction(nameof(Index));
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