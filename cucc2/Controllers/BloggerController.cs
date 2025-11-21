using cucc2.Models;
using cucc2.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cucc2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloggerController : ControllerBase
    {
        [HttpPost]
        public ActionResult AddNewBlogger(AddBloggerDto addBloggerDto)
        {
            try
            {
                using (var context = new BlogDbContext())
                {
                    var blogger = new Blogger
                    {
                        Name = addBloggerDto.Name,
                        Password = addBloggerDto.Password,
                        Email = addBloggerDto.Email
                    };
                    if (blogger != null)
                    {
                        context.bloggers.Add(blogger);
                        context.SaveChanges();
                        return StatusCode(201, new { message = "Sikeres felvétel", result = blogger });
                    }
                    return NotFound(new { message = "Sikertelen felvétel", result = blogger });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message, result = "" });
            }
        }
    }
}
