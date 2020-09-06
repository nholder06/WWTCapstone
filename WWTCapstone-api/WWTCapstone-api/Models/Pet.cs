using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WWTCapstone_api.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime Birthday { get; set; }

        public string Breed { get; set; }

        public string PrefferedVet { get; set; }

        public string VetPhoneNumber { get; set; }

        public string FoodRoutine { get; set; }

        public string Commands { get; set; }

        public string Likes { get; set; }

        public string Dislikes { get; set; }

        public string Notes { get; set; }

    }
}

