namespace AdoptPet.Models
{
    using System.Collections.Generic;
    public class Category
    {
        public Category()
        {
            this.Pets = new HashSet<Pet>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
