using Library.Application.Services;
using Library.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : Controller
    {
        private ILibraryService libraryService;

        public MemberController(ILibraryService libraryService)
        {
            this.libraryService = libraryService;
        }

        // GET: api/members
        [HttpGet]
        public ActionResult<IEnumerable<Member>> GetMember()
        {
            var members = libraryService.GetMembers();
            return Ok(members);
        }

        // GET: api/members/{id}
        [HttpGet("{id}")]
        public ActionResult<Member> GetMember(int id)
        {
            var member = libraryService.GetMemberById(id);

            if (member == null)
            {
                return NotFound();
            }

            return Ok(member);
        }
    }
}
