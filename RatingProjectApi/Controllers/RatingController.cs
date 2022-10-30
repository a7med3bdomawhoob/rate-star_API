using AutoMapper;
using BLL.Interfaces;
using BLL.Repositories;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RatingProjectApi.Dto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RatingProjectApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IGenaricRepository<Rating> repository;
        private readonly IMapper mapper;

        public RatingController(IGenaricRepository<Rating> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }


        [HttpGet("GetAllRates")]
        public async Task<ActionResult<IEnumerable<Rating>>> allrates()
        {
            var rates = await repository.getall();
            return Ok(rates);
        }

        [HttpPost("SetRate")]

        public async Task<ActionResult> SetRating(RatingDto rate)
        {
            if (!ModelState.IsValid) return BadRequest("Validation Error");

            try
            {
             var rating = mapper.Map<RatingDto, Rating>(rate);
             await repository.Add(rating);
                return Ok(rate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
