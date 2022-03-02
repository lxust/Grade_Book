using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Book
{
    public class GbContext : DbContext
    {
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Puple> puples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=GradeBook"); // В настоящий момент БД не существует
        }
    }
}
