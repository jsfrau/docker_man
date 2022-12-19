using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Practice2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        [HttpGet]
        public async Task<Auto> GetCars(int id)
        {
            var client = new HttpClient();
            var responce = await client.GetAsync($"https://localhost:5001/api/Auto?autoID={id}");
            var serverData = await responce.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Auto>(serverData, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}
