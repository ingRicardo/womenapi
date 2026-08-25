namespace WebWomen.Models
{
    public class WomanRatingSummaryDto
    {
        public int WomanId { get; set; }
        public string Name { get; set; } = string.Empty;
        public double AverageRate { get; set; }
        public int TotalRatings { get; set; }
    }

    public class CreateRateDto
    {
        public int WomanId { get; set; }
        public int Rate { get; set; }
    }
}
