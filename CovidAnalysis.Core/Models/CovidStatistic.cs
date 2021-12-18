namespace CovidAnalysis.Core.Models
{
    public partial class CovidStatistic
    {
        public int Id { get; set; }
        public string Country { get; set; } = null!;
        public string TotalCases { get; set; } = null!;
        public string? NewCases { get; set; }
        public string? TotalDeaths { get; set; }
        public string? NewDeaths { get; set; }
        public string? TotalRecovered { get; set; }
        public string? NewRecovered { get; set; }
        public string? ActiveCases { get; set; }
        public string? SeriousCritical { get; set; }
        public double? TotalCasesPer1Mpopulation { get; set; }
        public double? DeathsPer1Mpopulation { get; set; }
        public string? TotalTests { get; set; }
        public string? TestsPer1Mpopulation { get; set; }
        public string? Population { get; set; }
    }
}
