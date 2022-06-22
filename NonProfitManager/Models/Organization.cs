using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NonProfitManager.Models
{
    public class Organization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int Phone { get; set; }
        public string NIP { get; set; }
        public string KRS { get; set; }
        public string REGON { get; set; }
        public string City { get; set; }
        public string Street{ get; set; }
        public string BuildingNumber { get; set; }
        public string ApartmentNumber{ get; set; }
        public string AreaCode { get; set; }
        public virtual List<Animal> Animals{ get; set; }
    }
}
