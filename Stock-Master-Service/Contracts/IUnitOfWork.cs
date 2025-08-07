using Stock_Master_DataAccess.Models;
using Stock_Master_DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock_Master_Service.Contracts
{
    public interface IUnitOfWork
    {
        GenericRepository<Student> StudentRepository { get; }
        GenericRepository<Bank> BankRepository { get; }
        GenericRepository<SM_USER> SM_USER_Repository { get; }
    }
}
