using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie1.Models;

namespace zadanie1.DAO
{
    class DAO_Student_DB
    {
        static string myConnectionString = "server=localhost;database=zadanie1db;uid=root;pwd=wroclaw14;";
        MySqlConnection databaseConnection = new MySqlConnection(myConnectionString);

        public void addStudent(string imie, string nazwisko, string indeks)
        {
            databaseConnection.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("addStudent", databaseConnection);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("_imie", imie);
            mysqlcmd.Parameters.AddWithValue("_nazwisko", nazwisko);
            mysqlcmd.Parameters.AddWithValue("_indeks", indeks);
            mysqlcmd.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public void addFullStudent(int id, string imie, string nazwisko, string indeks)
        {
            databaseConnection.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("addFullStudent", databaseConnection);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("_id", id);
            mysqlcmd.Parameters.AddWithValue("_imie", imie);
            mysqlcmd.Parameters.AddWithValue("_nazwisko", nazwisko);
            mysqlcmd.Parameters.AddWithValue("_indeks", indeks);
            mysqlcmd.ExecuteNonQuery();
            databaseConnection.Close();
        }


        public void deleteStudent(int id)
        {
            databaseConnection.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("deleteStudent", databaseConnection);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("_id", id);
            mysqlcmd.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public void editStudent(int id, string imie, string nazwisko, string indeks)
        {
            databaseConnection.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("editStudenci", databaseConnection);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("_id", id);
            mysqlcmd.Parameters.AddWithValue("_imie", imie);
            mysqlcmd.Parameters.AddWithValue("_nazwisko", nazwisko);
            mysqlcmd.Parameters.AddWithValue("_indeks", indeks);
            mysqlcmd.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public List<Student> getStudenciObj()
        {
            databaseConnection.Open();
            MySqlDataAdapter mySqlCmd = new MySqlDataAdapter("getStudenci", databaseConnection);
            mySqlCmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            DataSet dtb = new DataSet();
            mySqlCmd.Fill(dtb);
            List<Student> ls = new List<Student>();
            foreach (DataRow dr in dtb.Tables[0].Rows)
            {
                ls.Add(new Student(int.Parse(Convert.ToString(dr["id_student"])), Convert.ToString(dr["imie"]),
                    Convert.ToString(dr["nazwisko"]), Convert.ToString(dr["indeks"])));
            }
            databaseConnection.Close();
            return ls;

        }
        public List<string> getStudenci()
        {
            databaseConnection.Open();
            MySqlDataAdapter mySqlCmd = new MySqlDataAdapter("getStudenci", databaseConnection);
            mySqlCmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            DataSet dtb = new DataSet();
            mySqlCmd.Fill(dtb);
            List<string> ls = new List<string>();
            foreach (DataRow dr in dtb.Tables[0].Rows)
            {
                ls.Add(Convert.ToString(dr["id_student"]) + "," + Convert.ToString(dr["imie"])
                    + "," + Convert.ToString(dr["nazwisko"]) + "," + Convert.ToString(dr["indeks"]));
            }
            databaseConnection.Close();
            return ls;

        }

        public void clearStudenci()
        {
            databaseConnection.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("clearStudent", databaseConnection);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public void synchronizeStudenci()
        {
            DAO_Kurs_DB d = new DAO_Kurs_DB();
            d.clearConnection();
            clearStudenci();

            DAO_Student ds = new DAO_Student();
            List<Student> studenci = ds.getStudenci();
            foreach (Student s in studenci)
            {
                addFullStudent(s.id, s.imie,s.nazwisko,s.indeks);
            }
        }
    }
}
