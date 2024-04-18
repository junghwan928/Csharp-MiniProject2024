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
    public partial class SignUp : Form
    {
        Form4 logInForm;
        bool IdUnique = false;

        public SignUp()
        {
            InitializeComponent();
        }
        public SignUp(Form4 form)
        {
            InitializeComponent();
            logInForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IdUnique && textBox1.Text != "" && textBox2.Text != "")
            {
                if (radioButton1.Checked)
                {
                    UserInfo.IDAndPassward.Add(textBox1.Text, textBox2.Text);
                }
                else
                {
                    ManagerInfo.IDAndPassward.Add(textBox1.Text, textBox2.Text);
                }
                logInForm.Visible = true;
                Close();
            }
            else
            {
                MessageBox.Show("아이디와 비밀번호를 확인해 주세요");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text != "" && UserInfo.IDAndPassward != null && !UserInfo.IDAndPassward.ContainsKey(textBox1.Text.ToString()))
                {
                    IdUnique = true;
                    MessageBox.Show("해당 아이디는 사용가능 합니다");
                }
                else
                {
                    MessageBox.Show("해당 아이디는 이미 있습니다");
                }
            }
            else
            {
                if (textBox1.Text != "" && ManagerInfo.IDAndPassward != null && !ManagerInfo.IDAndPassward.ContainsKey(textBox1.Text.ToString()))
                {
                    IdUnique = true;
                    MessageBox.Show("해당 아이디는 사용가능 합니다");
                }
                else
                {
                    MessageBox.Show("해당 아이디는 이미 있습니다");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            IdUnique = false;
        }

    }
}
