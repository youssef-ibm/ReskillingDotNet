using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GererEmployes.Models;
using GererEmployes.Models.Repositories;
using GererEmployes.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GererEmployes.Controllers
{
    public class EmployeController : Controller
    {
        private readonly IEmployestoreRepository<Employe> employeRepository;

        public EmployeController(IEmployestoreRepository<Employe> employe)
        {
            employeRepository = employe;
        }

        [Route("")]
        [Route("Employe/Index")]
        [HttpGet]
        [Route("/Employe/Create")]
        // GET: Employe
        public ActionResult Index()
        {
            //var employes = employeRepository.list();
            //return View(employes);
            var model = new EmployeViewModel
            {
                Employes = employeRepository.list().ToList()
            };
            return View(model);
        }

        // GET: Employe/Details/5
        public ActionResult Details(int id)
        {
            var emplye = employeRepository.Find(id);
            return View(emplye);
        }

        // GET: Employe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employe/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Employe/Create")]
        public ActionResult Index(Employe employe)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add insert logic here
                    employeRepository.Add(employe);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            else 
            {
                ViewBag.Message = "Veuillez remplir correctement les champs";
                //ModelState.AddModelError("test", "You hav ti fill....");
                //return View(employe);
                var model = new EmployeViewModel
                {
                    Employes = employeRepository.list().ToList()
                };
                //return RedirectToAction(nameof(Index),model);
                return View(model);
            }
        }

        // GET: Employe/Edit/5
        public ActionResult Edit(int id)
        {
            var emplye = employeRepository.Find(id);
            return View(emplye);
        }

        // POST: Employe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employe employe)
        {
            try
            {
                // TODO: Add update logic here
                employeRepository.Update(employe);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employe/Delete/5
        public ActionResult Delete(int id)
        {
            var employe = employeRepository.Find(id);
            return View(employe);
        }

        // POST: Employe/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employe employe)
        {
            try
            {
                // TODO: Add delete logic here
                employeRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}