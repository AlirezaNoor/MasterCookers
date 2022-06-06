using Mc.Query;
using MC.Presentations.MVCCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Mc.ApplicationContracts.Comment;

namespace MC.Presentations.MVCCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IQuery query, ICommentApplction applction)
        {
            _logger = logger;
            _query = query;
            _applction = applction;
        }

        private readonly IQuery _query;
        private readonly ICommentApplction _applction;
        public IActionResult Index()
        {
           var model= _query.list().ToList();
            return View(model);
        }

        public IActionResult Details(long id)
        {
            var model = new DtailsModels();
            model.Dtails=_query.GetById(id);
            model.Comment = _applction.list().ToList();
            return View(model);
        }

        public IActionResult Createcomment(DtailsModels comend)
        {
            _applction.create(comend.create);
            return RedirectToAction("Details",new {id=comend.create.Cookesid});
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