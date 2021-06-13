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
    public class YardimSepetiController : ControllerBase
    {
        private IYardimSepetiService _yardimSepetiService;

        public YardimSepetiController(IYardimSepetiService yardimSepetiService)
        {
            _yardimSepetiService = yardimSepetiService;
        }

        [HttpGet("getAll")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {
            var result = _yardimSepetiService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _yardimSepetiService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(YardimSepeti yardimSepeti)
        {
            var result = _yardimSepetiService.Add(yardimSepeti);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(YardimSepeti yardimSepeti)
        {
            var result = _yardimSepetiService.Update(yardimSepeti);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var result = _yardimSepetiService.Delete(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("transaction")]
        public IActionResult TransactionTest(YardimSepeti yardimSepeti)
        {
            var result = _yardimSepetiService.TransactionalOperation(yardimSepeti);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}