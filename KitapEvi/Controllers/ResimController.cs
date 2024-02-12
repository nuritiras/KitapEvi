using Microsoft.AspNetCore.Mvc;

namespace KitapEvi.Controllers
{
    public class ResimController : Controller
    {
        public FileResult Index()
        {
            return File("~/img/meblogo.png", "image/png");
        }
    }
}
