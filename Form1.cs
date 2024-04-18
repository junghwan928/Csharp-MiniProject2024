using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace firstProjectCSharp {
    public partial class Form1 : Form
    {
        DateTime StartDateTime;
        int QueryCount;
        GoodList QuestionList;

        public Form1()
        {
            InitializeComponent();
            StartDateTime = DateTime.Now;
            comboBox1.Items.Add("NONE");
            comboBox1.Items.Add("CHECKBOX");
            comboBox1.Items.Add("RADIOBUTTON");
            comboBox1.Items.Add("TEXTBOX");
            QueryCount = 1;
        }

        public Form1(GoodList questionList) : this(){
                QuestionList = questionList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕");
        }


        private void testPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);

            form3.label1.Text = "재고관리 " + QueryCount++;

            switch (comboBox1.Text)
            {
                case "NONE":
                    return;
                case "CHECKBOX":
                    form3.checkedListBox1.Visible = true;
                    break;
                case "RADIOBUTTON":
                    form3.radioButton1.Visible = true;
                    form3.radioButton2.Visible = true;
                    break;
                case "TEXTBOX":
                    form3.textBox1.Visible = true;
                    break;
            }

            form3.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (QuestionList != null) {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("제고 물품을 입력하세요");
                }
                else
                {
                    QuestionList.flowLayoutPanel1.Controls.Add(flowLayoutPanel1);
                    Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("등록 되었습니다");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
