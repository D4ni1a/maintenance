using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text.Length!=0) && (textBox2.Text.Length != 0) 
                && (textBox3.Text.Length != 0) && (textBox4.Text.Length != 0)
                && (textBox5.Text.Length != 0) && (textBox6.Text.Length != 0))
            {
                try
                {
                    Program.Mass[0] = System.Convert.ToDouble(textBox1.Text);
                    Program.Mass[1] = System.Convert.ToDouble(textBox2.Text);
                    Program.Mass[2] = System.Convert.ToDouble(textBox3.Text);
                    Program.Mass[3] = System.Convert.ToDouble(textBox4.Text);
                    Program.Mass[4] = System.Convert.ToDouble(textBox5.Text);
                    Program.Mass[5] = System.Convert.ToDouble(textBox6.Text);
                    this.Close();
                    Form3 B = new Form3();
                    B.Show();
                }
                catch
                {
                    MessageBox.Show("Неверный формат введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите все значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
