using GeneralStoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeneralStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private GeneralStoreDBContext _db;
        public TransactionController(GeneralStoreDBContext db){
            _db = db;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateTransaction([FromForm]TransactionEdit newTransaction) {
            Transaction transaction = new Transaction() {
                ProductId = newTransaction.ProductId,
                CustomerId = newTransaction.CustomerId,
                Quantity = newTransaction.Quantity,
                DateOfTransaction = DateTime.Now
            };

            _db.Transactions.Add(transaction);
            await _db.SaveChangesAsync();
            return Ok("Successfully Created!");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTransactions() {
            var transactions = await _db.Transactions.ToListAsync();
            return Ok(transactions);
        }
    }
}