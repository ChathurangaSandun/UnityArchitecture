using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityArchitecture.DomainModel.Models;

namespace UnityArchitecture.BAL.Interfaces
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int id);
    }
}
