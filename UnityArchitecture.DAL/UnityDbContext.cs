using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityArchitecture.DomainModel.Models;

namespace UnityArchitecture.DAL
{
    public class UnityDbContext : DbContext
    {
        public UnityDbContext() : base("UnityDbContext")
        {
            
        }

        private DbSet<Customer> Customers { get; set; }


    }
}
//Enable-Migrations -ProjectName UnityArchitecture.Migrations -StartUpProjectName UnityArchitecture -ContextProjectName UnityArchitecture.DAL -ContextTypeName UnityDbContext
//Add-Migration  -ProjectName UnityArchitecture.Migrations  addcustomer_m1
//Update-Database -ProjectName UnityArchitecture.Migrations -verbose


