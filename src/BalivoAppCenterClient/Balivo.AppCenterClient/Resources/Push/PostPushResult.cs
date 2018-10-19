using Newtonsoft.Json;
using System;

namespace Balivo.AppCenterClient.Resources.Push
{
    public sealed class PostPushResult
    {
        [JsonProperty("notification_id")]
        public string PushId { get; set; }
    }
}