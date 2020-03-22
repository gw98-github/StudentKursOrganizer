namespace zadanie1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddKurs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNameKurs = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxNrIndeksu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.buttonEditStudent = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.textBoxIdKurs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EditKurs = new System.Windows.Forms.Button();
            this.buttonDeleteKurs = new System.Windows.Forms.Button();
            this.listBoxKursy = new System.Windows.Forms.ListBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.listBoxListaStudentow = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxIdStudentKurs = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.listBoxStudenci = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.synchronizeFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista studentów";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista kursów";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonAddKurs
            // 
            this.buttonAddKurs.Location = new System.Drawing.Point(376, 405);
            this.buttonAddKurs.Name = "buttonAddKurs";
            this.buttonAddKurs.Size = new System.Drawing.Size(75, 23);
            this.buttonAddKurs.TabIndex = 2;
            this.buttonAddKurs.Text = "Dodaj kurs";
            this.buttonAddKurs.UseVisualStyleBackColor = true;
            this.buttonAddKurs.Click += new System.EventHandler(this.buttonAddKurs_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(843, 606);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dodaj studenta do kursu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(19, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nazwa kursu:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 768);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Imię:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(19, 798);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nazwisko:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(19, 831);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nr indeksu:";
            // 
            // textBoxNameKurs
            // 
            this.textBoxNameKurs.Location = new System.Drawing.Point(106, 405);
            this.textBoxNameKurs.Name = "textBoxNameKurs";
            this.textBoxNameKurs.Size = new System.Drawing.Size(264, 20);
            this.textBoxNameKurs.TabIndex = 8;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(96, 764);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(192, 20);
            this.textBoxImie.TabIndex = 9;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(96, 796);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(192, 20);
            this.textBoxNazwisko.TabIndex = 10;
            // 
            // textBoxNrIndeksu
            // 
            this.textBoxNrIndeksu.Location = new System.Drawing.Point(96, 827);
            this.textBoxNrIndeksu.Name = "textBoxNrIndeksu";
            this.textBoxNrIndeksu.Size = new System.Drawing.Size(192, 20);
            this.textBoxNrIndeksu.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(28, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID; Nazwa kursu:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(28, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "ID; Imię; Nazwisko; Indeks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(534, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = ">>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(294, 784);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "ID:";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(328, 781);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(42, 20);
            this.textBoxStudentID.TabIndex = 18;
            // 
            // buttonEditStudent
            // 
            this.buttonEditStudent.Location = new System.Drawing.Point(376, 761);
            this.buttonEditStudent.Name = "buttonEditStudent";
            this.buttonEditStudent.Size = new System.Drawing.Size(75, 23);
            this.buttonEditStudent.TabIndex = 19;
            this.buttonEditStudent.Text = "Edytuj";
            this.buttonEditStudent.UseVisualStyleBackColor = true;
            this.buttonEditStudent.Click += new System.EventHandler(this.buttonEditStudent_Click);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Location = new System.Drawing.Point(377, 792);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteStudent.TabIndex = 20;
            this.buttonDeleteStudent.Text = "Usuń";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // textBoxIdKurs
            // 
            this.textBoxIdKurs.Location = new System.Drawing.Point(106, 374);
            this.textBoxIdKurs.Name = "textBoxIdKurs";
            this.textBoxIdKurs.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdKurs.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(22, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "ID:";
            // 
            // EditKurs
            // 
            this.EditKurs.Location = new System.Drawing.Point(377, 339);
            this.EditKurs.Name = "EditKurs";
            this.EditKurs.Size = new System.Drawing.Size(75, 23);
            this.EditKurs.TabIndex = 23;
            this.EditKurs.Text = "Edytuj";
            this.EditKurs.UseVisualStyleBackColor = true;
            this.EditKurs.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonDeleteKurs
            // 
            this.buttonDeleteKurs.Location = new System.Drawing.Point(376, 371);
            this.buttonDeleteKurs.Name = "buttonDeleteKurs";
            this.buttonDeleteKurs.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteKurs.TabIndex = 24;
            this.buttonDeleteKurs.Text = "Usuń";
            this.buttonDeleteKurs.UseVisualStyleBackColor = true;
            this.buttonDeleteKurs.Click += new System.EventHandler(this.buttonDeleteKurs_Click);
            // 
            // listBoxKursy
            // 
            this.listBoxKursy.FormattingEnabled = true;
            this.listBoxKursy.Location = new System.Drawing.Point(22, 99);
            this.listBoxKursy.Name = "listBoxKursy";
            this.listBoxKursy.Size = new System.Drawing.Size(430, 225);
            this.listBoxKursy.TabIndex = 25;
            this.listBoxKursy.SelectedIndexChanged += new System.EventHandler(this.listBoxKursy_SelectedIndexChanged);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(301, 825);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(151, 23);
            this.buttonAddStudent.TabIndex = 26;
            this.buttonAddStudent.Text = "Dodaj studenta";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // listBoxListaStudentow
            // 
            this.listBoxListaStudentow.FormattingEnabled = true;
            this.listBoxListaStudentow.Location = new System.Drawing.Point(601, 339);
            this.listBoxListaStudentow.Name = "listBoxListaStudentow";
            this.listBoxListaStudentow.Size = new System.Drawing.Size(393, 225);
            this.listBoxListaStudentow.TabIndex = 27;
            this.listBoxListaStudentow.SelectedIndexChanged += new System.EventHandler(this.listBoxListaStudentow_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label12.Location = new System.Drawing.Point(554, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(510, 55);
            this.label12.TabIndex = 28;
            this.label12.Text = "Lista studentów kursu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(598, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "ID; Imię; Nazwisko; Indeks";
            // 
            // textBoxIdStudentKurs
            // 
            this.textBoxIdStudentKurs.Location = new System.Drawing.Point(685, 620);
            this.textBoxIdStudentKurs.Name = "textBoxIdStudentKurs";
            this.textBoxIdStudentKurs.Size = new System.Drawing.Size(140, 20);
            this.textBoxIdStudentKurs.TabIndex = 30;
            this.textBoxIdStudentKurs.TextChanged += new System.EventHandler(this.textBoxIdStudentKurs_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(655, 625);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "ID:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(843, 636);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Usuń studenta z kursu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // listBoxStudenci
            // 
            this.listBoxStudenci.FormattingEnabled = true;
            this.listBoxStudenci.Location = new System.Drawing.Point(22, 518);
            this.listBoxStudenci.Name = "listBoxStudenci";
            this.listBoxStudenci.Size = new System.Drawing.Size(429, 225);
            this.listBoxStudenci.TabIndex = 33;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(752, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(224, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "BAZA DANYCH(wył. operacja na plikach)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // synchronizeFiles
            // 
            this.synchronizeFiles.Location = new System.Drawing.Point(752, 118);
            this.synchronizeFiles.Name = "synchronizeFiles";
            this.synchronizeFiles.Size = new System.Drawing.Size(224, 23);
            this.synchronizeFiles.TabIndex = 35;
            this.synchronizeFiles.Text = "Synchronizuj";
            this.synchronizeFiles.UseVisualStyleBackColor = true;
            this.synchronizeFiles.Click += new System.EventHandler(this.synchronizeFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 857);
            this.Controls.Add(this.synchronizeFiles);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBoxStudenci);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxIdStudentKurs);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listBoxListaStudentow);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.listBoxKursy);
            this.Controls.Add(this.buttonDeleteKurs);
            this.Controls.Add(this.EditKurs);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxIdKurs);
            this.Controls.Add(this.buttonDeleteStudent);
            this.Controls.Add(this.buttonEditStudent);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNrIndeksu);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.textBoxNameKurs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddKurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kursy i studenci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddKurs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNameKurs;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxNrIndeksu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Button buttonEditStudent;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.TextBox textBoxIdKurs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button EditKurs;
        private System.Windows.Forms.Button buttonDeleteKurs;
        private System.Windows.Forms.ListBox listBoxKursy;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.ListBox listBoxListaStudentow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxIdStudentKurs;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBoxStudenci;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button synchronizeFiles;
    }
}

