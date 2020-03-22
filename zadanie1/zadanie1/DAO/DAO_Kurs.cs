using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie1.Models;

namespace zadanie1.DAO
{
    public class DAO_Kurs
    {
        public static string filePath = "Kursy.txt";
        public static List<Kurs> kursy = new List<Kurs>();

        public List<string> getKursyString()
        {
            kursy = new List<Kurs>();
            List<string> kursy_str = File.ReadAllLines(filePath).ToList();
            foreach (var r in kursy_str)
            {
                string[] enteries = r.Split(',');
                Kurs kurs = new Kurs();
                kurs.id = int.Parse(enteries[0]);
                kurs.name = enteries[1];


                List<string> students = new List<string>();
                DAO_Student ds = new DAO_Student();
                List<Student> dao_students = ds.getStudenci();
                for (int i = 2; i < enteries.Length; i++)
                {
                    for (int j = 0; j < dao_students.Count; j++)
                    {
                        if (int.Parse(enteries[i]) == dao_students[j].id)
                        {
                            students.Add(dao_students[j].id.ToString() + "," + dao_students[j].imie + "," + dao_students[j].nazwisko +"," + dao_students[j].indeks);
                        }
                    }
                }
                kurs.students = students;
                
                kursy.Add(kurs);
            }

            for(int i=0; i< kursy_str.Count; i++)
            {
                string[] enteries = kursy_str[i].Split(',');
                string value = enteries[0] + "," + enteries[1];
                kursy_str[i] = value;
            }

                return kursy_str;
        }

        public void setKursy(List<Kurs> list)
        {
            kursy = list;
            List<string> kursy_str= new List<string>();
            foreach (var r in kursy)
            {
                string enteries = r.id.ToString() + "," + r.name.ToString();
                string st = "";
                foreach(string v in r.students)
                {
                    string[] indexes = v.Split(',');
                    st = st + "," + indexes[0];
                }
                enteries += st;
                kursy_str.Add(enteries);

            }

            File.WriteAllLines(filePath, kursy_str);
        }

        public List<Kurs> getKursy()
        {
            kursy = new List<Kurs>();
            List<string> kursy_str = File.ReadAllLines(filePath).ToList();
            foreach (var r in kursy_str)
            {
                string[] enteries = r.Split(',');
                Kurs kurs = new Kurs();
                kurs.id = int.Parse(enteries[0]);
                kurs.name = enteries[1];


                List<string> students = new List<string>();
                DAO_Student ds = new DAO_Student();
                List<Student> dao_students = ds.getStudenci();
                for (int i = 2; i < enteries.Length; i++)
                {
                    for (int j = 0; j < dao_students.Count; j++)
                    {
                        if (int.Parse(enteries[i]) == dao_students[j].id)
                        {
                            students.Add(dao_students[j].id.ToString() + "," + dao_students[j].imie + "," + dao_students[j].nazwisko + "," + dao_students[j].indeks);
                        }
                    }
                }
                kurs.students = students;

                kursy.Add(kurs);
            }
            return kursy;
        }

        public void synchronizeKursy()
        {
            DAO_Kurs_DB dkdb = new DAO_Kurs_DB();
            List<Kurs> kursy_db = dkdb.getKursyObj();
            foreach (Kurs k in kursy_db)
            {
                k.students = dkdb.getAllStudenci(k.id);
            }
            File.WriteAllText(filePath, string.Empty);
            setKursy(kursy_db);
        }

    }
}
