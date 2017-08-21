using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityArchitecture.BAL.Interfaces;
using UnityArchitecture.DomainModel.Models;

namespace UnityArchitecture.BAL.Services
{
    public class CustomerService : ICustomerService
    {
        public Customer GetCustomerById(int id)
        {
            return new Customer()
            {
                Id = 1,
                Name = "sandun"
            };
        }
    }
}
