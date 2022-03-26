namespace Adopt.Infrastructure.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Image
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
