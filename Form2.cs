using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace korsunovwebform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Run_button_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            double a, b, c, hb;
            a = Convert.ToDouble(textA.Text); // считываем значение стороны a
            b = Convert.ToDouble(textB.Text); // считываем значение стороны a
            c = Convert.ToDouble(textC.Text); // считываем значение стороны a
            hb = Convert.ToDouble(textHB.Text); // считываем значение высоты hb
            Triangle triangle = new Triangle(a, b, c, hb); // создаем объект класса Triangle с именем triangle
            // добавляем соответствующие ячейки в коллекцию items объекта listview1
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c"); // (при клике на кнопку Запуск первый столбец заполнится этими нашими именами)
            listView1.Items.Add("Высота hb"); //
            listView1.Items.Add("Площадь"); //
            listView1.Items.Add("Существует?"); //
            listView1.Items.Add("Спецификатор"); //
            // методы по выводу сторон b, hb
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC()); // (Item'у с индексом [i] присваиваем значение сабайтема,)
            listView1.Items[3].SubItems.Add(triangle.outputHB()); //
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Ploshad())); // выводим площадь
            if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); } // свойство Triangle.exist
            else listView1.Items[5].SubItems.Add("Не существует");
            listView1.Items[6].SubItems.Add(triangle.TriangleType);
            if (triangle.TriangleType == "равносторонний")
            {
                pictureBox1.Image = Properties.Resources.ravnostor;
            }
            else if (triangle.TriangleType == "разносторонний")
            {
                pictureBox1.Image = Properties.Resources.raznostor;
            }
            else if (triangle.TriangleType == "равнобедренный")
            {
                pictureBox1.Image = Properties.Resources.ravnobedr;
            }
            else if (triangle.TriangleType=="невозможно")
            {
                pictureBox1.Image = Properties.Resources.vopros;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide(); // При нажатии любой клавиши первая форма скрывается, а вторая появляется
            Form1 MyForm1 = new Form1();
            MyForm1.ShowDialog();
            Close();
        }
    }
}
