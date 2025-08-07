using Stock_Master_DataAccess.DataContext;
using Stock_Master_DataAccess.Models;
using Stock_Master_DataAccess.Repository;

namespace Stock_Master_Service.Contracts
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StockManagementContext _context;
        public UnitOfWork(StockManagementContext context) => _context = context;

        GenericRepository<Student> _StudentReference;
        public GenericRepository<Student> StudentRepository
        {
            get
            {
                if (_StudentReference == null)
                    _StudentReference = new GenericRepository<Student>(_context);
                return _StudentReference;
            }
        }

        GenericRepository<Bank> _BankReference;
        public GenericRepository<Bank> BankRepository
        {
            get
            {
                if (_BankReference == null)
                    _BankReference = new GenericRepository<Bank>(_context);
                return _BankReference;
            }
        }

        GenericRepository<SM_USER> _SM_USERReference;
        public GenericRepository<SM_USER> SM_USER_Repository
        {
            get
            {
                if (_SM_USERReference == null)
                    _SM_USERReference = new GenericRepository<SM_USER>(_context);
                return _SM_USERReference;
            }
        }
    }
}
