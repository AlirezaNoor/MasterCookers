using Mc.ApplicationContracts.CookApplication;
using Mc.ApplicationContracts.CookesCategory;
using MC.Presentations.MVCCore.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MC.Presentations.MVCCore.Areas.Admin.Controllers
{
    [Area("admin")]
    public class Admistrator : Controller
    {
        private readonly ICookesCategoryApplication _categoryApplication;
        private readonly ICookesAplications _aplications;

        public Admistrator(ICookesCategoryApplication categoryApplication, ICookesAplications aplications)
        {
            _categoryApplication = categoryApplication;
            _aplications = aplications;
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

        [HttpPost]
        public IActionResult delete(long id)
        {
            _categoryApplication.Deactive(id);
            return RedirectToAction("CookeCategory");
        }


        [HttpPost]
        public IActionResult active(long id)
        {
            _categoryApplication.Active(id);
            return RedirectToAction("CookeCategory");
        }

        public IActionResult CookesList()
        {
          

            return View(_aplications.list());
        }
        [HttpGet]
        public IActionResult CookesAdd()
        {
            var model = new CookesDteails();
            model.listed = _categoryApplication.List().Select(x => new SelectListItem(x.Title, x.Id.ToString()))
                .ToList();              
            return View(model);
        }
        [HttpPost]
        public IActionResult CookesAdd(CookesDteails command)
        {
            _aplications.Createcookes(command.createcookes);
            return RedirectToAction("CookesList");
        }

    }
}
