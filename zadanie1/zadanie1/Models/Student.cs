using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1.Models
{
    public class Student
    {
        public int id { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string indeks { get; set; }

        public Student()
        {
            this.id = -1;
            this.imie = "";
            this.nazwisko = "";
            this.indeks = "";
        }

        public Student(int id, string imie, string nazwisko, string indeks)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.indeks = indeks;
        }
    }
}
