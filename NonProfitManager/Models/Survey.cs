namespace NonProfitManager.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }

        public string Description { get; set; }
        public DateOnly CreatedAt { get; set; }
        public virtual List<Question> Questions { get; set; }
    }
}
