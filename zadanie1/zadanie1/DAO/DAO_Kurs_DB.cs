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
    public class DAO_Kurs_DB
    {
        static string myConnectionString = "server=localhost;database=zadanie1db;uid=root;pwd=wroclaw14;";
        MySqlConnection databaseConnection = new MySqlConnection(myConnectionString);


        public void addKurs(string name)
        {
            databaseConnection.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("addKurs", databaseConnection);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("_name", name);
            mysqlcmd.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public void addFullKurs(int index, string name)
        {
            databaseConnection.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("addFullKurs", databaseConnection);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("id", index);
            mysqlcmd.Parameters.AddWithValue("_name", name);
            mysqlcmd.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public void deleteKurs(int id)
        {
            databaseConnection.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("deleteKurs", databaseConnection);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("_KursID", id);
            mysqlcmd.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public void editKurs(int id, string name)
        {
            databaseConnection.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("editKurs", databaseConnection);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("_id", id);
            mysqlcmd.Parameters.AddWithValue("_name", name);
            mysqlcmd.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public List<Kurs> getKursyObj()
        {
            databaseConnection.Open();
            MySqlDataAdapter mySqlCmd = new MySqlDataAdapter("getKursy", databaseConnection);
            mySqlCmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            DataSet dtb = new DataSet();
            mySqlCmd.Fill(dtb);
            List<Kurs> ls = new List<Kurs>();
            foreach (DataRow dr in dtb.Tables[0].Rows)
            {
                ls.Add(new Kurs(int.Parse(Convert.ToString(dr["id_kurs"])) , Convert.ToString(dr["name"])));
            }
            databaseConnection.Close();
            return ls;
            
        }

        public List<string> getKursy()
        {
            databaseConnection.Open();
            MySqlDataAdapter mySqlCmd = new MySqlDataAdapter("getKursy", databaseConnection);
            mySqlCmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            DataSet dtb = new DataSet();
            mySqlCmd.Fill(dtb);
            List<string> ls = new List<string>();
            foreach(DataRow dr in dtb.Tables[0].Rows)
            {
                ls.Add(Convert.ToString(dr["id_kurs"]) + "," + Convert.ToString(dr["name"]));
            }
            databaseConnection.Close();
            return ls;
        }

        internal List<string> getAllStudenci(int index)
        {
            try
            {
                databaseConnection.Open();
                MySqlDataAdapter mySqlCmd = new MySqlDataAdapter("getConnection", databaseConnection);
                mySqlCmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCmd.SelectCommand.Parameters.AddWithValue("_id", index);
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
            catch { }
            return null;
        }

        public void addStudent(int kurs, int student)
        {
            try
            {
                databaseConnection.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("addConnection", databaseConnection);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_ids", student);
                mysqlcmd.Parameters.AddWithValue("_idk", kurs);
                mysqlcmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch
            {

            }
        }


        public void clearConnection()
        {
                databaseConnection.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("clearConnection", databaseConnection);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.ExecuteNonQuery();
                databaseConnection.Close();
        }

        public void clearKurs()
        {
            databaseConnection.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("clearKurs", databaseConnection);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public void deleteStudent(int kurs, int student)
        {
            try
            {
                databaseConnection.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("deleteConnection", databaseConnection);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_ids", student);
                mysqlcmd.Parameters.AddWithValue("_idk", kurs);
                mysqlcmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch
            {

            }
        }

        public void synchronizeKursy()
        {
            clearKurs();
            DAO_Kurs dk = new DAO_Kurs();
            List<Kurs> kursy = dk.getKursy();
            foreach(Kurs k in kursy)
            {

                addFullKurs(k.id, k.name);

                for(int i=0; i<k.students.Count;i++)
                {
                    string values = k.students[i];
                    string[] sep = values.Split(',');
                    int index = int.Parse(sep[0]);
                    addStudent(k.id, index);
                }

            }
        }


    }
}
