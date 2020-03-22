using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zadanie1.Models;
using zadanie1.Views;
using zadanie1.Presenters;
using zadanie1.DAO;

namespace zadanie1
{
    public partial class Form1 : Form, IKurs, IStudent
    {
        public static bool files = true;

        public string idText { get => textBoxIdKurs.Text; set => textBoxIdKurs.Text = value; }
        public string nameText { get => textBoxNameKurs.Text; set => textBoxNameKurs.Text = value; }
        public string imieText { get => textBoxImie.Text; set => textBoxImie.Text = value; }
        public string nazwiskoText { get => textBoxNazwisko.Text; set => textBoxNazwisko.Text = value; }
        public string indeksText { get => textBoxNrIndeksu.Text; set => textBoxNrIndeksu.Text = value; }
        public string idText_Student { get => textBoxStudentID.Text; set => textBoxStudentID.Text = value; }
        public List<string> students { get => (List<string>)listBoxListaStudentow.DataSource; set => listBoxListaStudentow.DataSource = value; }

        public Form1()
        {        
            InitializeComponent();
            KursPresenter kp = new KursPresenter(this);
            StudentPresenter sp = new StudentPresenter(this);

            
            listBoxKursy.DataSource = kp.getAllKursy();
            listBoxStudenci.DataSource = sp.getAllStudenci();
            DAO_Kurs dk = new DAO_Kurs();
            listBoxListaStudentow.DataSource = students;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (files == true)
            {
                KursPresenter kp = new KursPresenter(this);
                int index = listBoxKursy.SelectedIndex;
                kp.addStudent(index, int.Parse(textBoxIdStudentKurs.Text));
                StudentPresenter sp = new StudentPresenter(this);
                listBoxStudenci.Refresh();
                listBoxStudenci.DataSource = sp.getAllStudenci();
                listBoxKursy_SelectedIndexChanged(null, null);
            }
            else
            {
                DAO_Kurs_DB daokdb = new DAO_Kurs_DB();
                string index = (string) listBoxKursy.SelectedItem;
                string[] item = index.Split(',');
                int i = int.Parse(item[0]);
                daokdb.addStudent(i, int.Parse(textBoxIdStudentKurs.Text));
                listBoxListaStudentow.DataSource = daokdb.getAllStudenci(i);
                listBoxKursy_SelectedIndexChanged(null, null);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (files == true)
            {
                KursPresenter kp = new KursPresenter(this);
                kp.editKurs(int.Parse(idText), nameText);
                listBoxKursy.DataSource = kp.getAllKursy();
            }
            else
            {
                DAO_Kurs_DB daokdb = new DAO_Kurs_DB();
                daokdb.editKurs(int.Parse(idText),nameText);
                listBoxKursy.DataSource = daokdb.getKursy();
            }
        }

        private void buttonAddKurs_Click(object sender, EventArgs e)
        {
            if (files == true)
            {
                KursPresenter kp = new KursPresenter(this);
                kp.addKurs(nameText);
                listBoxKursy.DataSource = kp.getAllKursy();
            }
            else
            {
                DAO_Kurs_DB daokdb = new DAO_Kurs_DB();
                daokdb.addKurs(nameText);
                listBoxKursy.DataSource = daokdb.getKursy();
            }
        }

        private void buttonDeleteKurs_Click(object sender, EventArgs e)
        {
            if (files == true)
            {
                KursPresenter kp = new KursPresenter(this);
                kp.deleteKurs(int.Parse(idText));
                listBoxKursy.DataSource = kp.getAllKursy();
            }
            else
            {
                DAO_Kurs_DB daokdb = new DAO_Kurs_DB();
                daokdb.deleteKurs(int.Parse(idText));
                listBoxKursy.DataSource = daokdb.getKursy();
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (files == true)
            {
                StudentPresenter sp = new StudentPresenter(this);
                sp.addStudent(imieText, nazwiskoText, indeksText);
                listBoxStudenci.DataSource = sp.getAllStudenci();
            }
            else
            {
                DAO_Student_DB daosdb = new DAO_Student_DB();
                daosdb.addStudent(imieText, nazwiskoText, indeksText);
                listBoxStudenci.DataSource = daosdb.getStudenci();
            }
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (files == true)
            {
                StudentPresenter sp = new StudentPresenter(this);
                sp.deleteStudent(int.Parse(idText_Student));
                listBoxStudenci.DataSource = sp.getAllStudenci();
            }
            else
            {
                DAO_Student_DB daosdb = new DAO_Student_DB();
                daosdb.deleteStudent(int.Parse(idText_Student));
                listBoxStudenci.DataSource = daosdb.getStudenci();
            }
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            if (files == true)
            {
                StudentPresenter sp = new StudentPresenter(this);
                sp.editStudent(int.Parse(idText_Student), imieText, nazwiskoText, indeksText);
                listBoxStudenci.DataSource = sp.getAllStudenci();
            }
            else
            {
                DAO_Student_DB daosdb = new DAO_Student_DB();
                daosdb.editStudent(int.Parse(idText_Student), imieText, nazwiskoText, indeksText);
                listBoxStudenci.DataSource = daosdb.getStudenci();
            }
        }

        private void listBoxKursy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (files == true)
            {
                StudentPresenter sp = new StudentPresenter(this);
                int index = listBoxKursy.SelectedIndex;
                DAO_Kurs dk = new DAO_Kurs();
                List<Kurs> lk = dk.getKursy();
                List<string> ls = lk[index].students;
                students = ls;
            }
            else
            {
                DAO_Kurs_DB daokdb = new DAO_Kurs_DB();
                string index = (string)listBoxKursy.SelectedItem;
                string[] item = index.Split(',');
                int i = int.Parse(item[0]);
                listBoxListaStudentow.DataSource = daokdb.getAllStudenci(i);
            }
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (files == true)
            {
                KursPresenter kp = new KursPresenter(this);
                int index = listBoxKursy.SelectedIndex;
                kp.deleteStudent(index, int.Parse(textBoxIdStudentKurs.Text));
                StudentPresenter sp = new StudentPresenter(this);
                listBoxStudenci.Refresh();
                listBoxStudenci.DataSource = sp.getAllStudenci();
                listBoxKursy_SelectedIndexChanged(null, null);
            }
            else
            {
                DAO_Kurs_DB daokdb = new DAO_Kurs_DB();
                string index = (string)listBoxKursy.SelectedItem;
                string[] item = index.Split(',');
                int i = int.Parse(item[0]);
                daokdb.deleteStudent(i, int.Parse(textBoxIdStudentKurs.Text));
                listBoxListaStudentow.DataSource = daokdb.getAllStudenci(i);
                listBoxKursy_SelectedIndexChanged(null, null);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                files = false;
                DAO_Kurs_DB daokdb = new DAO_Kurs_DB();
                listBoxKursy.DataSource = daokdb.getKursy();
                DAO_Student_DB daosdb = new DAO_Student_DB();
                
                listBoxStudenci.DataSource = daosdb.getStudenci();

                string index = (string)listBoxKursy.SelectedItem;
                string[] item = index.Split(',');
                int i = int.Parse(item[0]);
                listBoxListaStudentow.DataSource = daokdb.getAllStudenci(i);
            }
            else
            {
                files = true;
                KursPresenter kp = new KursPresenter(this);
                StudentPresenter sp = new StudentPresenter(this);


                listBoxKursy.DataSource = kp.getAllKursy();
                listBoxStudenci.DataSource = sp.getAllStudenci();

                int index = listBoxKursy.SelectedIndex;
                DAO_Kurs dk = new DAO_Kurs();
                List<Kurs> lk = dk.getKursy();
                List<string> ls = lk[index].students;
                students = ls;
            }
        }

        private void listBoxListaStudentow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdStudentKurs_TextChanged(object sender, EventArgs e)
        {

        }

        private void synchronizeFiles_Click(object sender, EventArgs e)
        {
            if (files == true)
            {
                DAO_Student_DB dsdb = new DAO_Student_DB();
                DAO_Kurs_DB dkdb = new DAO_Kurs_DB();
                dsdb.synchronizeStudenci();
                dkdb.synchronizeKursy();

            }
            else
            {
                DAO_Kurs dk = new DAO_Kurs();
                DAO_Student ds = new DAO_Student();
                ds.synchronizeStudenci();
                dk.synchronizeKursy();
            }

        }
    }
}
