﻿using Microsoft.AspNetCore.Mvc;
using AirportWeatherAppAPI.TaylorSPRepositories;
using AirportWeatherAppAPI.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace AirportWeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetFeedbackByUserIDController : Controller
    {
       
        private readonly IGetFeedbackByUserID GetFeedbackByUserID;
        public GetFeedbackByUserIDController(IGetFeedbackByUserID getfeedbackbyuserid)
        {
            this.GetFeedbackByUserID = getfeedbackbyuserid;
        }
        [HttpPost("getfeedback")]
        public async Task<IActionResult> GetFeedbackAsync(int UserID)
        {
            if (UserID == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await GetFeedbackByUserID.FeedbackSearch(UserID);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
    }
}

