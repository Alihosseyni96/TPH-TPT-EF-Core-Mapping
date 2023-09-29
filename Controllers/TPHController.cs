using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TPH_TPT_EF_Core_Mapping.Model;
using TPH_TPT_EF_Core_Mapping.Model.TPH_MappingModels;

namespace TPH_TPT_EF_Core_Mapping.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TPHController : ControllerBase
    {
        private readonly TPH_TPT_EF_Core_Mapping.Model.EFCoreMappingContext _context;

        public TPHController(EFCoreMappingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddClient()
        {
            var clients = new List<Client>();
            for (int i = 0; i < 5; i++)
            {
                clients.Add(new Client()
                {
                    Mobile = (i + i).ToString(),
                    Email = "client" + i + "gmail.com",
                    Gender = Gender.female,
                    Name = "client" + i.ToString(),
                    NationalCode = i.ToString(),

                });
            }

            _context.Clients.AddRange(clients);
            //_context.People.AddRange(clients);

            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult AddUsers()
        {
            var users = new List<User>();
            for (int i = 0; i < 5; i++)
            {
                users.Add(new User()
                {
                    Mobile = (i + i).ToString(),
                    Gender = Gender.female,
                    Name = "client" + i.ToString(),
                    UserId  = i,
                    UserName = "User" + i.ToString(),

                });
            }

            _context.Users.AddRange(users);
            //_context.People.AddRange(clients);

            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAnnonimusPersonById(int id)
        {
            var x = _context.People.Where(x=> x is User).ToList();
            var x1 = _context.People.Where(y=> x is User).ToList();


            var person = _context.People.SingleOrDefault(x=> x.Id == id);
            var t = person as Client;
            var t2 = person as TPH_TPT_EF_Core_Mapping.Model.TPH_MappingModels.User;
            //var t3 = (Client)person; // اینجوری تبدیل کردن اگه نشه ، خطا میگیری
            //var t4 = (TPH_TPT_EF_Core_Mapping.Model.TPH_MappingModels.User)person;
            if (person.GetType().Equals(typeof(Client)))
            {
                return Content("type is  Client");
            }
            if (person.GetType().Equals(typeof(User)))
            {
                return Content("type is  User");
            }
            return Ok();
        }


    }
}
