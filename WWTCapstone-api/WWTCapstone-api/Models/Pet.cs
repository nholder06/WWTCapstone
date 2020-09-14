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

        public string Age { get; set; }

        public string Birthday { get; set; }

        public string Breed { get; set; }

        public string PreferredVet { get; set; }

        public string VetPhoneNum { get; set; }

        public string Routines { get; set; }

        public string Commands { get; set; }

        public string Likes { get; set; }

        public string Dislikes { get; set; }

        public string Notes { get; set; }

    }
}

