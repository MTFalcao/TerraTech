using Microsoft.AspNetCore.Mvc;
using WebSite.Services;

namespace WebSite.Controllers
{
    public class SensorController : Controller
    {
        private readonly FirebaseService _firebaseService;
        private readonly Timer _timer;

        public SensorController(FirebaseService firebaseService)
        {
            _firebaseService = firebaseService;
            _timer = new Timer(Callback, null, TimeSpan.Zero, TimeSpan.FromSeconds(20));
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
            await _firebaseService.SetTemperaturaAsync();

            // Recupera a umidade para mostrar na view
            int umidade = await _firebaseService.GetUmidadeAsync();
            ViewData["Umidade"] = umidade; //armazena sempre que o valor muda 

            return View();
        }
        private async void Callback(object state)
        {
            // Chama o método para atualizar o valor da umidade
            await _firebaseService.SetUmidadeAsync();

        }
        
    }
}
