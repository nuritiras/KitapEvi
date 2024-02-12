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

        public string Liste(int id)
        {
            return $"Parametreden gelen değer: {id}";
        }
        // Diğer action metotlar tanımlanır.
    }
}
