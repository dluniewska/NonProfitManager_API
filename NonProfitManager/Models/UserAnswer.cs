namespace NonProfitManager.Models
{
    public class UserAnswer
    {
        public int UserAnswerId { get; set; }
        public virtual Question Question { get; set; }
        public string Response { get; set; }
    }
}
