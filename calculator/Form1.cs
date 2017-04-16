using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public struct KeyVal<K, V>                      // структа пары
        {
            public K Key;
            public V Val;
            public KeyVal(K key, V val)
            {
                Key = key;
                Val = val;
            }
        }
        private double registrRes;                      // регистр результата
        private double registrEnter;                    // регистр толькочто введунного значения
        public delegate void MyOperator();              // объявление делигата, который в себе будет хранить метод, на выполнение операции
        KeyVal<bool, MyOperator> executableOperator;    // пара, в которой хранятся делигат выполняемого метода и информация о его выполнении
        MyOperator enterOperator;                       // объект делигата, хранит в себе выбранный оператор
        private string buff = "";                       // временный буфер, вкоторый записываются выполненые выражения
        private bool clickButtEqually = false;          // указывает, нажата ли кнопка '='

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enterOperator = null;                                                       // показываем, что метод оператора не выбран
            executableOperator = new KeyVal<bool, MyOperator>(false, enterOperator);     // начальная инициализация пары значений, в которой хранятся делигат выполняемого метода и информация о его выполнении
            textBox_Enter.Text = "0";
            textBox_Enter.Tag = false;                                                   // показываем, что ввод цифр еще не производился
            // инициализация поля Tag кнопок арифметических операций объектами делигата хранящими соответствующие методы
            butt_sum.Tag = new MyOperator(sum);
            butt_sub.Tag = new MyOperator(substaction);
            butt_multi.Tag = new MyOperator(multiplication);
            butt_div.Tag = new MyOperator(division);         
        }

        public void sum() { registrRes += registrEnter; }
        public void substaction() { registrRes -= registrEnter; }
        public void multiplication() { registrRes *= registrEnter; }
        public void division() { registrRes /= registrEnter; }
        public void sgrt() { registrEnter = Math.Sqrt(registrEnter); }
        public void oneDivX() { registrEnter = 1.0 / registrEnter; }
        public void percent() { registrEnter = registrRes * registrEnter / 100; }

        // ввод цифровых клавиш
        private void buttDigit_Click(object sender, EventArgs e)
        {
            previousOperatorChecks(sender, e);                                                      // проверка на предшествующий оператор (если '=', то обнуление регистров)
            if ((bool)textBox_Enter.Tag == false)                                                    // проверяем, был ли введён первый символ
            {
                executableOperator = new KeyVal<bool, MyOperator>(false, enterOperator);             // добавляем операцию в очередь и помечаем, что она еще не произведена
                textBox_Enter.Text = ((Button)sender).Text;
                textBox_Enter.Tag = true;                                                           // помечаем, что первый символ введён
            }
            else if (textBox_Enter.Text.Length < 16)
            {
                textBox_Enter.Text += ((Button)sender).Text;
            }
        }

        // действие по нажатию ","
        private void butt_comma_Click(object sender, EventArgs e)
        {
            previousOperatorChecks(sender, e);                                                      // проверка на предшествующий оператор (если '=', то обнуление регистров)

            if ((bool)textBox_Enter.Tag == false)                                                    // проверяем, был ли введён первый символ
            {
                textBox_Enter.Text = "0,";
                textBox_Enter.Tag = true;
            }  
            else if (textBox_Enter.Text.IndexOf(',', 0) == -1)
            {                              
                buttDigit_Click(sender, e);
            }
        }
        // проверка на предшествующий оператор (если '=' то обнуление регистров)
        private void previousOperatorChecks(object sender, EventArgs e)
        {
            if (clickButtEqually == true)
            {
                butt_C_Click(sender, e);
                clickButtEqually = false;
            }
        }
        
        // обработка арифметических операций
        private void arithmeticProcessing()
        {            
            if (executableOperator.Key == false)                                // проверка на то, не была ли проведенна операция, стоящая в очереди на выполнение (входим внутрь один раз за выбор операции)
            {
                buff = textBox_Calculating.Text + (registrEnter > 0 ? textBox_Enter.Text : string.Concat("(",textBox_Enter.Text,")")) + " ";
                if (executableOperator.Val != null)                              // проверка на наличие операции в очереди
                {
                    executableOperator.Val.DynamicInvoke();                     // вызов метода
                }
                else
                {
                    registrRes = registrEnter;
                }
                textBox_Enter.Text = registrRes.ToString();
                textBox_Enter.Tag = false;                                     // показываем, что можно вводить числа с первого символа
                executableOperator.Key = true;                                 // показываем, что операция, стоящая в очереди, произведена
            }

        }
        
        // действия, при нажатии кнопак, соответствующим арифметическим операциям
        private void buttBinaryOperator_Click(object sender, EventArgs e)
        {
            registrEnter = Convert.ToDouble(textBox_Enter.Text);                // записываем число в регистр
            arithmeticProcessing();
            textBox_Calculating.Text = buff + ((Button)sender).Text + " ";
            enterOperator = (MyOperator)(((Button)sender).Tag);                 // выбираем операцию в очередь (в временный буфер)
            clickButtEqually = false;
        }

        private void butt_CE_Click(object sender, EventArgs e)
        {
            textBox_Enter.Text = "0";
            registrRes = 0;
        }

        private void butt_C_Click(object sender, EventArgs e)
        {
            butt_CE_Click(sender, e);
            textBox_Calculating.Text = "";
            registrEnter = 0;
        }

        private void butt_Equally_Click(object sender, EventArgs e)
        {
            executableOperator = new KeyVal<bool, MyOperator>(false, enterOperator);            // добавляем операцию в очередь и помечаем, что она еще не произведена
            if ((bool)textBox_Enter.Tag == true)                                                // проверяем, был ли введён первый символ
            {
                registrEnter = Convert.ToDouble(textBox_Enter.Text);                            // записываем число в регистр
            }
            clickButtEqually = true;
            arithmeticProcessing();
            textBox_Calculating.Text = "";
            buff = registrRes.ToString() + " ";
        }

        private void butt_sign_Click(object sender, EventArgs e)
        {
            textBox_Enter.Text = textBox_Enter.Text[0] == '-' ? textBox_Enter.Text.Substring(1) : "-" + textBox_Enter.Text;
        }

        private void butt_root_Click(object sender, EventArgs e)
        {
            registrEnter = Convert.ToDouble(textBox_Enter.Text);                          // записываем число в регистр
            textBox_Calculating.Text += "√(" +registrEnter.ToString() + ") ";
            registrEnter = Math.Sqrt(registrEnter);
            textBox_Enter.Text = registrEnter.ToString();
        }

        private void butt_1divX_Click_Click(object sender, EventArgs e)
        {
            registrEnter = Convert.ToDouble(textBox_Enter.Text);                          // записываем число в регистр
            textBox_Calculating.Text += "1/(" + registrEnter.ToString() + ") ";
            registrEnter = 1.0 / registrEnter;
            textBox_Enter.Text = registrEnter.ToString();
        }

        private void butt_percent_Click(object sender, EventArgs e)
        {
            registrEnter = Convert.ToDouble(textBox_Enter.Text);                          // записываем число в регистр
            registrEnter = registrRes * registrEnter / 100;
            textBox_Calculating.Text += registrEnter.ToString() + " ";
            textBox_Enter.Text = registrEnter.ToString();
        }
    }
}
