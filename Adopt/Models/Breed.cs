﻿namespace Adopt.Models
{
    using AdoptPet.Models;
    using System.Collections.Generic;

    public class Breed
    {
        public Breed()
        {
            this.Pets = new HashSet<Pet>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
