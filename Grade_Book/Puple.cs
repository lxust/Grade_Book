using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Book
{
    public class Puple
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public Role UserRole { get; set; }
        public Subject _Subject { get; set; }

        public List<int> Grades;
    }

}
