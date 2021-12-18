using CovidAnalysis.Core.Models;
using CovidAnalysis.Core.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CovidAnalysis.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CovidStatisticController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<CovidStatisticController> _logger;
        public CovidStatisticController(IMediator mediator, ILogger<CovidStatisticController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("GetCovidStatistic/{take}")]
        public async Task<IActionResult> Get(int take)
        {
            var query = new GetCovidStatisticQuery
            {
                Take = take
            };

            var result = await _mediator.Send(query);
            return Ok(result);  
        }

        [HttpGet("SearchCovidStatistic/{take}/{keyword}")]
        public async Task<IActionResult> Search(int take, string keyword)
        {
            var query = new SearchCovidStatisticQuery
            {
                Take = take,
                Keyword = keyword
            };

            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}