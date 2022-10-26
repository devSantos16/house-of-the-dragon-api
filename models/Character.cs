using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace house_of_the_dragon_api.models
{
    public class Character
    {
        [Key]
        public int IdCharacter { get; set; }
        public string Name { get; set; }
        public int Birth { get; set; }
        public string Description { get; set; }
        public string Surname { get; set; }

        [ForeignKey("House")]
        public int HouseIdhouse { get; set; }
        public House House { get; set; }

        [ForeignKey("Dragon")]
        public int DragonIdDragon { get; set; }
        public Dragon Dragon { get; set; }
    }
}