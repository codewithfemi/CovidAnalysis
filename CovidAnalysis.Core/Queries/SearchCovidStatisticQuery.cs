using CovidAnalysis.Core.Models;
using MediatR;

namespace CovidAnalysis.Core.Queries
{
    public class SearchCovidStatisticQuery : IRequest<List<CovidStatistic>>
    {
        public string? Keyword { get; set; }
        public int Take { get; set; }
    }

    public class SearchCovidStatisticQueryHandler : IRequestHandler<SearchCovidStatisticQuery, List<CovidStatistic>>
    {
        private readonly ICovidStatisticRepository _covidStatisticRepository;

        public SearchCovidStatisticQueryHandler(ICovidStatisticRepository covidStatisticRepository)
        {
            _covidStatisticRepository = covidStatisticRepository;
        }

        public async Task<List<CovidStatistic>> Handle(SearchCovidStatisticQuery request, CancellationToken cancellationToken)
        {
           return await Task.Run(() =>  _covidStatisticRepository
           .SearchCovidStatistics(request.Take, request.Keyword ?? string.Empty));
        }
    }


}
