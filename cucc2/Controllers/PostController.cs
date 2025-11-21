using cucc2.Models;
using cucc2.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cucc2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpPost]
        public ActionResult AddNewPost(AddPostDto addPostDto)
        {
            try
            {
                using (var context = new BlogDbContext())
                {
                    var post = new Post
                    {
                        Category = addPostDto.Category,
                        Description = addPostDto.Description,
                        BloggerId = addPostDto.BloggerId
                    };
                    if (post != null)
                    {
                        context.posts.Add(post);
                        context.SaveChanges();
                        return StatusCode(201, new { message = "Sikeres felvétel", result = post });
                    }
                    return NotFound(new { message = "Sikertelen felvétel", result = post });
                }
            }
            catch (Exception ex) {
            {
                    return BadRequest(new { message = ex.Message, result = "" });
            }
        }
    }
}
