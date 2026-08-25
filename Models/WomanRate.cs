using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebWomen.Models
{
    [Table("woman_rate")]
    public class WomanRate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("woman_id")]
        public int WomanId { get; set; }

        [Column("rate")]
        public int Rate { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        [ForeignKey("WomanId")]
        public Woman? Woman { get; set; }
    }
}
