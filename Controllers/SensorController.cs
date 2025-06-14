using Microsoft.AspNetCore.Mvc;
using WebSite.Services;
using System.Threading;

namespace WebSite.Controllers
{
    public class SensorController : Controller
    {
        private readonly FirebaseService _firebaseService;

        public SensorController(FirebaseService firebaseService)
        {
            _firebaseService = firebaseService;

        }

        [HttpGet]
        public async Task<IActionResult> GetValores()
        {
            var umidade = await _firebaseService.GetUmidadeAsync();
            var temperatura = await _firebaseService.GetTemperaturaAsync();

            return Json(new { umidade, temperatura });
        }

        public async Task<IActionResult> Index()
        {

            int umidade = await _firebaseService.GetUmidadeAsync();
            ViewData["Umidade"] = umidade;

            return View();
        }


    }
}
