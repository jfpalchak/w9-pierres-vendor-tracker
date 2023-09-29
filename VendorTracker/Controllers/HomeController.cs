using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class HomeController : Controller
  {
    // Get project's splash page
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}