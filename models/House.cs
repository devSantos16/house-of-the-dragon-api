using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace house_of_the_dragon_api.models
{
    public class House
    {
        [Key]
        public int IdHouse { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public string home { get; set; }
    }
}