using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Balivo.AppCenterClient.Clients
{
    public sealed class AppCenterHttpClient
    {
        private static Lazy<AppCenterHttpClient> _Lazy = new Lazy<AppCenterHttpClient>(() => new AppCenterHttpClient());

        public static AppCenterHttpClient Current { get => _Lazy.Value; }

        private AppCenterHttpClient()
        {
            _HttpClient = new HttpClient
            {
                BaseAddress = new Uri($"https://api.appcenter.ms/v0.1/apps/")
            };
        }

        private readonly HttpClient _HttpClient;

        public void Authorize(string token)
        {
            _HttpClient.DefaultRequestHeaders.Add("X-API-Token", token);
        }

        #region [ POST ]

        private async Task<TResult> PostAsync<TResult>(string requestUri, HttpContent httpContent)
        {
            using (var response = await _HttpClient.PostAsync(requestUri, httpContent))
            {
                if (!response.IsSuccessStatusCode)
                    throw new NotImplementedException("Não estamos interpretando status de erros... AINDA...");

                var responseContent = await response.Content.ReadAsStringAsync();

                if (responseContent is null)
                    throw new InvalidOperationException(); // TODO: MELHORAR MENSAGEM DE ERRO...

                return string.IsNullOrWhiteSpace(responseContent) ?
                    Activator.CreateInstance<TResult>() : JsonConvert.DeserializeObject<TResult>(responseContent);
            }
        }

        internal Task<TResult> PostAsync<TResult>(string requestUri, object content)
            => PostAsync<TResult>(requestUri, new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json"));

        #endregion
    }
}
