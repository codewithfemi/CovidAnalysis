using CovidAnalysis.Core.Models;
using MediatR;

namespace CovidAnalysis.Core.Queries
{
    public class GetCovidStatisticQuery : IRequest<List<CovidStatistic>>
    {
        public int Take { get; set; }
    }

    public class GetCovidStatisticQueryHandler : IRequestHandler<GetCovidStatisticQuery, List<CovidStatistic>>
    {
        private readonly ICovidStatisticRepository _covidStatisticRepository;

        public GetCovidStatisticQueryHandler(ICovidStatisticRepository covidStatisticRepository)
        {
            _covidStatisticRepository = covidStatisticRepository;
        }

        public async Task<List<CovidStatistic>> Handle(GetCovidStatisticQuery request, CancellationToken cancellationToken)
        {
           return await Task.Run(() =>  _covidStatisticRepository.GetCovidStatistics(request.Take));
        }
    }


}
