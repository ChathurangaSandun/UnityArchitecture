using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityArchitecture.DAL.Common;
using UnityArchitecture.DomainModel.Models;

namespace UnityArchitecture.DAL.Interfaces
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {

        Customer TopCustomer(int count);
    }
}
