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
    public partial class MainTest_form : Form
    {
        //=========================================================================================
        // какая то хуйня для теста проги
        Image[] texts = new Image[] {Properties.Resources.task_1num_5var,
            Properties.Resources.task_1num_5var,
            Properties.Resources.task_3num_5var,
            /*"Разнообразный и богатый опыт начало повседневной работы по формированию позиции",
            "Значимость этих проблем настолько очевидна, что дальнейшее развитие различных форм деятельности позволяет оценить значение системы",
            "Не следует, однако забывать, что новая модель организационной деятельности позволяет выполнять важные задания по разработке дальнейших направлений развития.",
            "Таким образом дальнейшее развитие различных форм деятельности играет важную роль в формировании дальнейших направлений развития.",
            "Идейные соображения высшего порядка, а также укрепление и развитие структуры представляет собой интересный эксперимент проверки существенных финансовых и административных условий.",
            "Разнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу (специалистов) участие в формировании системы обучения кадров, соответствует насущным потребностям.",
            "Идейные соображения высшего порядка, а также дальнейшее развитие различных форм деятельности влечет за собой процесс внедрения и модернизации соответствующий условий активизации. ",*/
        };

        Image[,] answers = new Image[,] {
        {Properties.Resources.ansv_1_1num_5var,Properties.Resources.ansv_2_1num_5var,Properties.Resources.ansv_3_1num_5var},
        {Properties.Resources.ansv_1_1num_5var,Properties.Resources.ansv_1_1num_5var,Properties.Resources.ansv_1_1num_5var },
        { Properties.Resources.ansv_1_3num_5var,Properties.Resources.ansv_2_3num_5var,Properties.Resources.ansv_3_3num_5var},
        /*{"fgqret qeg","qqwet35t  44ef", "fgar erg erargf " },
        {"fr32wqr325 ","32434556rg ","2366y 4gwe" },
        { "fqr gqre","fqwefd ","rgaer ge4q"},
        {"grae dfa","ferwaFDSF","F 4WQTFTWQR FS ERTFDSA F" },
        {"gbhsrf hvh yhdgh ","sfh rshsfd hsfth","gs dghsfdghet hg" },
        {"g fasdges gfdagd ","ga gadfg adgretg ","ga gaerg af af a" },
        {"gaf htdsyh tsr ","g adrtghea rgar","g aerger garg e" },*/
        };

        void get_texts()
        {
            //taskText_textbox.Text = texts[curr_task];
            //answer1_textbox.Text = answers[curr_task, 0];
            //answer2_textbox.Text = answers[curr_task, 1];
            //answer3_textbox.Text = answers[curr_task, 2];
            pictureBox1.Image = answers[curr_task, 0];  
            pictureBox2.Image = answers[curr_task, 1];  
            pictureBox3.Image = answers[curr_task, 2]; 
            pictureBox4.Image = texts[curr_task];
        }

        //=========================================================================================
        // ВАЖНЫЕ ПЕРЕМЕННЫЕ!!!
        // текущее задание 
        public static int curr_task = 0;
        public static int tryies = 2;
        public static int clicks = 0;

        // цвета фона предупреждения 
        readonly public static Color right_back = ColorTranslator.FromHtml("#99ed50");
        readonly public static Color wrong_back = ColorTranslator.FromHtml("#db4646");
        readonly public static Color noAnswer_back = ColorTranslator.FromHtml("#f4e155");
        readonly public static Color def = ColorTranslator.FromHtml("#ffffff");

        // массивы состояния заданий
        // {правильный ответ, кол-во попыток, состояние задачи, выбранный ответ}
        // task [0] = Правильный ответ
        // task [1] = Количество попыток (2 попытки всего)
        // task [2] = Состояние задачи
        // task [3] = Выбранный ответ
        // 1 - Уже нажималась кнопка "Проверить ответ"; 0 - не нажималась
        // Состояние задачи: 0 - не выбран ответ, 1 - правильно, -1 - неправильно
        public int[,] task = new int[,] {  { 1, 0, 0, 0, 0 },
                                           { 2, 0, 0, 0, 0 },
                                           { 3, 0, 0, 0, 0 },
                                           { 4, 0, 0, 0, 0 },
                                           { 5, 0, 0, 0, 0 },
                                           { 1, 0, 0, 0, 0 },
                                           { 2, 0, 0, 0, 0 },
                                           { 3, 0, 0, 0, 0 },
                                           { 4, 0, 0, 0, 0 },
                                           { 5, 0, 0, 0, 0 }};

        // массив для проверки выбора ответа
        // если не выбран ни один вариант то все false
        public bool[,] taskAnswers = new bool[,]{  { false, false, false, false, false }, // Задание 1
                                                   { false, false, false, false, false }, // Задание 2
                                                   { false, false, false, false, false }, // Задание 3
                                                   { false, false, false, false, false }, // Задание 4
                                                   { false, false, false, false, false }, // Задание 5
                                                   { false, false, false, false, false }, // Задание 6
                                                   { false, false, false, false, false }, // Задание 7
                                                   { false, false, false, false, false }, // Задание 8
                                                   { false, false, false, false, false }, // Задание 9
                                                   { false, false, false, false, false }};// Задание 10

        public static int[,] statistics = new int[,]{{0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Состояние задачи (-1, 0, 1)
                                                     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }};// Кол-во баллов (высчитывается)

// ВАЖНЫЕ ПЕРЕМЕННЫЕ!!!
//=========================================================================================

//=========================================================================================
// ВАЖНЫЕ ФУНКЦИИ!!!

        void transfer()
        {
            for(int i = 0; i < 10; i++)
            {
                statistics[0, i] = task[i, 2];
                
                if(task[i,1] == 1)
                {
                    statistics[1, i] = 2;
                }
                if(task[i, 1] == 2)
                {
                    statistics[1, i] = 1;
                }
                if (task[i, 1] == 0)
                {
                    statistics[1, i] = 0;
                }
                if(task[i,1] == 2 && task[i,2] == -1)
                {
                    statistics[1, i] = 0;
                }
            }
        }

//--------------------------------------------------------------------------------------------
    void color_buttons(Color col)
        {
            switch (curr_task)
            {
                case 0:
                    button1.BackColor = col;
                    break;
                case 1:
                    button2.BackColor = col;
                    break;
                case 2:
                    button3.BackColor = col;
                    break;
                case 3:
                    button4.BackColor = col;
                    break;
                case 4:
                    button5.BackColor = col;
                    break;
                case 5:
                    button6.BackColor = col;
                    break;
                case 6:
                    button7.BackColor = col;
                    break;
                case 7:
                    button8.BackColor = col;
                    break;
                case 8:
                    button9.BackColor = col;
                    break;
                case 9:
                    button10.BackColor = col;
                    break;
                default:
                    break;
            }
        }
//--------------------------------------------------------------------------------------------
        void set_progress()
        {
            if (task[curr_task,2] == 1)
            {
                color_buttons(right_back);
            }
            if (task[curr_task, 2] == -1 && task[curr_task,1] == 2)
            {
                color_buttons(wrong_back);   
            }
        }
//--------------------------------------------------------------------------------------------
    void check_answer()
        {
            if (task[curr_task, 2] == 0)
            {
                alert_answer_label.Text = "Выберите ответ";
                alert_answer_label.BackColor = noAnswer_back;
            }

            if ( task[curr_task,3] == task[curr_task, 0] && task[curr_task,1] < tryies )
            {
                alert_answer_label.Text = "Верно";
                alert_answer_label.BackColor = right_back;
                task[curr_task, 1] += 1;
                task[curr_task, 2] = 1;
                set_progress();
            }

            if (task[curr_task, 3] != task[curr_task, 0] && task[curr_task, 1] < tryies && task[curr_task, 3] != 0)
            {
                alert_answer_label.Text = "Неверно";
                alert_answer_label.BackColor = wrong_back;
                task[curr_task, 1] += 1;
                if (task[curr_task, 1] == 2)
                {
                    task[curr_task, 2] = -1;
                    set_progress();
                }
            }
        }

//--------------------------------------------------------------------------------------------

    void restore_answers()
        {
            answer1_radio.Checked = taskAnswers[curr_task, 0];
            answer2_radio.Checked = taskAnswers[curr_task, 1];
            answer3_radio.Checked = taskAnswers[curr_task, 2];
            answer4_radio.Checked = taskAnswers[curr_task, 3];
            answer5_radio.Checked = taskAnswers[curr_task, 4];
            
        }

    void disable_answers(bool enabled)
        {
            if (enabled)
            {
                answer1_radio.Enabled = true;
                answer2_radio.Enabled = true;
                answer3_radio.Enabled = true;
                answer4_radio.Enabled = true;
                answer5_radio.Enabled = true;
            }
            if (!enabled)
            {
                answer1_radio.Enabled = false;
                answer2_radio.Enabled = false;
                answer3_radio.Enabled = false;
                answer4_radio.Enabled = false;
                answer5_radio.Enabled = false;
            }
        }

//--------------------------------------------------------------------------------------------

    void disable_confirm()
        {
            if (task[curr_task,2] == 1)
            {
                confirm_button.Enabled = false;
                disable_answers(false);
                alert_answer_label.Text = "Верно";
                alert_answer_label.BackColor = right_back;
            }
            if (task[curr_task, 2] == -1)
            {
                confirm_button.Enabled = false;
                disable_answers(false);
                alert_answer_label.Text = "Неверно";
                alert_answer_label.BackColor = wrong_back;
            }
            if (task[curr_task,2] == 0)
            {
                confirm_button.Enabled = true;
                disable_answers(true);
                
            }
            if (task[curr_task,4] == 0 && task[curr_task,2] == 0)
            {
                alert_answer_label.Text = "";
                alert_answer_label.BackColor = def;
            }
        }
// ВАЖНЫЕ ФУНКЦИИ!!!
//=========================================================================================
// Инициализация
        public MainTest_form()
        {
            InitializeComponent();
        }
        public MainTest_form(Form1 f)
        {
            InitializeComponent();

        }
        private void MainTest_form_Load(object sender, EventArgs e)
        {
            Button1_Click(sender, e); // при загрузке имитируется нажатие кнопки задания 1 чтобы загрузить текст и варианты ответов

        }
        private void MainTest_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //=========================================================================================
        // Кнопки с номером задания 
        private void Button1_Click(object sender, EventArgs e)
        {
            
            curr_task = 0;
            restore_answers();
            disable_confirm();
            get_texts();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            curr_task = 1;
            restore_answers();
            disable_confirm();
            get_texts();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            curr_task = 2;
            restore_answers();
            disable_confirm();
            get_texts();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            curr_task = 3;
            restore_answers();
            disable_confirm();
            get_texts();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            curr_task = 4;
            restore_answers();
            disable_confirm();
            get_texts();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            curr_task = 5;
            restore_answers();
            disable_confirm();
            get_texts();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            curr_task = 6;
            restore_answers();
            disable_confirm();
            get_texts();
        }


        private void Button8_Click(object sender, EventArgs e)
        {
            curr_task = 7;
            restore_answers();
            disable_confirm();
            get_texts();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            curr_task = 8;
            restore_answers();
            disable_confirm();
            get_texts();
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            curr_task = 9;
            restore_answers();
            disable_confirm();
            get_texts();
        }
        //=========================================================================================
        // Варианты ответа Radio Button
        private void Answer1_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (answer1_radio.Checked)
            {
                task[curr_task,3] = 1;
                taskAnswers[curr_task, 0] = answer1_radio.Checked;
            }
            if (!answer1_radio.Checked)
            {
                taskAnswers[curr_task, 0] = answer1_radio.Checked;
            }
        }

        private void Answer2_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (answer2_radio.Checked)
            {
                task[curr_task, 3] = 2;
                taskAnswers[curr_task, 1] = answer2_radio.Checked;
            }
            if (!answer2_radio.Checked)
            {
                taskAnswers[curr_task, 1] = answer2_radio.Checked;
            }
        }

        private void Answer3_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (answer3_radio.Checked)
            {
                task[curr_task, 3] = 3;
                taskAnswers[curr_task, 2] = answer3_radio.Checked;
            }
            if (!answer3_radio.Checked)
            {
                taskAnswers[curr_task, 2] = answer3_radio.Checked;
            }
        }

        private void Answer4_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (answer4_radio.Checked)
            {
                task[curr_task, 3] = 4;
                taskAnswers[curr_task, 3] = answer4_radio.Checked;
            }
            if (!answer4_radio.Checked)
            {
                taskAnswers[curr_task, 3] = answer4_radio.Checked;
            }
        }

        private void Answer5_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (answer5_radio.Checked)
            {
                task[curr_task, 3] = 5;
                taskAnswers[curr_task, 4] = answer5_radio.Checked;
            }
            if (!answer5_radio.Checked)
            {
                taskAnswers[curr_task, 4] = answer5_radio.Checked;
            }
        }
        //=========================================================================================
        private void Confirm_button_Click(object sender, EventArgs e)
        {
            task[curr_task, 4] = 1;
            check_answer();
            disable_confirm();
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaskNumber_label_Click(object sender, EventArgs e)
        {
            clicks += 1;
            if (clicks == 5)
            {
                for (int i = 0; i < 10; i++)
                {
                    answers_label.Text += task[i, 0].ToString();

                }
            }
        }

        private void Answers_label_Click(object sender, EventArgs e)
        {
            clicks -= 1;
            if (clicks == 0)
            {
                answers_label.Text = "" ;
            }
        }

        private void EndTest_button_Click(object sender, EventArgs e)
        {
            transfer();
            EndForm newForm = new EndForm();
            newForm.Show();
            this.Hide();
        }
        //=========================================================================================
    }
}