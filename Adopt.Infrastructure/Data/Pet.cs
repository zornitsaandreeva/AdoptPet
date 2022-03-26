namespace Adopt.Infrastructure.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Pet
    {
        public Pet()
        {
            this.Images = new HashSet<Image>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Sex { get; set; }
        public int Age { get; set; }
        public int BreedId { get; set; }
        public virtual Breed Breed { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int CurrentHomeId { get; set; }
        public virtual CurrentHome CurrentHome { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
