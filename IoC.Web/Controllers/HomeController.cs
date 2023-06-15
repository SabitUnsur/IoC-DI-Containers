using IoC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IoC.Web.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly ITransientDateService _transientDateService;

        //private readonly ISingletonDateService _singletonDateService;
        //private readonly IScopeDateService _scopedDateService;

        public HomeController(ITransientDateService transientDateService)
        {
            _transientDateService = transientDateService;
        }


        /*public HomeController(IScopeDateService scopedDateService)
        {
            _scopedDateService = scopedDateService;
        }*/

        /*public HomeController(ISingletonDateService singletonDateService)
        {
            _singletonDateService = singletonDateService;
        }*/

        public IActionResult Index([FromServices]ITransientDateService transientDateService2)
        {
            /*ViewBag.time1=_singletonDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2=singletonDateService2.GetDateTime.TimeOfDay.ToString(); //Metod üzerinden  erişim,aynı nesne örneğini kullandı.
            */

            /* ViewBag.time1 = _scopedDateService.GetDateTime.TimeOfDay.ToString(); //Aynı request olduğu için aynı nesne örneği,sayfa yenilenince yeniden üretilir.
             ViewBag.time2 = scopedDateService2.GetDateTime.TimeOfDay.ToString();
            */

            ViewBag.time1 = _transientDateService.GetDateTime.TimeOfDay.ToString(); // Bu sefer her bir enjekte için farklı nesne örneği oluştu.
            ViewBag.time2 = transientDateService2.GetDateTime.TimeOfDay.ToString();

            return View();
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