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
    public class VatandasController : ControllerBase
    {
        private IVatandasService _vatandasService;

        public VatandasController(IVatandasService vatandasService)
        {
            _vatandasService = vatandasService;
        }

        [HttpGet("getAll")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {
            var result = _vatandasService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _vatandasService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Vatandas vatandas)
        {
            var result = _vatandasService.Add(vatandas);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Vatandas vatandas)
        {
            var result = _vatandasService.Update(vatandas);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var result = _vatandasService.Delete(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("transaction")]
        public IActionResult TransactionTest(Vatandas vatandas)
        {
            var result = _vatandasService.TransactionalOperation(vatandas);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}