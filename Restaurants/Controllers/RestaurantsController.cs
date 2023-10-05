using Microsoft.AspNetCore.Mvc;

namespace Restaurants.Controllers
{
    public class RestaurantsController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}