using System.ComponentModel;
using System.Text.Json.Serialization;

namespace CCAppTokenApi.Requests
{
    /// <summary>
    /// 服务器Token请求数据
    /// </summary>
    public class JwtTokenRequest
    {
        /// <summary>
        /// 请求加密的类型
        /// </summary>
        [Description("grant_type")]
        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// 请求的客户端标识
        /// </summary>
        [Description("client_id")]
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 请求的密码
        /// </summary>
        [Description("client_secret")]
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }
    }
}
