using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using house_of_the_dragon_api.Context;
using house_of_the_dragon_api.models;

namespace house_of_the_dragon_api.Controllers
{
    [ApiController]
    [Route("controller")]
    public class HouseController : ControllerBase
    {
        private readonly HouseOfTheDragonContext context;

        public HouseController(HouseOfTheDragonContext context)
        {
            this.context = context;
        }

        [HttpGet("GetAllBooks")]
        public ActionResult ReturnMsg()
        {
            return Ok(this.context.Books);
        }


        [HttpPost("InsertBook")]
        public ActionResult InsertBook(string name, int isbn)
        {

            Book b = new Book();
            b.name = name;
            b.ISBN = isbn;

            this.context.Books.Add(b);
            this.context.SaveChanges();
            return Ok();
        }
    }
}