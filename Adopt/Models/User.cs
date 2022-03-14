namespace AdoptPet.Models
{
    using System.ComponentModel.DataAnnotations;
    public class User
    {
        [Key]
        [StringLength(36)]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(64)]
        public string Password { get; set; }
    }
}

