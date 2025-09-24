using SalesWEBMVC.Data;
using SalesWEBMVC.Models;
namespace SalesWEBMVC.Services
{
    public class SellerService
    {
        private readonly Data.SalesWEBMVCContext _context;

        public SellerService(SalesWEBMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
