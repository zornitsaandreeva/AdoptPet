namespace Adopt.Infrastructure.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class CurrentHome
    {
        public CurrentHome()
        {
            this.Pets = new HashSet<Pet>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
