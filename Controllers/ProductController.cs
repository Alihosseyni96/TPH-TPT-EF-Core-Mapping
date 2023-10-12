using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TPH_TPT_EF_Core_Mapping.Model;
using Microsoft.EntityFrameworkCore;

namespace TPH_TPT_EF_Core_Mapping.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly EFCoreMappingContext _context;

        public ProductController(EFCoreMappingContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            var category = new Category()
            {
                Name = "Mobile",
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Name = "IPhone",
                        Model = new Model.Model()
                        {
                            Name = "13 promax",
                            ReleaseDate = DateTime.Now
                        }
                    }
                }

            };

            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok();
        }


        [HttpGet]
        public IActionResult DoQuery()
        {
            var query = _context.Products.DistinctBy(p => p.Name);  
            var query1 = _context.Products.Select(x => x.Name).Distinct().ToList();
            return Ok();
        }
    }
}
