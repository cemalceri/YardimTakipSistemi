using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YardimController : ControllerBase
    {
        private IYardimService _yardimService;

        public YardimController(IYardimService yardimService)
        {
            _yardimService = yardimService;
        }

        [HttpGet("getAll")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {
            var result = _yardimService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _yardimService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Yardim yardim)
        {
            var result = _yardimService.Add(yardim);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Yardim yardim)
        {
            var result = _yardimService.Update(yardim);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var result = _yardimService.Delete(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("transaction")]
        public IActionResult TransactionTest(Yardim yardim)
        {
            var result = _yardimService.TransactionalOperation(yardim);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}