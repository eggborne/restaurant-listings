using Microsoft.AspNetCore.Mvc;

namespace Restaurant_Listing.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.PageTitle = "Restaurant Listings!";
      return View();
    }
  
  }
}