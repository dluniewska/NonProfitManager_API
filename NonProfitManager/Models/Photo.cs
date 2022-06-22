using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NonProfitManager.Models
{
    public class Photo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhotoId { get; set; }
        public byte[] Bytes { get; set; }
        public string Description { get; set; }
        public string FileExtension { get; set; }
        public decimal Size { get; set; }
        public virtual int AnimalId { get; set; }
    }
}
