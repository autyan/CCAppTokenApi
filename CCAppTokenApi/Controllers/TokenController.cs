using CCAppTokenApi.Extensions;
using CCAppTokenApi.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CCAppTokenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpPost]
        public async Task<string> Post([FromBody] JwtTokenRequest request)
        {
            var client = new HttpClient
                         {
                             BaseAddress = new Uri("http://apic.weiincloud.com/CC/token")
                         };
            var dict = request.ToDictionary();
            var req    = new HttpRequestMessage(HttpMethod.Post, "http://apic.weiincloud.com/CC/token") { Content = new FormUrlEncodedContent(dict) };
            var res    = await client.SendAsync(req);
            var response = await res.Content.ReadAsStringAsync();
            return response;
        }
    }
}
