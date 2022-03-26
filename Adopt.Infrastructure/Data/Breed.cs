namespace Adopt.Infrastructure.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Breed
    {
        public Breed()
        {
            this.Pets = new HashSet<Pet>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
