using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityArchitecture.DAL.Common
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly UnityDbContext _dbContext;

        public UnitOfWork(UnityDbContext context)
        {
            _dbContext = context;
        }


        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public int Save()
        {
            return  _dbContext.SaveChanges();
        }
    }
}
