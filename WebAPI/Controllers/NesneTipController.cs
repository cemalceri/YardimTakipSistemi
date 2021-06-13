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
    public class NesneTipController : ControllerBase
    {
        private INesneTipService _nesneTipService;

        public NesneTipController(INesneTipService nesneTipService)
        {
            _nesneTipService = nesneTipService;
        }

        [HttpGet("getAll")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {
            var result = _nesneTipService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _nesneTipService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(NesneTip nesneTip)
        {
            var result = _nesneTipService.Add(nesneTip);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(NesneTip nesneTip)
        {
            var result = _nesneTipService.Update(nesneTip);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var result = _nesneTipService.Delete(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

    }
}