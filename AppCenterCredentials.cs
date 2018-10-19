namespace Balivo.AppCenterClient
{
    using Microsoft.Rest;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AppCenterCredentials : ServiceClientCredentials
    {
        public string Token { get; }

        public AppCenterCredentials(string token)
        {
            Token = token;
        }

        public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("X-API-Token", Token);
            return base.ProcessHttpRequestAsync(request, cancellationToken);
        }
    }
}
