using System.Text.Json.Serialization;

namespace CCAppTokenApi.Models
{
    public class JwtToken
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("expires_in")]
        public uint ExpiresIn { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonPropertyName("as:client_id")]
        public string AsClientId { get; set; }

        [JsonPropertyName(".issued")]
        public string Issued { get; set; }

        [JsonPropertyName(".expires")]
        public string Expires { get; set; }
    }
}
