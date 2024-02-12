using Microsoft.AspNetCore.Mvc;

namespace KitapEvi.Controllers
{
    public class KitapController : Controller
    {
        public JsonResult JsonCikti()
        {
            return Json(new
            {
                Id = 1,
                Seviye = "11. Sınıf",
                KitapAdi = "WEB TABANLI UYGULAMA GELİŞTİRME"
            });
        }
        // Diğer action metotlar tanımlanır.
    }
}
