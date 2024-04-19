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
    public partial class Form4 : Form
    {
        GoodList questionList;

        enum ELoginType
        {
            MANAGER,
            COMMON,
        }
        public Form4()
        {
            InitializeComponent();
            questionList = new GoodList();
        }

       

        //일반로그인
        private void button3_Click(object sender, EventArgs e)
        {
            if (IsPWRight(ELoginType.COMMON))
            {
                
                GoodList commonQuestionList = new GoodList(); // 일반 사용자용 GoodList 인스턴스 생성
                commonQuestionList.label2.Text = "(사용자용)";
                commonQuestionList.button1.Visible = false;
                commonQuestionList.Show();
            }
        }

        //관리자용 로그인
        private void button2_Click(object sender, EventArgs e)
        {
            if (IsPWRight(ELoginType.MANAGER))
            {
                GoodList managerQuestionList = new GoodList(); // 관리자용 GoodList 인스턴스 생성
                managerQuestionList.label2.Text = "(관리자용)";
                managerQuestionList.button1.Visible = true;
                managerQuestionList.Show();
            }
        }

        bool IsPWRight(ELoginType eLoginType)
        {
            switch (eLoginType)
            {
                case ELoginType.MANAGER:
                    if (ManagerInfo.IDAndPassward.ContainsKey(textBox1.Text.ToString()))
                    {
                        if (ManagerInfo.IDAndPassward[textBox1.Text.ToString()].Equals(textBox2.Text.ToString()))
                        {
                            return true;
                        }
                    }
                    break;
                case ELoginType.COMMON:
                    if (UserInfo.IDAndPassward.ContainsKey(textBox1.Text.ToString()))
                    {
                        if (UserInfo.IDAndPassward[textBox1.Text.ToString()].Equals(textBox2.Text.ToString()))
                        {
                            return true;
                        }
                    }
                    break;
            }
            
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SignUp signUp = new SignUp(this);
            signUp.Show();
        }
    }

    public static class UserInfo
    {
        public static Dictionary<string, string> IDAndPassward = new Dictionary<string, string>();
    }
    public static class ManagerInfo
    {
        public static Dictionary<string, string> IDAndPassward = new Dictionary<string, string>();
    }
}
