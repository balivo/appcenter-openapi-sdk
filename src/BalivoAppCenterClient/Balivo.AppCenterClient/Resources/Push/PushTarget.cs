using Newtonsoft.Json;

namespace Balivo.AppCenterClient.Resources.Push
{
    public sealed class PushTarget
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
