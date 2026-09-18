using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebWomen.Models
{
    [Table("billservice")]
    public class BillService
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(255)]
        [Column("email")]
        public string? Email { get; set; }

        [Required]
        [MaxLength(250)]
        [Column("servicename")]
        public string ServiceName { get; set; } = string.Empty;

        [Column("cost", TypeName = "decimal(18,2)")]
        public decimal? Cost { get; set; }

        [MaxLength(50)]
        [Column("duedate")]
        public string? DueDate { get; set; }

        [MaxLength(100)]
        [Column("type")]
        public string? Type { get; set; }

        [MaxLength(50)]
        [Column("status")]
        public string? Status { get; set; }

        [MaxLength(100)]
        [Column("idempotency_key")]
        public string? Idempotency_key { get; set; }
    }
}
