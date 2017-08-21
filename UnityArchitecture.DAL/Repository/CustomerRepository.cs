using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityArchitecture.DAL.Common;
using UnityArchitecture.DAL.Interfaces;
using UnityArchitecture.DomainModel.Models;

namespace UnityArchitecture.DAL.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(UnityDbContext context) : base(context)
        {
        }

        public Customer TopCustomer(int count)
        {
            return dbSet.First(o => o.Id == 1);
        }
    }
}
