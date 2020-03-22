using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie1.DAO;
using zadanie1.Models;
using zadanie1.Views;

namespace zadanie1.Presenters
{
    public class StudentPresenter
    {
        IStudent studentView;

        public StudentPresenter(IStudent view)
        {
            studentView = view;
        }

        public void addStudent(string imie, string nazwisko, string indeks)
        {
            DAO_Student dao = new DAO_Student();
            List<Student> list = dao.getStudenci();
            int index = list.Last().id;
            Student nstud = new Student(index + 1, imie, nazwisko, indeks);
            list.Add(nstud);
            dao.setStudenci(list);
        }

        public void deleteStudent(int index)
        {
            DAO_Student dao = new DAO_Student();
            List<Student> list = dao.getStudenci();
            Student to_delete = null;
            foreach (var k in list)
            {
                if (k.id == index) to_delete = k;
            }
            if (to_delete != null) list.Remove(to_delete);
            dao.setStudenci(list);
        }

        public void editStudent(int index, string imie, string nazwisko, string indeks)
        {
            if (index != 0)
            {
                DAO_Student dao = new DAO_Student();
                List<Student> list = dao.getStudenci();
                foreach (var k in list)
                {
                    if (k.id == index)
                    {
                        k.imie = imie;
                        k.nazwisko = nazwisko;
                        k.indeks = indeks;
                    }
                }
                dao.setStudenci(list);
            }
        }

        public List<string> getAllStudenci()
        {
            DAO_Student dao = new DAO_Student();
            return dao.getStudenciString();

        }
    }
}
