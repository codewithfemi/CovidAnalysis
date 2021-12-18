using CovidAnalysis.Core;
using CovidAnalysis.Core.Models;

namespace CovidAnalysis.Infrastructure.Data.EF.Repositories
{
    public class CovidStatisticRepository : ICovidStatisticRepository
    {
        private readonly CovidDbContext _context;
        public CovidStatisticRepository(CovidDbContext context)
        {
            _context = context;
        }

        public List<CovidStatistic> GetCovidStatistics(int take)
        {
            return _context.CovidStatistics.Take(take).ToList();
        }

        public List<CovidStatistic> SearchCovidStatistics(int take, string search)
        {
            return _context.CovidStatistics
                .Where(x => x.Country.ToLower().Contains(search.ToLower()))
                .Take(take).ToList();
        }

    }
}
