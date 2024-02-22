﻿using Business.Abstracts;
using Business.Requests.Application;
using Business.Requests.Bootcamp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tobeto_net_3a_bootcampProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BootcampController : ControllerBase
    {
        private readonly IBootcampService _bootcampService;

        public BootcampController(IBootcampService bootcampService)
        {
            _bootcampService = bootcampService;
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(CreateBootcampRequest request)
        {
            return Ok(await _bootcampService.AddAsync(request));
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> getAllAsync()
        {
            return Ok(await _bootcampService.GetAllAsync());
        }

        [HttpPost("GetByIdAsync")]
        public async Task<IActionResult> getByIdAsync(GetByIdBootcampRequest request)
        {
            return Ok(await _bootcampService.GetByIdAsync(request));
        }

        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync(DeleteBootcampRequest request)
        {
            return Ok(await _bootcampService.DeleteAsync(request));
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync(UpdateBootcampRequest request)
        {
            return Ok(await _bootcampService.UpdateAsync(request));
        }
    }
}
