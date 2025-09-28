using SalesWEBMvc.Models;
using SalesWEBMVC.Models;
using SalesWEBMVC.Data;
namespace SalesWEBMvc.Services
{
    public class SellerService
    {
        private readonly SalesWEBMVCContext _context;

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
          //  obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
