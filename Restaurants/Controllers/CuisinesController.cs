using Microsoft.AspNetCore.Mvc;

namespace Restaurants.Controllers
{
    public class CuisinesController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}