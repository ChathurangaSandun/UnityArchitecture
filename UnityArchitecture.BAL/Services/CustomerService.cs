using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityArchitecture.BAL.Interfaces;
using UnityArchitecture.DAL.Common;
using UnityArchitecture.DAL.Interfaces;
using UnityArchitecture.DomainModel.Models;

namespace UnityArchitecture.BAL.Services
{
    public class CustomerService : ICustomerService
    {
        private IUnitOfWork _unitOfWork;
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(IUnitOfWork unitOfWork, ICustomerRepository customerRepository)
        {
            _unitOfWork = unitOfWork;
            _customerRepository = customerRepository;
        }

        public virtual Customer GetTop(int id)
        {
            return  _customerRepository.TopCustomer(1);
        }
    }
}
