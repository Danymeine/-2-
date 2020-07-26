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
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }
        public EndForm(MainTest_form f)
        {
            InitializeComponent();

        }
        private void EndForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //--------------------------------------------------------------------------------------------
        int sum = 0;
        //--------------------------------------------------------------------------------------------
        void show_asnwers(int i, Label result, Label points)
        {
            points.Text = MainTest_form.statistics[1, i].ToString();
            switch(MainTest_form.statistics[0, i])
            {
                case 1:
                    result.Text = "Верно";
                    result.BackColor = MainTest_form.right_back;
                    break;

                case 0:
                    result.Text = "Без ответа";
                    result.BackColor = MainTest_form.noAnswer_back;
                    break;

                case -1:
                    result.Text = "Неверно";
                    result.BackColor = MainTest_form.wrong_back;
                    break;

                default:
                    break;
            }
        }

        //--------------------------------------------------------------------------------------------

        private void EndForm_Load(object sender, EventArgs e)
        {
            fio_label.Text = Form1.fio;
            faculty_label.Text = Form1.faculty;
            group_label.Text = Form1.fullGroupNumber;
            date_label.Text = Form1.dateTest;

            for (int i = 0; i < 10; i++)
            {
                sum += MainTest_form.statistics[1, i];
            }

            show_asnwers(0, task1_label, label32);
            show_asnwers(1, task2_label, label31);
            show_asnwers(2, task3_label, label30);
            show_asnwers(3, task4_label, label29);
            show_asnwers(4, task5_label, label28);
            show_asnwers(5, task6_label, label27);
            show_asnwers(6, task7_label, label26);
            show_asnwers(7, task8_label, label25);
            show_asnwers(8, task9_label, label24);
            show_asnwers(9, task10_label, label23);

            sumPoints_label.Text = sum.ToString();
        }
    }
}
