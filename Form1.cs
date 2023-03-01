using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pract12_Kovyazin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(textBox1.Text);
            double y1 = double.Parse(textBox2.Text);
            double z1 = double.Parse(textBox3.Text);
            double x2 = double.Parse(textBox4.Text);
            double y2 = double.Parse(textBox5.Text);
            double z2 = double.Parse(textBox6.Text);
            if (x1 == 0 || y1 == 0 || z1 == 0 || x2 == 0 || y2 == 0 || z2 == 0)
            {
                MessageBox.Show("Ноль нельзя", "Ошибка");
            }
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (!Char.IsNumber(textBox1.Text[i]))
                {
                    MessageBox.Show("Можно использовать только цифры", "Ошибка");
                    break;
                }
            }
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                if (!Char.IsNumber(textBox2.Text[i]))
                {
                    MessageBox.Show("Можно использовать только цифры", "Ошибка");
                    break;
                }
            }
            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                if (!Char.IsNumber(textBox3.Text[i]))
                {
                    MessageBox.Show("Можно использовать только цифры", "Ошибка");
                    break;
                }
            }
            for (int i = 0; i < textBox4.Text.Length; i++)
            {
                if (!Char.IsNumber(textBox4.Text[i]))
                {
                    MessageBox.Show("Можно использовать только цифры", "Ошибка");
                    break;
                }
            }
            for (int i = 0; i < textBox5.Text.Length; i++)
            {
                if (!Char.IsNumber(textBox5.Text[i]))
                {
                    MessageBox.Show("Можно использовать только цифры", "Ошибка");
                    break;
                }
            }
            for (int i = 0; i < textBox6.Text.Length; i++)
            {
                if (!Char.IsNumber(textBox6.Text[i]))
                {
                    MessageBox.Show("Можно использовать только цифры", "Ошибка");
                    break;
                }
            }
            Vector3D v1 = new Vector3D(x1, y1, z1);
            Vector3D v2 = new Vector3D(x2, y2, z2);
            Vector3D sum = v1.Add(v2);
            Vector3D difference = v1.Subtract(v2);
            double dotPr = v1.DotPr(v2);
            double length = v1.Length();
            double cosine = v1.Cosine(v2);
            MessageBox.Show($"Сумма : {sum}" + "\n" + $"Разность: {difference}" + "\n" + $"Скалярное произведение: {dotPr}" + "\n" + $"Длина: {length}" + "\n" + $"Косинус угла между векторами {cosine}");

        }
    }
}
