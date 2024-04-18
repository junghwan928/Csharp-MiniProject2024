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
    public partial class Form2 : Form
    {
        Form3 PForm;
        static int RadioIndex = 0;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form3 form)
        {
            InitializeComponent();
            PForm = form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (label1.Text.Contains("CHECKBOX"))
                {
                    PForm.checkedListBox1.Items.Add(textBox1.Text);
                }
                else if (label1.Text.Contains("RADIOBUTTON"))
                {
                    if (RadioIndex == 0)
                    {
                        PForm.radioButton1.Text = textBox1.Text;
                        RadioIndex++;
                    }
                    else if (RadioIndex == 1)
                    {
                        PForm.radioButton2.Text = textBox1.Text;
                        RadioIndex++;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("라디오버튼을 초기화 하시겠습니까??");
                        if(result == DialogResult.OK)
                        {
                            RadioIndex = 0;
                            button1_Click(sender, e);
                        }
                    }
                }else if (label1.Text.Contains("TEXTBOX"))
                {
                    PForm.textBox1.Visible = true;
                }
            }
            Close();
        }
    }
}
