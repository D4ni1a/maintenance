using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static Maintenance Mass = new Maintenance();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Maintenance
    {
        public double[] a; //Массив чисел с плавающей запятой
        public int len; //Переменная для размера массива
        public Maintenance()
        {
            len = 6;
            a = new double[6];
        }
        public double this[int index] //Индексатор для добавления и извлечения элементов
        {
            get
            {
                return a[index]; //Извлечение
            }
            set
            {
                a[index] = value; //Добавление
            }
        }
        public string Times(string n, string m, string b)
        {
            int c1 = System.Convert.ToInt32(n);// Количество СВТ
            int c2 = System.Convert.ToInt32(m); //Количество рабочих
            string check = b; //Строка, содержащая номера выполняемых операций ТО
            double time_label =0; //Хранит сумму времени работы программы

            foreach (char x in check) //Перебирает номера операций из переменной check
            {
                time_label += a[System.Convert.ToInt32(x)-48]; //Из массива, хранящего время операции извлекается значение и добавляется в time_label. 
                //(-48), потому что значения преобразуются в номера из таблицы ASCII, а не в сами значения
            }
            time_label = (time_label * c1) / c2; //Итоговая сумма = (Сумме*(Количество СВТ))/(Количество рабочих)

            return System.Convert.ToString(time_label);// Возвращает итоговую сумму в форме строки
        }
    }
}
