using Microsoft.AspNetCore.Mvc;
using FirstServiceReference;
using ProductServiceReference;

namespace WebApp.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private FirstServiceClient firstServiceClient = new FirstServiceClient();
        private ProductServiceClient productServiceClient = new ProductServiceClient();


        [Route("")]
        [Route("/index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.result1 = firstServiceClient.WelcomeAsync().Result;
            ViewBag.result2 = firstServiceClient.HiAsync("Veli Yavuz").Result;
            ViewBag.result3 = firstServiceClient.SumAsync(14, 7).Result;


            ViewBag.product = productServiceClient.GetOneAsync().Result;
            ViewBag.products = productServiceClient.GetAllAsync().Result;
            return View();
        }

    }
}
