using Microsoft.AspNetCore.Mvc;

namespace KitapEvi.Controllers
{
    public class KitapController : Controller
    {
        public string Index()
        {
            return "Kitap controller sınıfındaki Index metodu çalıştı";
        }
        // Diğer action metotlar tanımlanır.
    }
}
