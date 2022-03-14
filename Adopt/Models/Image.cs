namespace AdoptPet.Models
{
    using System;

    public class Image
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
