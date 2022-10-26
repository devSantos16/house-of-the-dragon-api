using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace house_of_the_dragon_api.models
{
    public class BookCharacter
    {
        [Key]
        public int IdBookCharacter { get; set; }

        [ForeignKey("Book")]
        public int BookIdBook { get; set; }
        public Book Book { get; set; }

        [ForeignKey("Character")]
        public int CharacterIdCharacter { get; set; }
        public Character Character { get; set; }
    }
}