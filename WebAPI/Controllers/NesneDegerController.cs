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
    public class NesneDegerController : ControllerBase
    {
        private INesneDegerService _nesneDegerService;

        public NesneDegerController(INesneDegerService nesneDegerService)
        {
            _nesneDegerService = nesneDegerService;
        }

        [HttpGet("getAll")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {
            var result = _nesneDegerService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getListByNesneTipId")]
        public IActionResult GetListByNesneTipId(int nesneTipId)
        {
            var result = _nesneDegerService.GetByNesneTipId(nesneTipId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _nesneDegerService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(NesneDeger nesneDeger)
        {
            var result = _nesneDegerService.Add(nesneDeger);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(NesneDeger nesneDeger)
        {
            var result = _nesneDegerService.Update(nesneDeger);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var result = _nesneDegerService.Delete(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("transaction")]
        public IActionResult TransactionTest(NesneDeger nesneDeger)
        {
            var result = _nesneDegerService.TransactionalOperation(nesneDeger);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}