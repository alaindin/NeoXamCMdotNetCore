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
    public class ActionController : Controller
    {

        ActionService _actionService;

        public ActionController(ActionService actionService)
        {
            _actionService = actionService;
        }
        // GET: Action
        public async Task<ActionResult> Index()
        {
            List<Entities.ActionModel> actions = new List<Entities.ActionModel>();
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

        public async Task<IActionResult> Create([FromForm] ActionModel action)
        {
            try
            {
               
                if (action != null )
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
        public async Task<IActionResult> Edit([FromForm] ActionModel action, int id)
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