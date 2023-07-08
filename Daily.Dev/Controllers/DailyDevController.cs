using Daily.Dev.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Daily.Dev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyDevController : ControllerBase
    {
        // GET: api/<DailyDevController>
        [HttpGet]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]

        public IActionResult Get()
        {
            string jsonFilePath = "./Data/articles.json";

            if (System.IO.File.Exists(jsonFilePath))
            {
                string jsonData = System.IO.File.ReadAllText(jsonFilePath);
                return Content(jsonData, "application/json");
            }

            return NotFound();
        }

        // GET api/<DailyDevController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            string jsonFilePath = "./Data/articles.json";
            if (System.IO.File.Exists(jsonFilePath))
            {
                string jsonData = System.IO.File.ReadAllText(jsonFilePath);
                var data = JsonConvert.DeserializeObject<List<JsonObjectModel>>(jsonData);

                var record = data.FirstOrDefault(x => x.id == id);

                if (record != null)
                {
                    return Ok(record);
                }
            }
            return NotFound();
        }


    }
}
