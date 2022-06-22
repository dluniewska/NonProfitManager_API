using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NonProfitManager.Models
{
    public class Transport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransportId { get; set; }
        public string StartCity { get; set; }
        public string Destination { get; set; }
        public DateOnly Date { get; set; }
        public virtual int UserId { get; set; }
        public virtual int OrganizationId { get; set; }
    }
}
