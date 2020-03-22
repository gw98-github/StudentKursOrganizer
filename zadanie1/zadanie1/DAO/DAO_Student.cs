using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie1.Models;

namespace zadanie1.DAO
{
    class DAO_Student
    {
        public static string filePath = "Studenci.txt";
        public static List<Student> studenci = new List<Student>();

        public List<string> getStudenciString()
        {
            studenci = new List<Student>();
            List<string> studenci_str = File.ReadAllLines(filePath).ToList();
            foreach (var r in studenci_str)
            {
                string[] enteries = r.Split(',');
                Student stud = new Student();
                stud.id = int.Parse(enteries[0]);
                stud.imie = enteries[1];
                stud.nazwisko = enteries[2];
                stud.indeks = enteries[3];
                studenci.Add(stud);
            }
            return  studenci_str;
        }

        public void setStudenci(List<Student> list)
        {
            studenci = list;
            List<string> studenci_str = new List<string>();
            foreach (var r in studenci)
            {
                string enteries = r.id.ToString() + "," + r.imie.ToString() + "," + r.nazwisko.ToString() + "," + r.indeks.ToString();
                studenci_str.Add(enteries);

            }

            File.WriteAllLines(filePath, studenci_str);
        }

        public List<Student> getStudenci()
        {
            studenci = new List<Student>();
            List<string> studenci_str = File.ReadAllLines(filePath).ToList();
            foreach (var r in studenci_str)
            {
                string[] enteries = r.Split(',');
                Student stud = new Student();
                stud.id = int.Parse(enteries[0]);
                stud.imie = enteries[1];
                stud.nazwisko = enteries[2];
                stud.indeks = enteries[3];
                studenci.Add(stud);
            }
            return studenci;
        }

        public void synchronizeStudenci()
        {

            DAO_Student_DB dsdb = new DAO_Student_DB();
            List<Student> student_db = dsdb.getStudenciObj();

            File.WriteAllText(filePath, string.Empty);
            setStudenci(student_db);
        }

    }

}
