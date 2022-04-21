﻿using Microsoft.AspNetCore.Mvc;
using Wordle.api.Services;

namespace Wordle.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeaderBoardController
    {
        private readonly ILogger<LeaderBoardController> _logger;
        private readonly ILeaderBoardService _leaderBoardService;

        public LeaderBoardController(ILogger<LeaderBoardController> logger,
            ILeaderBoardService leaderBoardService)
        {
            _logger = logger;
            _leaderBoardService = leaderBoardService;
        }

        [HttpGet]
        public IEnumerable<Score> Get()
        {
            _logger.LogInformation("LeaderBoardController.Get()");
            List<Score> results = new()
            {
                new Score("Hildagaurd", 25, 2.6),
                new Score("Ralph", 30, 3.4),
                new Score("Gene", 50, 4.1),
            };
            return results;
        }



    }
}