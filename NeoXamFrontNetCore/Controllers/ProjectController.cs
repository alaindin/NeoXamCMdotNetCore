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
    public class ProjectController : Controller
    {
        ProjectService _projectService;
        public ProjectController(ProjectService projectService)
        {
            _projectService = projectService;

        }
        // GET: Project
        public async Task<ActionResult> Index()
        {
            List<Project> projs = new List<Project>();
            projs = await _projectService.GetAll();
            return View(projs);
        }

        // GET: Project/Details/{id}
        public async Task<ActionResult> Details(int id)
        {
            Project projet = await _projectService.Get(id);
            return View(projet);
                
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Project projet)
        {
            try
            {
                if (projet != null)
                {

                    await _projectService.AddAsync(projet);
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

        // GET: Project/Edit/{id}
        public async Task<ActionResult> Edit(int id)
        {
            List<Project> projs = new List<Project>();
            projs = await _projectService.GetAll();
            return View(projs.FirstOrDefault(d => d.Id == id));
        }

        // POST: Project/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Project projet)
        {
            try
            {
                if (projet != null)
                {
                    await _projectService.Update(id, projet);
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

        // GET: Project/Delete/{id}
        public async Task<ActionResult> Delete(long id)
        {
            
            Project proj = await _projectService.Get(id);
            return View(proj);
        }

        // POST: Project/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(long id, Project projet)
        {
            try
            {

                await _projectService.Delete(id);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}