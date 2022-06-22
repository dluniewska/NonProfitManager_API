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
        public string Kind { get; set; }
        public DateOnly DateOfBirth{ get; set; }
        public string Status { get; set; }
        public virtual int? UserId { get; set; }
        public virtual int OrganizationId { get; set; }
    }
}
