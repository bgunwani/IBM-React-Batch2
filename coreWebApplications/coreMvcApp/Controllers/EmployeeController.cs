using coreMvcApp.Models;
using coreMvcApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var employees = EmployeeRepository.GetAll();
            return View(employees);
        }
        public IActionResult Details(int id)
        {
            var employee = EmployeeRepository.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            EmployeeRepository.Add(employee);
            return RedirectToAction("Index");
        }
    }
}
