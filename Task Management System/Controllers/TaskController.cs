using Microsoft.AspNetCore.Mvc;
using Task_Management_System.Models;

namespace Task_Management_System.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddTaskViewModel viewModel)
        {
            return View();
        }
    }
}
