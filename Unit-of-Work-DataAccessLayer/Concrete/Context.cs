using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_of_Work_EntityLayer.Concrete;

namespace Unit_of_Work_DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)    //dependes inj. kullanabilmek için yapıyoruz
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
