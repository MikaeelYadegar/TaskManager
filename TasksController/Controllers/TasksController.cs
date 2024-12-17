using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasksController.Models;
namespace TasksController.Controllers
{
    public class TasksController : Controller
    {
        // GET: Tasks
        public ActionResult Index()
        {
            var tasks = Session["Tasks"] as List<Task>;
            if (tasks == null)
            {
                tasks = new List<Task>();
            }
            return View(tasks);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Task task)
        {
            task.CreatedAt = DateTime.Now;
            var tasks = Session["Tasks"] as List<Task>;
            if (tasks == null)
            {
                tasks = new List<Task>();
            }
            tasks.Add(task);
            Session["Tasks"] = tasks;
            return RedirectToAction("Index");
        }

        public ActionResult CreatePer()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePer(Task task)
        {
            task.CreatedAt = DateTime.Now;
            var tasks = Session["Tasks"] as List<Task>;
            if (tasks == null)
            {
                tasks = new List<Task>();
            }
            tasks.Add(task);
            Session["Tasks"] = tasks;
            return RedirectToAction("Index");
        }




    }
}