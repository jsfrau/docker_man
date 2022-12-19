using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Formatting;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practice
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        [HttpPut]
        public Auto Create(Auto auto)
        {
            Storage.AutoStorage.Create(auto);
            return auto;
        }
        [HttpGet]
        public Auto Read(int autoID)
        {
            return Storage.AutoStorage.Read(autoID);
        }
        [HttpPost]
        public Auto Update(int autoID, Auto newAuto)
        {
            return Storage.AutoStorage.Update(autoID, newAuto);
        }
        [HttpDelete]
        public bool Delete(int autoID)
        {
            return Storage.AutoStorage.Delete(autoID);
        }

    }
    }
