using Library.Application.Services;
using Library.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : Controller
    {
        private ILibraryService libraryService;

        public CheckoutController(ILibraryService libraryService)
        {
            this.libraryService = libraryService;
        }

        // GET: api/checkouts
        [HttpGet]
        public ActionResult<IEnumerable<Checkout>> GetCheckouts()
        {
            var checkouts = libraryService.GetCheckouts();
            return Ok(checkouts);
        }

        // GET: api/checkouts/{id}
        [HttpGet("{id}")]
        public ActionResult<Checkout> GetCheckouts(int id)
        {
            var checkout = libraryService.GetCheckoutById(id);

            if (checkout == null)
            {
                return NotFound();
            }

            return Ok(checkout);
        }
    }
}
