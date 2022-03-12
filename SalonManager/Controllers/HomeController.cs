using Microsoft.AspNetCore.Mvc;

namespace SalonManager.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}