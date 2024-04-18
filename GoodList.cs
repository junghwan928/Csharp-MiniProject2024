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
    public partial class GoodList : Form
    {

        public GoodList()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
        }

        private void QuestionList_Load(object sender, EventArgs e)
        {

        }
    }
}
