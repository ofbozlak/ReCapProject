using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalCarsController : ControllerBase
    {
        IRentalCarService _rentalCarService;

        public RentalCarsController(IRentalCarService rentalCarService)
        {
            _rentalCarService = rentalCarService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalCarService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Massage);
        }

        [HttpGet("add")]
        public IActionResult Add(RentalCar rentalCar)
        {
            var result = _rentalCarService.Add(rentalCar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Massage);
        }


        [HttpGet("delete")]
        public IActionResult Delete(RentalCar rentalCar)
        {
            var result = _rentalCarService.Delete(rentalCar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Massage);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _rentalCarService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Massage);
        }

        [HttpGet("update")]
        public IActionResult Update(RentalCar rentalCar)
        {
            var result = _rentalCarService.Update(rentalCar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Massage);
        }
    }
}
