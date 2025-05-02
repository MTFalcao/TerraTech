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
            _firebaseClient = new FirebaseClient("https://wsplant-59c38-default-rtdb.firebaseio.com/");
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


        public async Task SetUmidadeAsync()
        {
            // Cria uma instância de Random para gerar números aleatórios
            Random random = new Random();

            int umidade = random.Next(1, 101);

            // Atualiza o valor no Firebase
            await _firebaseClient
                .Child("sensor")
                .Child("umidade")
                .PutAsync(new { valor = umidade });
        }
        public async Task SetTemperaturaAsync()
        {
            // Cria uma instância de Random para gerar números aleatórios
            Random random = new Random();

            int temperatura = random.Next(80, 80);

            // Atualiza o valor no Firebase
            await _firebaseClient
                .Child("sensor")
                .Child("temperatura")
                .PutAsync(new { valor = temperatura });

        }
    }
}

  

