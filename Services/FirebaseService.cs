using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Services
{
    public class FirebaseService
    {
        private readonly FirebaseClient _firebaseClient;

        // Inicializa o cliente Firebase apontando para a URL do Realtime Database.
        public FirebaseService()
        {
            _firebaseClient = new FirebaseClient("https://terratech-7eb2b-default-rtdb.firebaseio.com/");
        }

        // Método para obter os dados da umidade da planta
        public async Task<int> GetUmidadeAsync()
        {
            // Variavel que acessa os Caminhos e pega o ultimo valor
            var data = await _firebaseClient
                .Child("sensor")
                .Child("umidade")
                .Child("valor")
                .OnceSingleAsync<int>();  // Metodo usado para buscar diretamente um valor no DB

            return data;
        }
        public async Task<int> GetTemperaturaAsync()
        {
            var data = await _firebaseClient
                .Child("sensor")
                .Child("temperatura")
                .Child("valor")
                .OnceSingleAsync<int>();

            return data;
        }
    }
}

  

