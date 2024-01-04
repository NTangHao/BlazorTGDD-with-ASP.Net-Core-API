using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TGDD.Api.Data;
using TGDD.Api.Entities;

namespace TGDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ShopOnlineDbContext _context;

        public CartsController(ShopOnlineDbContext context)
        {
            _context = context;
        }

        // GET: api/Carts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cart>>> GetCarts()
        {
            return await _context.Carts.ToListAsync();
        }

        // GET: api/Carts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cart>> GetCart(int id)
        {
            var cart = await _context.Carts.FindAsync(id);

            if (cart == null)
            {
                return NotFound();
            }

            return cart;
        }


        // GET: api/Carts/User/5 tao them route moi ko gay xung dot route cu
        [HttpGet("User/{userid:int}")]
        public async Task<ActionResult<Cart>> GetCartByUserId(int userid)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(x => x.UserId == userid);

            if (cart == null)
            {
                return NotFound();
            }

            return cart;
        }

        // PUT: api/Carts/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCart(int id, Cart cart)
        {
            if (id != cart.Id)
            {
                return BadRequest();
            }

            _context.Entry(cart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        // Must include [FromBody] in the parameter
        [HttpPost]
        public async Task<ActionResult<Cart>> PostCart([FromBody] int userID)
        {
            try
            {
                Cart cart = new Cart
                {
                    UserId = userID
                };

                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetCart", new { id = cart.Id }, cart);
            }
            catch (Exception)
            {

                throw;
            }

        }

        // DELETE: api/Carts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart(int id)
        {
            var cart = await _context.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }

            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CartExists(int id)
        {
            return _context.Carts.Any(e => e.Id == id);
        }
    }
}
