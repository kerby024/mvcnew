using Microsoft.AspNetCore.Mvc;

namespace mvcnew.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Hello()
        {
            return View();
        }
    }
}