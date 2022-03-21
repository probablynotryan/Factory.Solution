using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
      private readonly FactoryContext _db;
      public HomeController(FactoryContext db)
      {
        _db = db;
      }


      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.E = _db.Engineers.ToList();
        ViewBag.M = _db.Machines.ToList();
        return View();
      }

    }
}