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

    public class MyException : Exception
    {
        public MyException(string message) : base(message) { }
    }

    public partial class Form1 : Form
    {
        private double registrRes;                      // регистр результата
        private double registrEnter;                    // регистр толькочто введунного значения
        public delegate void MyOperator();              // объявление делигата, который в себе будет хранить метод, на выполнение операции
        private KeyVal<bool, MyOperator> executableOperator;    // пара, в которой хранятся делигат выполняемого метода и информация о его выполнении
        private bool activateButton;                            // параметр, характеризующий активность основных логических кнопок
        private bool activateButtonVC_MR;                       // параметр, характеризующий активность основных логических кнопок
        private bool clickButtEqually = false;          // указывает, нажата ли кнопка '='
        MyOperator enterOperator;                       // объект делигата, хранит в себе выбранный оператор
        private string textBuff = "";                   // временный буфер, вкоторый записываются выполненые выражения
        private double memory;                          // дополнительная ячейка памяти, для запоминания числа (для работы с кнопками MC, MR, MS, -M, +M)

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
            // инициализация поля Tag кнопок арифметических бинарных операций объектами делигата хранящими соответствующие методы
            butt_sum.Tag = new MyOperator(sum);
            butt_sub.Tag = new MyOperator(substaction);
            butt_multi.Tag = new MyOperator(multiplication);
            butt_div.Tag = new MyOperator(division);

            butt_MR.Enabled = false;
            butt_MC.Enabled = false;
            activateButton = true;
            activateButtonVC_MR = false;
        }

        public void sum() { registrRes += registrEnter; }
        public void substaction() { registrRes -= registrEnter; }
        public void multiplication() { registrRes *= registrEnter; }
        public void division() 
        {
            if (registrEnter == 0) throw new MyException("Деление на 0");
            registrRes /= registrEnter; 
        }
        public void sgrt()
        {
            if (registrEnter < 0) throw new MyException("Нельзя взять квадратный корень отрицательного числа");
            registrEnter = Math.Sqrt(registrEnter);
        }
        public void oneDivX()
        {
            if (registrEnter == 0) throw new MyException("Деление на 0");
            registrEnter = 1.0 / registrEnter;
        }
        public void percent() { registrEnter = registrRes * registrEnter / 100; }

        // ввод цифровых клавиш
        private void buttDigit_Click(object sender, EventArgs e)
        {
            previousOperatorChecks(sender, e);                                                      // проверка на предшествующий оператор (если '=', то обнуление регистров)
            if ((bool)textBox_Enter.Tag == false)                                                    // проверяем, был ли введён первый символ
            {
                executableOperator = new KeyVal<bool, MyOperator>(false, enterOperator);             // добавляем операцию в очередь и помечаем, что она еще не произведена
                textBox_Enter.Text = ((Button)sender).Text;
                textBox_Enter.Tag = ((Button)sender).Text != "0" ? true : false;                     // помечаем, что первый символ введён
            }
            else if (textBox_Enter.Text.Length < 16)
            {
                textBox_Enter.Text += ((Button)sender).Text;
            }
            buttonUnlocking();
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
        // действия, при нажатии на кнопки арифметических операций и отлавливанием исключений
        private void operation(object sender, EventArgs e)
        {
            try
            {
                string s = ((Button)sender).Text;
                if (s == "=") { butt_Equally_Click(); }
                else if (s == "+" || s == "-" || s == "x" || s == "/") { buttBinaryOperator_Click(sender); }
                else
                {
                    registrEnter = Convert.ToDouble(textBox_Enter.Text);
                    if (s == "√") { butt_sqrt_Click(); }
                    else if (s == "%") { butt_percent_Click(); }
                    else if (s == "1/x") { butt_oneDivX_Click(); }
                    textBox_Enter.Text = registrEnter.ToString();
                }
            }
            catch (MyException ex) // деление на 0
            {
                processingExeption(ex.Message);
            }
            catch (Exception ex)
            {
                processingExeption(ex.Message);
            }
        }
        private void processingExeption(string message)
        {
            buttonLock();
            textBox_Enter.Text = message;
            textBox_Enter.Tag = false;
            enterOperator = null;
            executableOperator = new KeyVal<bool, MyOperator>(false, enterOperator);
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
        // обработка бинарных арифметических операций
        private void arithmeticProcessing()
        {
            try
            {
                if (executableOperator.Key == false)                                // проверка на то, не была ли проведенна операция, стоящая в очереди на выполнение (входим внутрь один раз за выбор операции)
                {
                    textBuff = textBox_Calculating.Text + (registrEnter >= 0 ? registrEnter.ToString() : string.Concat("(", registrEnter.ToString(), ")")) + " ";
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
            catch (MyException ex){throw ex;}
            catch (Exception ex) {throw ex;}
        }
        // действия, при нажатии кнопак, соответствующим бинарным арифметическим операциям
        private void buttBinaryOperator_Click(object sender)
        {
            registrEnter = Convert.ToDouble(textBox_Enter.Text);                // записываем число в регистр
            arithmeticProcessing();
            textBox_Calculating.Text = textBuff + ((Button)sender).Text + " ";
            enterOperator = (MyOperator)(((Button)sender).Tag);                 // выбираем операцию в очередь (в временный буфер)
            clickButtEqually = false;
        }
        // очистка регистра ввода
        private void butt_CE_Click(object sender, EventArgs e)
        {
            textBox_Enter.Text = "0";
            registrEnter = 0;
            textBox_Enter.Tag = false;                                     // показываем, что можно вводить числа с первого символа
        }
        // очистка регистра ввода и результата
        private void butt_C_Click(object sender, EventArgs e)
        {
            butt_CE_Click(sender, e);
            textBox_Calculating.Text = "";
            registrRes = 0;
        }
        // действие на нажатие '='
        private void butt_Equally_Click()
        {
            try
            {
                executableOperator = new KeyVal<bool, MyOperator>(false, enterOperator);            // добавляем операцию в очередь и помечаем, что она еще не произведена
                if ((bool)textBox_Enter.Tag == true || textBox_Enter.Text == "0")                                                // проверяем, был ли введён первый символ
                {
                    registrEnter = Convert.ToDouble(textBox_Enter.Text);                            // записываем число в регистр
                }
                clickButtEqually = true;
                arithmeticProcessing();
                textBox_Calculating.Text = "";
                textBuff = registrRes.ToString() + " ";
                buttonUnlocking();
            }
            catch (MyException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }
        // изменение знака
        private void butt_sign_Click(object sender, EventArgs e)
        {
            textBox_Enter.Text = textBox_Enter.Text[0] == '-' ? textBox_Enter.Text.Substring(1) : "-" + textBox_Enter.Text;
        }
        // получение квадратного корня
        private void butt_sqrt_Click()
        {
            textBox_Calculating.Text += "√(" +registrEnter.ToString() + ") ";
            sgrt();
        }
        // возведение числа в -1 степень
        private void butt_oneDivX_Click()
        {
            textBox_Calculating.Text += "1/(" + registrEnter.ToString() + ") ";
            oneDivX();
        }
        // действия, при нажатии кнопки '%'
        private void butt_percent_Click()
        {
            percent();
            textBox_Calculating.Text += registrEnter.ToString() + " ";
        }
        // отмена ввода последнего символа
        private void butt_arrow_Click(object sender, EventArgs e)
        {
            if ((bool)textBox_Enter.Tag == true)
            {
                if(textBox_Enter.Text.Length == 1)
                {
                    textBox_Enter.Text = "0";
                    textBox_Enter.Tag = false;
                }
                else
                {
                    int len = textBox_Enter.Text.Length;
                    textBox_Enter.Text = textBox_Enter.Text.Substring(0, len - 1);
                }
            }
        }
        // записываем число в дополнительную ячейку памяти
        private void butt_MS_Click(object sender, EventArgs e)
        {
            unlockingMC_MR();
            memory = Convert.ToDouble(textBox_Enter.Text);                          // записываем число в регистр
            textBox_Enter.Tag = false;
        }
        // считываем число из дополнительной ячейки памяти
        private void butt_MR_Click(object sender, EventArgs e)
        {
            textBox_Enter.Text = memory.ToString();
        }
        // очищаем дополнительную ячейку памяти
        private void butt_MC_Click(object sender, EventArgs e)
        {
            memory = 0;
            butt_MR.Enabled = false;
            butt_MC.Enabled = false;
        }
        // прибавляем чисо к значению в дополнительной ячейки памяти
        private void butt_Mplus_Click(object sender, EventArgs e)
        {
            unlockingMC_MR();
            memory += Convert.ToDouble(textBox_Enter.Text);
        }
        // отнимаем чисо из значения в дополнительной ячейки памяти
        private void butt_Mminus_Click(object sender, EventArgs e)
        {
            unlockingMC_MR();
            memory -= Convert.ToDouble(textBox_Enter.Text);
        }
        // блокировка кнопок
        private void buttonLock()
        {
            butt_1divX_Click.Enabled = false;
            butt_arrow.Enabled = false;
            butt_comma.Enabled = false;
            butt_div.Enabled = false;
            butt_MC.Enabled = false;
            butt_Mminus.Enabled = false;
            butt_Mplus.Enabled = false;
            butt_MR.Enabled = false;
            butt_MS.Enabled = false;
            butt_multi.Enabled = false;
            butt_percent.Enabled = false;
            butt_root.Enabled = false;
            butt_sign.Enabled = false;
            butt_sub.Enabled = false;
            butt_sum.Enabled = false;
            activateButton = false;
        }
        // активация основных логических кнопок
        private void buttonUnlocking()
        {
            if (activateButton == false)
            {
                textBox_Calculating.Text = "";
                butt_1divX_Click.Enabled = true;
                butt_arrow.Enabled = true;
                butt_comma.Enabled = true;
                butt_div.Enabled = true;
                butt_Mminus.Enabled = true;
                butt_Mplus.Enabled = true;
                butt_MS.Enabled = true;
                butt_multi.Enabled = true;
                butt_percent.Enabled = true;
                butt_root.Enabled = true;
                butt_sign.Enabled = true;
                butt_sub.Enabled = true;
                butt_sum.Enabled = true;
            }            
        }
        // активация кнопок MC и MR
        private void unlockingMC_MR()
        {
            if (activateButtonVC_MR == false)
            {
                butt_MR.Enabled = true;
                butt_MC.Enabled = true;
            }
        }
    }

}
