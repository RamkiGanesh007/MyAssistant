using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAssistant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (Rough.BackColor == Color.Black || QA.BackColor == Color.Black || Projects.BackColor == Color.Black || MyProgr.BackColor == Color.Black)
            {
                this.Rough.BackColor = Color.White;
                this.Rough.ForeColor = Color.Black;
            }
            else
            {
                this.Rough.BackColor = Color.Black;
                this.Rough.ForeColor = Color.White;
            }
        }

        private void QA_Click(object sender, EventArgs e)
        {
            if (Rough.BackColor == Color.Black || QA.BackColor == Color.Black || Projects.BackColor == Color.Black || MyProgr.BackColor == Color.Black)
            {
                this.QA.BackColor = Color.White;
                this.QA.ForeColor = Color.Black;
            }
            else
            {
                this.QA.BackColor = Color.Black;
                this.QA.ForeColor = Color.White;
            }

        }

        private void Projects_Click(object sender, EventArgs e)
        {
            if (Rough.BackColor == Color.Black || QA.BackColor == Color.Black || Projects.BackColor == Color.Black || MyProgr.BackColor == Color.Black)
            {
                this.Projects.BackColor = Color.White;
                this.Projects.ForeColor = Color.Black;
            }
            else
            {
                this.Projects.BackColor = Color.Black;
                this.Projects.ForeColor = Color.White;
            }
        }

        private void MyProgr_Click(object sender, EventArgs e)
        {
            if (Rough.BackColor == Color.Black || QA.BackColor == Color.Black || Projects.BackColor == Color.Black || MyProgr.BackColor == Color.Black)
            {
                this.MyProgr.BackColor = Color.White;
                this.MyProgr.ForeColor = Color.Black;
            }
            else
            {
                this.MyProgr.BackColor = Color.Black;
                this.MyProgr.ForeColor = Color.White;
            }
           
        }
    }
}
