using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserApi.Data;

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ApplicationDbContext _applicationDbContext;
        public ValuesController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var userInfo = _applicationDbContext.appUsers.FirstOrDefault();
            return new JsonResult(userInfo);
        }
        [HttpGet("{s}")]
        public string Get(string s)
        {
            return s;
        }
    }
}
