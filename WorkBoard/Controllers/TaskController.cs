using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkBoard.Models;
using Microsoft.EntityFrameworkCore;
using Task = WorkBoard.Models.Task; // ???

namespace WorkBoard.Controllers
{
    public class TaskController : Controller
    {
        private readonly TasksContext db; // readonly - raz można odczytać

        public TaskController(TasksContext context)
        {
            db = context; // db -> uchwyt do bazy danych
        }
        public IActionResult Index()
        {
            // return View("Index", db.Tasks.OrderByDescending(t => t.task_name));
            return View("Index", db.Tasks.OrderBy(t => t.team).ThenBy(t => t.task_name));
        }

        public async Task<IActionResult> FilteredByName(string searchName)
        {
            return View(await db.Tasks.Where(t => t.task_name.Contains(searchName)).ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Task newTask)
        {
            if (ModelState.IsValid)
            {
                db.Tasks.Add(newTask);
                db.SaveChanges();

                TempData["message"] = "Utworzono nowy task: " + newTask.task_name; // istnieje do zakończenia żądania, dłużej niż ViewData
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            try
            {
                Task task = db.Tasks.Find(id);
                if (task == null)
                {
                    Response.StatusCode = 404;
                    return View("IdNotFound", id);
                }
                return View(task);
            }
            catch (Exception ex)
            {
                // ???
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            
            if(ModelState.IsValid)
            {
                Task task = db.Tasks.Find(id);
                if (task == null)
                {
                    return NotFound();
                }
                db.Tasks.Remove(task);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
            
        }

        public IActionResult Edit(int id)
        {
            Task task = db.Tasks.Find(id);
            if(task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        [HttpPost]
        public IActionResult Edit([Bind(include:"task_id, ApplicationUserId, task_name, status, description, team, creation_date, deadline_date, modification_date")] Task task)
        {
            if(ModelState.IsValid)
            {
                db.Tasks.Update(task);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
