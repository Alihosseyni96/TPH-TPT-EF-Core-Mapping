using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TPH_TPT_EF_Core_Mapping.Model;
using TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels;

namespace TPH_TPT_EF_Core_Mapping.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TPTController : ControllerBase
    {
        private readonly TPH_TPT_EF_Core_Mapping.Model.EFCoreMappingContext _context;

        public TPTController(EFCoreMappingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddDogs()
        {
            var dogs = new List<Dog>();
            for (int i = 0; i < 5; i++)
            {
                dogs.Add(new Dog()
                {
                    Name = $"Dog{i}",
                    Speed = i,
                });
            }
            _context.Dogs.AddRange(dogs);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult AddCats()
        {
            var cats = new List<Cat>();
            for (int i = 0; i < 5; i++)
            {
                cats.Add(new Cat()
                {
                    Name = $"cat{i}",
                    Color = "Blue"
                   
                });
            }
            _context.Cats.AddRange(cats);
            //_context.Animals.AddRange(cats); OR
            _context.SaveChanges();
            return Ok();
        }


        [HttpGet]
        public IActionResult GetAnnonimusById(int id )
        {
           

            var res = _context.Animals.SingleOrDefault(x=> x.Id == id);

            if (res.GetType().Equals(typeof(Dog)))
            {
                return Content("Dog");
            }
            if (res.GetType().Equals(typeof(Cat)))
            {
                return Content("Cat");
            }
            return Ok();

        }


    }
}
