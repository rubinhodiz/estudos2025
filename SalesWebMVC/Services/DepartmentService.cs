using SalesWEBMVC.Data;
using SalesWEBMvc.Models;


namespace SalesWEBMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWEBMVC.Data.SalesWEBMVCContext _context;

        public DepartmentService(SalesWEBMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
