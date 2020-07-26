using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REA_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // глобальные переменные с данными студента 
        public static DateTime date1 = DateTime.Now;
        public static string fullGroupNumber;
        public static string faculty;
        public static string fio;
        public static string dateTest = date1.ToString("dddd, dd MMMM yyyy");
        private void Form1_Load(object sender, EventArgs e)
        {
            date_label.Text = dateTest;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
        // пишем в глобальные переменные данные студента
            fullGroupNumber = groupNumber_textbox.Text;
            faculty = faculty_textbox.Text;
            fio = name_textbox.Text;

        // выводим в лейблы введенные данные для проверки
            group_label.Text = fullGroupNumber;
            faculty_label.Text = faculty;
            name_label.Text = fio;

            if(fullGroupNumber == "" && faculty == "" && fio == "")
            {
                label5.Text = "Введите ваши данные!";
                label5.BackColor = MainTest_form.wrong_back;
            }
            else
            {
                label5.Text = "Проверьте ваши данные:";
                label5.BackColor = MainTest_form.def;
            }
        }

        private void Next_button_Click(object sender, EventArgs e)
        {

            MainTest_form newForm = new MainTest_form(this);
            newForm.Show();
            this.Hide();
        }
    }
}
