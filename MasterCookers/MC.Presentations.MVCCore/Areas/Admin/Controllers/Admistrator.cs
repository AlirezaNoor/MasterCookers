using Mc.ApplicationContracts.CookesCategory;
using MC.Presentations.MVCCore.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace MC.Presentations.MVCCore.Areas.Admin.Controllers
{
    [Area("admin")]
    public class Admistrator : Controller
    {
        private readonly ICookesCategoryApplication _categoryApplication;

        public Admistrator(ICookesCategoryApplication categoryApplication)
        {
            _categoryApplication = categoryApplication;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CookeCategory()
        {
            var modeList = _categoryApplication.List();
            return View(modeList);
        }
        [HttpGet]
        public IActionResult CookesCategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CookesCategoryAdd(CreateCategory comand)
        {
            _categoryApplication.CreateCategory(comand);
            return RedirectToAction("CookeCategory");
        }
        [HttpGet]
        public IActionResult CookesCategoryEdtided(long id)
        {

            var n = new EditedViewmodel();
            n.editcategory = _categoryApplication.filled(id);
            return View(n);
        }

        [HttpPost]
        public IActionResult CookesCategoryEdtided(EditedViewmodel command)
        {
            _categoryApplication.EditedCategory(command.editcategory);
           return  RedirectToAction("CookeCategory");

        }

    }
}
