using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace house_of_the_dragon_api.models
{
    public class Book
    {
        [Key]
        public int idBook { get; set; }
        public string name { get; set; }
        public int ISBN { get; set; }
    }
}