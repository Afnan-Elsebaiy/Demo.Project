using Demo.BLL.Models;
using Demo.BLL.Service;
using Demo.DAL.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentService _Department = new DepartmentService();


        public async Task<IActionResult> Index()
        {
            var dep = await _Department.GetAsync(x => x.Name != null);
            return View(dep);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(DepartmentDTO departmentDto)
        {   
                await _Department.CreateAsync(departmentDto);
                return RedirectToAction("Index");
        }



        public async Task<IActionResult> Details(int id)
        {
            var department = await _Department.GetByIdAsync(a => a.Id == id);
            return View(department);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var department = await _Department.GetByIdAsync(a => a.Id == id);
            return View(department);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(DepartmentDTO departmentDto)
        {
            await _Department.UpdateAsync(departmentDto);
            return RedirectToAction("Index");
        }

        // Delete
        public async Task<IActionResult> Delete(int id)
        {
            var department = await _Department.GetByIdAsync(a => a.Id == id);
            return View(department);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DepartmentDTO department)
        {
            await _Department.DeleteAsync(department);
            return RedirectToAction("Index");
        }
    }
}
