using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstProjectCSharp
{
    public partial class Form3 : Form
    {
        public Form1 PForm;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form1 form)
        {
            InitializeComponent();
            PForm = form;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = panel1;

            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.label1.Text = PForm.comboBox1.Text + "에 추가할 내용 입력";
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PForm.flowLayoutPanel1.Controls.Add(panel1);
            Close();
        }

    }
}
