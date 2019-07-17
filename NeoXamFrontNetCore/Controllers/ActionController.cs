using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeoXamFrontNetCore.Serivces;

namespace NeoXamFrontNetCore.Controllers
{
    public class ActionController : Controller
    {

        ActionService _actionService;

        public ActionController(ActionService actionService)
        {
            _actionService = actionService;
        } 
        // GET: Action
        public  async Task<ActionResult> Index()
        {
            List<Entities.Action> actions = new List<Entities.Action>();
            actions = await _actionService.GetAll();
            return View(actions);
        }
        

        // GET: Action/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Action/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Action/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Entities.Action action)
        {
            try
            {
                if (action != null && !string.IsNullOrEmpty(action.Label))
                    await _actionService.AddAsync(action);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Action/Edit/5
        public ActionResult Edit(int id)
        {
            var action = _actionService.Get(id).Result;
            return View(action);
        }

        // POST: Action/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Entities.Action action)
        {
            try
            {

              await  _actionService.Update(id,action);
               return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Action/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
           await _actionService.Delete(id);

            return RedirectToAction(nameof(Index));
        }

     
    }
}