using Microsoft.AspNetCore.Mvc;

namespace KitapEvi.Controllers
{
    public class YazarController : Controller
    {
        public string Index()
        {
            return "Yazar controller sınıfındaki Index metodu çalıştı";
        }

        public string YazarListesi()
        {
            return "Yazarlarımız: A,B,C";
        }
        public string YazarinKitaplari()
        {
            return "Yazarın Kitaplari: A,B,C";
        }
    }
}
