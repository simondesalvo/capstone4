using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using capstone4.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace capstone4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        

        private readonly ToDoDBContext _context;

        public HomeController(ToDoDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //add [Authorize]

        [Authorize]
        [HttpGet]
        public IActionResult AddTask()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddTask(ToDoList thing)
        {
            if (ModelState.IsValid)
            {
                string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                thing.UserId = id;
                _context.ToDoList.Add(thing);
                _context.SaveChanges();

            }
            return RedirectToAction("ToDoItemList");
        }

        [Authorize]
        public IActionResult ToDoItemList()
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            List<ToDoList> taskList = _context.ToDoList.Where(x => x.UserId == id).ToList();
            return View(taskList);
        }

        [Authorize]
        public IActionResult UpdateToDo(int id)
        {
            ToDoList updateThis = _context.ToDoList.Find(id);
            if (updateThis == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(updateThis);
            }
            
        }

        [Authorize]
        public IActionResult SaveChanges(ToDoList updatedItem)
        {
            ToDoList originalItem = _context.ToDoList.Find(updatedItem.ToDoId);

            originalItem.ToDoDesc = updatedItem.ToDoDesc;
            originalItem.ToDoDue = updatedItem.ToDoDue;
            originalItem.ToDoComplete = updatedItem.ToDoComplete;

            _context.Entry(originalItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.Update(originalItem);
            _context.SaveChanges();

            return RedirectToAction("ToDoItemList");
        }

        [Authorize]
        public IActionResult DeleteToDo(int id)
        {
            var deleteItem = _context.ToDoList.Find(id);
            if (deleteItem != null)
            {
                _context.ToDoList.Remove(deleteItem);
                _context.SaveChanges();
            }
            else
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("ToDoItemList");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
