using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie1.Models;
using zadanie1.Views;
using zadanie1.DAO;

namespace zadanie1.Presenters
{
    class KursPresenter
    {
        IKurs kursView;

        public KursPresenter(IKurs view)
        {
            kursView = view;
        }

        public void addKurs(string name)
        {
            DAO_Kurs dao = new DAO_Kurs();
            List<Kurs> list = dao.getKursy();
            int index = list.Last().id;
            Kurs nkurs = new Kurs(index + 1, name);
            list.Add(nkurs);
            dao.setKursy(list);
        }

        public void deleteKurs(int index)
        {
            DAO_Kurs dao = new DAO_Kurs();
            List<Kurs> list = dao.getKursy();
            Kurs to_delete = null;
            foreach (var k in list)
            {
                if (k.id == index) to_delete = k;
            }
            if (to_delete != null) list.Remove(to_delete);
            dao.setKursy(list);
        }

        public void editKurs(int index, string name)
        {
            DAO_Kurs dao = new DAO_Kurs();
            List<Kurs> list = dao.getKursy();
            foreach (var k in list)
            {
                if (k.id == index) k.name = name;
            }
            dao.setKursy(list);
        }

        public List<string> getAllKursy()
        {
            DAO_Kurs dao = new DAO_Kurs();
            return dao.getKursyString();

        }

        public void addStudent(int kurs, int student)
        {
            DAO_Kurs dao = new DAO_Kurs();
            List<Kurs> list = dao.getKursy();
            List<string> ls = list[kurs].students;
            bool check = false;
            for(int i=0; i < ls.Count; i++)
            {
                string[] enteries = ls[i].Split(',');
                if (enteries[0] == student.ToString()) check = true;
            }

            DAO_Student dao_s = new DAO_Student();
            List<Student> studenci = dao_s.getStudenci();
            for(int i=0; i<studenci.Count;i++)
            {
                if(studenci[i].id == student)
                {
                    if(!check) ls.Add(studenci[i].id.ToString() + "," + studenci[i].imie.ToString() + "," + studenci[i].nazwisko.ToString() + "," + studenci[i].indeks.ToString());
                }
            }
            list[kurs].students = ls;
            dao.setKursy(list);
        }

        public void deleteStudent(int kurs, int student)
        {
            DAO_Kurs dao = new DAO_Kurs();
            List<Kurs> list = dao.getKursy();
            List<string> ls = list[kurs].students;
            bool check = false;
            for (int i = 0; i < ls.Count; i++)
            {
                string[] enteries = ls[i].Split(',');
                if (enteries[0] == student.ToString()) ls.RemoveAt(i);
            }
            list[kurs].students = ls;
            dao.setKursy(list);

        }

    }
}
