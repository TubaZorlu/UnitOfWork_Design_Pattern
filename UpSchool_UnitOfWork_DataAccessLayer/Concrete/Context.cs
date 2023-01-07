using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool_UnitOfWork_EntityLayer.Concrete;

namespace UpSchool_UnitOfWork_DataAccessLayer.Concrete
{
    public  class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-CJELTSN\\MSSQLSERVER2019; Database=DbUnitOfWork;integrated security=True;");
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<ProcessDetail> ProcessDetails { get; set; }
    }
}
