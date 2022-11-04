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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            toolTip1.SetToolTip(checkBox1, System.Convert.ToString(Program.Mass.a[0])+" ч.");
            toolTip2.SetToolTip(checkBox2, System.Convert.ToString(Program.Mass.a[3]) + " ч.");
            toolTip3.SetToolTip(checkBox3, System.Convert.ToString(Program.Mass.a[4]) + " ч.");
            toolTip4.SetToolTip(checkBox4, System.Convert.ToString(Program.Mass.a[1]) + " ч.");
            toolTip5.SetToolTip(checkBox5, System.Convert.ToString(Program.Mass.a[5]) + " ч.");
            toolTip6.SetToolTip(checkBox6, System.Convert.ToString(Program.Mass.a[2]) + " ч.");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (((checkBox1.Checked) || (checkBox2.Checked) || (checkBox3.Checked) || (checkBox4.Checked)
                || (checkBox5.Checked) || (checkBox6.Checked)) && (textBox1.Text.Length != 0)
                && (textBox2.Text.Length != 0))
            {
                string count = "";
                if (checkBox1.Checked) count += 0;
                if (checkBox2.Checked) count += 3;
                if (checkBox3.Checked) count += 4;
                if (checkBox4.Checked) count += 1;
                if (checkBox5.Checked) count += 5;
                if (checkBox6.Checked) count += 2;

                string res = "Для проведения ТО:\n\n";

                if (checkBox1.Checked) res += ("- " + checkBox1.Text + "\n");
                if (checkBox2.Checked) res += ("- " + checkBox2.Text + "\n");
                if (checkBox3.Checked) res += ("- " + checkBox3.Text + "\n");
                if (checkBox4.Checked) res += ("- " + checkBox4.Text + "\n");
                if (checkBox5.Checked) res += ("- " + checkBox5.Text + "\n");
                if (checkBox6.Checked) res += ("- " + checkBox6.Text + "\n");

                res += ("\nНа " + textBox1.Text + " ЭВМ\t" + "C " + textBox2.Text + " работниками\n");
                string result = Program.Mass.Times(textBox1.Text, textBox2.Text, count);
                res += ("\nПотребуется: " + result + " ч.");
                MessageBox.Show(res, "Результат ТО", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Введите все необходимые данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
