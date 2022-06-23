using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NonProfitManager.Models
{
    public class Animal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Species{ get; set; }
        public string Details { get; set; }
        public DateOnly DateOfBirth{ get; set; }
        public DateOnly CreatedAt { get; set; }
        public int Quantity { get; set; }
        public virtual int OrganizationId { get; set; }
    }
}
