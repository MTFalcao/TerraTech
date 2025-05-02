using System.Diagnostics;
using Firebase.Auth;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        FirebaseAuthProvider _firebaseAuth;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //Instanciando a chave API, FirebaseAuthProvider é a instancia de autenticação do Firebase Authentication.
            _firebaseAuth = new FirebaseAuthProvider(new FirebaseConfig("\r\nAIzaSyD26u7lIJNdK_7KlfzDdftbINE-eqm4b9M"));
        }

        public IActionResult Index()
        {
            // armazena um token unico de autenticação 
            var accessToken = HttpContext.Session.GetString("AcessToken");

            // Verifica se o token de acesso está presente
            if (string.IsNullOrEmpty(accessToken))
            {
                // Se não houver token, redireciona para a página de login
                //return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult RegisterUser()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(LoginModel vm)
        {
            try
            {
                //Criar o usuario
                await _firebaseAuth.CreateUserWithEmailAndPasswordAsync(vm.Email, vm.Password);

                //Envia os dados para o firebase e retorna um token de autenticação
                var firebaseLink = await _firebaseAuth.SignInWithEmailAndPasswordAsync(vm.Email, vm.Password);
                // extrai o token de autenticação retornado pelo Firebase após um login bem-sucedido.
                string acessToken = firebaseLink.FirebaseToken;

                if (firebaseLink != null)
                {
                    HttpContext.Session.SetString("AcessToken", acessToken);
                    return RedirectToAction("Login");
                }
                else
                {
                    return View(vm);
                }
            }
           
            catch (FirebaseAuthException ex)
            {
                // Caso o Firebase retorne uma exceção, verificamos a resposta.
                Console.WriteLine("Erro do Firebase: " + (ex.ResponseData ?? "Resposta nula"));

                if (!string.IsNullOrEmpty(ex.ResponseData))
                {
                    try
                    {
                        var firebaseEx = JsonConvert.DeserializeObject<ErrorModel>(ex.ResponseData);
                        string errorMessage = string.IsNullOrEmpty(firebaseEx?.Message)
                            ? "Erro desconhecido ao registrar usuário."
                            : firebaseEx.Message;

                       
                        if (errorMessage.Contains("INVALID_PASSWORD"))
                        {
                            errorMessage = "A senha inserida está incorreta.";
                        }

                        ModelState.AddModelError(string.Empty, errorMessage);
                    }
                    catch (Exception jsonEx)
                    {
                        Console.WriteLine("Erro ao desserializar JSON: " + jsonEx.Message);
                        ModelState.AddModelError(string.Empty, "Erro ao processar resposta do Firebase.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Erro desconhecido ao registrar usuário.");
                }

                return View(vm);
            }
        }

        
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel vm)
        {
             // Verifica se o usuário já está logado
            var accessToken = HttpContext.Session.GetString("AcessToken");

            // Se estiver logado, redireciona para a página inicial
            if (!string.IsNullOrEmpty(accessToken))
            {
                return RedirectToAction("Index");
            }
            try
            {
                // Tentar autenticar com e-mail e senha
                var firebaseLink = await _firebaseAuth.SignInWithEmailAndPasswordAsync(vm.Email, vm.Password);
                string acessToken = firebaseLink.FirebaseToken;

                if (firebaseLink != null)
                {
                    // Armazenando o token na sessão para manter o usuário logado
                    HttpContext.Session.SetString("AcessToken", acessToken);
                    return RedirectToAction("Index"); // Redirecionar para a página inicial
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Falha na autenticação.");
                    return View(vm);
                }
            }
            catch (FirebaseAuthException ex)
            {
                Console.WriteLine("Erro do Firebase: " + (ex.ResponseData ?? "Resposta nula"));
                if (!string.IsNullOrEmpty(ex.ResponseData))
                {
                    try
                    {
                        var firebaseEx = JsonConvert.DeserializeObject<ErrorModel>(ex.ResponseData);
                        ModelState.AddModelError(string.Empty, firebaseEx?.Message ?? "Erro desconhecido.");
                    }
                    catch (Exception jsonEx)
                    {
                        Console.WriteLine("Erro ao desserializar JSON: " + jsonEx.Message);
                        ModelState.AddModelError(string.Empty, "Erro ao processar resposta do Firebase.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Erro desconhecido ao tentar fazer login.");
                }
                return View(vm);
            }
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

        public IActionResult About()
        {
            return View();
        }
    }
}
