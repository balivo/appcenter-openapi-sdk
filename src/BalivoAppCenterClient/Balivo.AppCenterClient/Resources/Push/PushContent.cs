using Newtonsoft.Json;

namespace Balivo.AppCenterClient.Resources.Push
{
    public sealed class PushContent
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
        //public Custom_Data custom_data { get; set; }
    }
}
