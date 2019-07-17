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
    public class EvaluationController : Controller
    {

        EvaluationService _evaluationService;
        EmployeeService _employeeService;

        public EvaluationController(EvaluationService evaluationService, EmployeeService employeeService)
        {
            _evaluationService = evaluationService;
            _employeeService = employeeService;
        }

        // GET: Evaluation
        public async Task<ActionResult> Index()
        {
            List<Evaluation> evaluations = new List<Evaluation>();
            evaluations = await _evaluationService.GetAll();
            List<Evaluation> eval1 = new List<Evaluation>();
            foreach
                (var v in evaluations) {
                var e = new Evaluation() ;
                e = v;
                e.employee = await _employeeService.Get(v.Id.EmpId);

            }
            return View(evaluations);
        }

        // GET: Evaluation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evaluation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Evaluation evaluation)
        {
            try
            {
                if (evaluation != null)
                { await _evaluationService.AddAsync(evaluation); }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Evaluation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Evaluation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(long id, Evaluation evaluation)
        {
            try
            {
                if (evaluation != null)
                {
                    await _evaluationService.Update(id, evaluation);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Evaluation/Delete/5
        public async Task<ActionResult> Delete(long id)
        {
            await _evaluationService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: Evaluation/Delete/5
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