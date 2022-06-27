namespace NonProfitManager.Models
{
    public class ReservedAnimal
    {
        public int ReservedAnimalId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Details { get; set; }
        public string Age { get; set; }
        public int Quantity { get; set; }
        public virtual int OrganizationId { get; set; }
        public virtual int UserId { get; set; }
    }
}
