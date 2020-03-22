using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1.Models
{
    public class Kurs
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<string> students { get; set; }
        

        public Kurs()
        {
            this.id = -1;
            this.name = "";
            this.students = new List<string>();
        }

        public Kurs(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.students = new List<string>();
        }

        public Kurs(int id, string name, List<string> students)
        {
            this.id = id;
            this.name = name;
            this.students = students;
        }
    }
}
