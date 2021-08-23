using CCAppTokenApi.Extensions;
using CCAppTokenApi.Models;
using CCAppTokenApi.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CCAppTokenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpPost]
        public async Task<JwtToken> Post([FromBody] JwtTokenRequest request)
        {
            var client = new HttpClient
                         {
                             BaseAddress = new Uri("http://apic.weiincloud.com/CC/token")
                         };
            var dict = request.ToDictionary();
            var requestMessage    = new HttpRequestMessage(HttpMethod.Post, "http://apic.weiincloud.com/CC/token") { Content = new FormUrlEncodedContent(dict) };
            var response    = await client.SendAsync(requestMessage);
            var jsonStream = await response.Content.ReadAsStreamAsync();
            var tokenInfo = await JsonSerializer.DeserializeAsync<JwtToken>(jsonStream);
            return tokenInfo;
        }
    }
}
