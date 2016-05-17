using Newtonsoft.Json;

namespace PinSharp.Models.Images
{
    public class UserImages
    {
        [JsonProperty("60x60")]
        public ImageInfo W60 { get; set; }

        // TODO: not sure if those are still returned by pinterest api.
        [JsonProperty("110x")]
        public ImageInfo W110 { get; set; }

        [JsonProperty("165x")]
        public ImageInfo W165 { get; set; }

        [JsonProperty("280x")]
        public ImageInfo W280 { get; set; }
    }
}
