using Newtonsoft.Json;

namespace Balivo.AppCenterClient.Resources.Push
{
    public sealed class PostPushArgs
    {
        [JsonProperty("notification_target")]
        public PushTarget Target { get; set; }

        [JsonProperty("notification_content")]
        public PushContent Content { get; set; }
    }
}
