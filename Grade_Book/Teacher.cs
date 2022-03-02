using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Book
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public Subject _Subject { get; set; }
        public Role UserRole { get; set; }

        public List<Puple> Puples;
    }
}
