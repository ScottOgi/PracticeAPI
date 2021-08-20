using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI
{
    [Route("Play/")]
    public class PlayController : Controller
    {
        [HttpGet, Route("GetMessage")]
        public IActionResult GetSuccessMessage()
        {
            return Ok("API Accessed!");
        }
    }
}
