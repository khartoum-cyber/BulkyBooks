using BulkyBooks.DataAccess.Repository.IRepository;
using BulkyBooks.Models;

namespace BulkyBooks.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
