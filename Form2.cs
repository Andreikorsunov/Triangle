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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide(); // При нажатии любой клавиши первая форма скрывается, а вторая появляется
            Form1 MyForm1 = new Form1();f
            MyForm1.ShowDialog();
            Close();
        }
    }
}
