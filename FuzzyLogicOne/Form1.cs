using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyLogicOne
{
    public partial class Form1 : Form
    {
        public string Result;
        public float TempRes1 = 0, TempRes2 = 0;
        public float C1 = 1, C2 = 7;

        public Form1()
        {
            InitializeComponent();
        }

        public bool checkInts(TextBox a, TextBox b, TextBox c, TextBox d)
        {
            if (a.Text == "" || b.Text == "" || c.Text == "" || d.Text == "")
            {
                MessageBox.Show("Одне чи декілька полів меж інтервалів пусті",
                "Помилка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
                unCheckButt();
                return false;

            }
            else if (float.Parse(a.Text) > float.Parse(b.Text) || float.Parse(c.Text) > float.Parse(d.Text))
            {
                MessageBox.Show("Некорректні значення меж інтервалів",
                "Помилка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                unCheckButt();
                return false;
            }
            else 
                return true;
        }

        private void zeroDivision() 
        { 
            MessageBox.Show("Ділення на нуль заборонено",
            "Помилка",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1);
        }

        private void unCheckButt()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ця програма дає можливість виконати прості арифметичні операції над інтервалами довіри.\n" +
               "Для того, щоб виконати розрахунок, введіть значення границь інтервалів до відведених полів, \n" +
               "при цьому зверніть увагу, що ліва межа інтервалу не може бути більше правої межі.\n\n" +
               "Після цього виберіть варіант арифметичної операції зі списку, та натисніть на кнопку 'Розрахувати'. \n\n" +
               "Для візуалізації результата необхідно натиснути на кнопку 'Графік'.\n\n" +
               "Для того, щоб виконати дію над трьома і більше інтервалами, після виконання частини задачі,\n" +
               "натисніть на кнопку 'Результат до А/В' та виконайте частину, що залишилася.",
               "Manual",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
        }

        
        //інтервал A:
        private void label1_Click(object sender, EventArgs e) { }
        
        //інтервал B:
        private void label2_Click(object sender, EventArgs e) { }
        
        //інтервал С:
        private void label3_Click(object sender, EventArgs e) { }
        
        //Результат:
        private void label4_Click(object sender, EventArgs e) { }
        
        //Оберіть операцію:
        private void label5_Click(object sender, EventArgs e) { }
        
        //Чітке число k:
        private void label6_Click(object sender, EventArgs e) { }
        
        //Графічне представлення:
        private void label7_Click(object sender, EventArgs e) { }


        //Розрахунок:
        private void button1_Click(object sender, EventArgs e) 
        {
            textBox8.Text = Result;
        }

        //Результат в А:
        private void button2_Click(object sender, EventArgs e) 
        {
            textBox1.Text = TempRes1.ToString();
            textBox2.Text = TempRes2.ToString();
        }
        
        //Результат в В:
        private void button3_Click(object sender, EventArgs e) 
        {
            textBox3.Text = TempRes1.ToString();
            textBox4.Text = TempRes2.ToString();
        }
        
        //Результат в С:
        private void button4_Click(object sender, EventArgs e) 
        {
            if (textBox7.Enabled == false)
            {
                if (textBox5.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("Будь ласка, заповнiть усi iнтервали!",
                    "Помилка!",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                    textBox5.Text = null;
                    textBox6.Text = null;
                }
                else if (float.Parse(textBox5.Text) > float.Parse(textBox6.Text))
                {
                    MessageBox.Show("Ви ввели неккоректнi значення границь iнтервала",
                    "Помилка!",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                    textBox5.Text = null;
                    textBox6.Text = null;
                }
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Будь ласка, заповнiть усi iнтервали!",
                "Помилка!",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                textBox7.Text = null;
            }
        }
        
        //Очистити результат:
        private void button5_Click(object sender, EventArgs e) 
        {
            textBox8.Text = null;
            Result = null;
            unCheckButt();
        }
        
        //Очистити дані:
        private void button6_Click(object sender, EventArgs e) 
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }
        
        //Інформація:
        private void button7_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Ця програма дає можливість виконати прості арифметичні операції над інтервалами довіри.\n" +
               "Для того, щоб виконати розрахунок, введіть значення границь інтервалів до відведених полів, \n" +
               "при цьому зверніть увагу, що ліва межа інтервалу не може бути більше правої межі.\n\n" +
               "Після цього виберіть варіант арифметичної операції зі списку, та натисніть на кнопку 'Розрахувати'. \n\n" +
               "Для візуалізації результата необхідно натиснути на кнопку 'Графік'.\n\n" +
               "Для того, щоб виконати дію над трьома і більше інтервалами, після виконання частини задачі,\n" +
               "натисніть на кнопку 'Результат до А/В' та виконайте частину, що залишилася.",
               "Manual",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
        }
        
        //Графік:
        private void button8_Click(object sender, EventArgs e) 
        {
            Pen AxisPen = new Pen(Color.Black, 1);
            AxisPen.EndCap = LineCap.ArrowAnchor;
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawLine(AxisPen, 0, 70, 245, 70);
            g.DrawLine(AxisPen, 125, 140, 125, 1);
            int zero1 = 125, zero2 = 70;
            if (checkInts(textBox1, textBox2, textBox3, textBox4))
            {
                float a1 = float.Parse(textBox1.Text);
                float a2 = float.Parse(textBox2.Text);
                float b1 = float.Parse(textBox3.Text);
                float b2 = float.Parse(textBox4.Text);
                float r1 = TempRes1;
                float r2 = TempRes2;
                float resc1 = C1;
                float resc2 = C2;
                if ((a2 - a1) < 10 || (b2 - b1) < 10) { a1 *= 10; a2 *= 10; b1 *= 10; b2 *= 10; r1 *= 10; r2 *= 10; }
                else if ((a2 - a1) > 100 || (b2 - b1) > 100) { a1 /= 10; a2 /= 10; b1 /= 10; b2 /= 10; r1 /= 10; r2 /= 10; }
                Pen Graph1 = new Pen(Color.Green, 3);
                g.DrawLine(Graph1, zero1 + a1, zero2 - 5, zero1 + a2, zero2 - 5);
                Pen Graph2 = new Pen(Color.Red, 3);
                g.DrawLine(Graph2, zero1 + b1, zero2 + 5, zero1 + b2, zero2 + 5);
                Pen Graph3 = new Pen(Color.BlueViolet, 3);
                g.DrawLine(Graph3, zero1 + r1, zero2, zero1 + r2, zero2);
            }
        }
        
        //Очистити графік:
        private void button9_Click(object sender, EventArgs e) 
        {
            pictureBox1.Image = null;
        }


        //Перше значення інтервала А:
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        
        //Останнє значення інтервала А:
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        
        //Перше значення інтервала В:
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        
        //Останнє значення інтервала В:
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        
        //Перше значення інтервала С:
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        
        //Останнє значення інтервала С:
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        
        //Значення чіткого числа k:
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        
        //Виведення результату:
        private void textBox8_TextChanged(object sender, EventArgs e) { }


        //Додавання інтервалів довіри:
        private void radioButton1_CheckedChanged(object sender, EventArgs e) 
        {
            if (radioButton1.Checked)
            {
                if (checkInts(textBox1, textBox2, textBox3, textBox4))
                {
                    float a1 = float.Parse(textBox1.Text), a2 = float.Parse(textBox2.Text);
                    float b1 = float.Parse(textBox3.Text), b2 = float.Parse(textBox4.Text);
                    float resA = a1 + b1, resB = a2 + b2;
                    TempRes1 = resA;
                    TempRes2 = resB;
                    Result = $"A + B = [{resA.ToString()} , {resB.ToString()}]";

                }
                else
                    radioButton1.Checked = false;
            }
        }

        //Віднімання інтервалів довіри:
        private void radioButton2_CheckedChanged(object sender, EventArgs e) 
        {
            if (radioButton2.Checked)
            {
                if (checkInts(textBox1, textBox2, textBox3, textBox4))
                {
                    float a1 = float.Parse(textBox1.Text), a2 = float.Parse(textBox2.Text);
                    float b1 = float.Parse(textBox3.Text), b2 = float.Parse(textBox4.Text);
                    float resA = a1 - b2, resB = a2 - b1;
                    TempRes1 = resA;
                    TempRes2 = resB;
                    Result = $"A - B = [{resA.ToString()} , {resB.ToString()}]";
                }
                else
                    radioButton2.Checked = false;
            }
        }

        //Представлення чіткого числа у вигляді інтервалу довіри:
        private void radioButton3_CheckedChanged(object sender, EventArgs e) 
        {
            Result = $"[l,l] = [-4,-4]";
        }

        //Відображення інтервалу довіри:
        private void radioButton4_CheckedChanged(object sender, EventArgs e) 
        {
            if (radioButton4.Checked)
            {
                if (checkInts(textBox1, textBox2, textBox3, textBox4))
                {
                    float a1 = float.Parse(textBox1.Text), a2 = float.Parse(textBox2.Text);
                    float resA = 0 - a2, resB = 0 - a1;
                    TempRes1 = resA;
                    TempRes2 = resB;
                    Result = $"[{resA.ToString()} , {resB.ToString()}]";
                }
                else
                    radioButton4.Checked = false;
            }
        }

        //Множення інтервалів довіри:
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                if (checkInts(textBox1, textBox2, textBox3, textBox4))
                {
                    float a1 = float.Parse(textBox1.Text), a2 = float.Parse(textBox2.Text);
                    float b1 = float.Parse(textBox3.Text), b2 = float.Parse(textBox4.Text);
                    float[] res = new float[4];
                    res[0] = a1 * b1;
                    res[1] = a1 * b2;
                    res[2] = a2 * b1;
                    res[3] = a2 * b2;
                    float min = 99999, max = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (res[i] < min) { min = res[i]; }
                        if (res[i] > max) { max = res[i]; }
                    }
                    TempRes1 = min;
                    TempRes2 = max;
                    Result = $"A * B = [{min.ToString()} , {max.ToString()}]";
                    min = 99999;
                    max = 0;
                }
                else
                    radioButton5.Checked = false;
            }
        }

        //Ділення інтервалів довіри:
        private void radioButton6_CheckedChanged(object sender, EventArgs e) 
        {
            if (radioButton6.Checked)
            {
                if (checkInts(textBox1, textBox2, textBox3, textBox4))
                {
                    float a1 = float.Parse(textBox1.Text), a2 = float.Parse(textBox2.Text);
                    float b1 = float.Parse(textBox3.Text), b2 = float.Parse(textBox4.Text);
                    if (b1 == 0 || b2 == 0)
                    {
                        zeroDivision();
                        radioButton6.Checked = false;
                    }
                    else
                    {
                        float resA = a1 / b2, resB = a2 / b1;
                        TempRes1 = resA;
                        TempRes2 = resB;
                        Result = $"A / B = [{resA.ToString()} , {resB.ToString()}]";
                    }
                }
                else
                    radioButton6.Checked = false;
            }
        }

        //Інверсія інтервалу довіри:
        private void radioButton7_CheckedChanged(object sender, EventArgs e) 
        {
            if (radioButton7.Checked)
            {
                if (checkInts(textBox1, textBox2, textBox3, textBox4))
                {
                    float a1 = float.Parse(textBox1.Text), a2 = float.Parse(textBox2.Text);
                    if (a1 == 0 || a2 == 0)
                    {
                        zeroDivision();
                        radioButton7.Checked = false;
                    }
                    else if ((a1 < 0 && a2 > 0) || (a1 > 0 && a2 < 0))
                    {
                        MessageBox.Show("Неможливе ділення!\nЗначення повинно бути в множині R+",
                        "Помилка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                        unCheckButt();
                    }
                    else
                    {
                        float resA = 1 / a2, resB = 1 / a1;
                        TempRes1 = resA;
                        TempRes2 = resB;
                        Result = $"A Inverse = [{resA.ToString()} , {resB.ToString()}]";
                    }
                }
                else
                    radioButton7.Checked = false;
            }
        }

        //Множення (ділення) інтервалу довіри на невід'ємне число:
        private void radioButton8_CheckedChanged(object sender, EventArgs e) 
        {
            if (radioButton8.Checked)
            {
                if (checkInts(textBox1, textBox2, textBox3, textBox4))
                {
                    float a1 = float.Parse(textBox1.Text), a2 = float.Parse(textBox2.Text);
                    if (a1 == 0 || a2 == 0)
                    {
                        zeroDivision();
                        radioButton8.Checked = false;
                    }
                    else
                    {
                        float k = 4; ///оскільки за формулою k>0, то змінимо -4 на +4
                        float resA = k * a1, resB = k * a2;
                        TempRes1 = resA;
                        TempRes2 = resB;
                        Result = $"k * A = [{resA.ToString()} , {resB.ToString()}]";
                    }
                }
                else
                    radioButton8.Checked = false;
            }
        }

        //Знаходження максимуму двох інтервалів:
        private void radioButton9_CheckedChanged(object sender, EventArgs e) 
        {
            if (radioButton9.Checked)
            {
                if (checkInts(textBox1, textBox2, textBox3, textBox4))
                {
                    float a1 = float.Parse(textBox1.Text), a2 = float.Parse(textBox2.Text);
                    float b1 = float.Parse(textBox3.Text), b2 = float.Parse(textBox4.Text);
                    float resA, resB;
                    if (a1 < b1) { resA = a1; } else { resA = b1; }
                    if (a2 > b2) { resB = a2; } else { resB = b2; }
                    TempRes1 = resA;
                    TempRes2 = resB;
                    Result = $"A MAX B = [{resA.ToString()} , {resB.ToString()}]";
                }
                else
                    radioButton9.Checked = false;
            }
        }

        //Знаходження мінімуму двох інтервалів:
        private void radioButton10_CheckedChanged(object sender, EventArgs e) 
        {
            if (radioButton10.Checked)
            {
                if (checkInts(textBox1, textBox2, textBox3, textBox4))
                {
                    float a1 = float.Parse(textBox1.Text), a2 = float.Parse(textBox2.Text);
                    float b1 = float.Parse(textBox3.Text), b2 = float.Parse(textBox4.Text);
                    float resA, resB;
                    if (a1 > b1) { resA = a1; } else { resA = b1; }
                    if (a2 < b2) { resB = a2; } else { resB = b2; }
                    TempRes1 = resA;
                    TempRes2 = resB;
                    Result = $"A MIN B = [{resA.ToString()} , {resB.ToString()}]";
                }
                else
                    radioButton10.Checked = false;
            }
        }

        //Множення декількох інтервалів:
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                if (checkInts(textBox1, textBox2, textBox3, textBox4))
                {
                    float a1 = float.Parse(textBox1.Text), a2 = float.Parse(textBox2.Text);
                    float b1 = float.Parse(textBox3.Text), b2 = float.Parse(textBox4.Text);
                    float[] res = new float[8];
                    res[0] = a1 * b1 * C1;
                    res[1] = a1 * b1 * C2;
                    res[2] = a1 * b2 * C1;
                    res[3] = a1 * b2 * C2;
                    res[4] = a2 * b1 * C1;
                    res[5] = a2 * b1 * C2;
                    res[6] = a2 * b2 * C1;
                    res[7] = a2 * b2 * C2;
                    float min = 99999, max = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        if (res[i] < min) { min = res[i]; }
                        if (res[i] > max) { max = res[i]; }
                    }
                    TempRes1 = min;
                    TempRes2 = max;
                    Result = $"A * B * C = [{min.ToString()} , {max.ToString()}]";
                }
                else
                    radioButton11.Checked = false;
            }
            else
                radioButton11.Checked = false;
    }


        //Візуалізація графіка:
        private void pictureBox1_Click(object sender, EventArgs e) { } 

    }
}

/*Не дуже працює інтервал С, бо за формулами ОНЛ його нікуди впіхнути. Але основні разрахунки програма робить*/