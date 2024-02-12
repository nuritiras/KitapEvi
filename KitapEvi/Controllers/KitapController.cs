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

        [Route("Kitap/Listeler/{id}/{ad}")]
        public string Listeler(int id, string ad)
        {
            return $"Parametreden gelen id={id}, ad={ad}";
        }
        // Diğer action metotlar tanımlanır.
    }
}
