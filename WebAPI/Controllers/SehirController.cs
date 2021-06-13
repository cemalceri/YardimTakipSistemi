using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SehirController : ControllerBase
    {
        private ISehirService _sehirService;

        public SehirController(ISehirService ilceService)
        {
            _sehirService = ilceService;
        }

        [HttpGet("getAll")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {
            var result = _sehirService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _sehirService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

    }
}