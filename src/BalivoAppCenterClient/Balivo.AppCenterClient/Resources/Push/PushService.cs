using Balivo.AppCenterClient.Clients;
using System;
using System.Threading.Tasks;

namespace Balivo.AppCenterClient.Resources.Push
{
    public sealed class PushService
    {
        private static Lazy<PushService> _Lazy = new Lazy<PushService>(() => new PushService());

        public static PushService Current { get => _Lazy.Value; }

        private PushService()
        {

        }

        public Task<PostPushResult> PostPush(string ownerName, string appName, PostPushArgs args)
        {
            return AppCenterHttpClient.Current.PostAsync<PostPushResult>($"{ownerName}/{appName}/push/notifications", args);
        }
    }
}
