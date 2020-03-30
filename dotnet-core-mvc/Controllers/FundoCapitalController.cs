using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_core_mvc.CrossCutting;
using dotnet_core_mvc.Repository;
using dotnet_core_mvc.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_mvc.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FundoCapitalController : ControllerBase
    {
        private readonly FundoCapitalService _service;

        //// GET: api/FundoCapital
        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    var result = _repository.GetAll();
        //    return Ok(result);
        //}

        // GET: api/FundoCapital/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetById(Guid id)
        {
            var result = _service.GetById(id);
            return Ok();
        }

        ////POST: api/FundoCapital
        //[HttpPost]
        //public IActionResult Post(FundoCapitalPostDto dto)
        //{
        //    var result = _repository.Insert(dto);
        //    return Ok();
        //}

        ////PUT: api/FundoCapital/5
        //[HttpPut("{id}")]
        //public IActionResult Put(Guid id, FundoCapitalPutDto dto)
        //{
        //    var result = _repository.Update(dto);
        //    return Ok();
        //}

        ////DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public IActionResult Delete(Guid id)
        //{
        //    var result = _repository.Delete(id);
        //    return Ok();
        //}
    }
}
