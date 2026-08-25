using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebWomen.Models
{
    [Table("woman")]
    public class Woman
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("avatar")]
        public string? Avatar { get; set; }

        [Column("age")]
        public int? Age { get; set; }

        [Column("status")]
        public string? Status { get; set; }

        [Column("dateofbirth")]
        public string? DateOfBirth { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("race")]
        public string? Race { get; set; }

        [Column("email")]
        public string? Email { get; set; }
    }
}
