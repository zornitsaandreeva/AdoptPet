namespace AdoptPet.Models
{
    using Adopt.Models;
    using System.Collections.Generic;

    public class Pet
    {
        public Pet()
        {
            this.Images = new HashSet<Image>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
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
