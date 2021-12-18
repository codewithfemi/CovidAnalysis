using CovidAnalysis.Core.Models;

namespace CovidAnalysis.Core
{
    public interface ICovidStatisticRepository
    {
        List<CovidStatistic> GetCovidStatistics(int take);
        List<CovidStatistic> SearchCovidStatistics(int take, string search);
    }
}
