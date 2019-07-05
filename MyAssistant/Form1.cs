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
        bool Roughb, QAb, Projectsb, MyProgrb;  // White ==false && Black ==true
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
        void boolean_declarationfun()
        {

        }
       



      
        private void RoughWork_Click(object sender, EventArgs e)
        {
            this.RoughWork.BackColor = Color.White;
            this.RoughWork.ForeColor = Color.Black;

            this.QA.BackColor = Color.Black;
            this.QA.ForeColor = Color.White;

            this.MyIdeas.BackColor = Color.Black;
            this.MyIdeas.ForeColor = Color.White;

            this.Projects.BackColor = Color.Black;
            this.Projects.ForeColor = Color.White;

            this.MyProgress.BackColor = Color.Black;
            this.MyProgress.ForeColor = Color.White;
        }

        private void QA_Click(object sender, EventArgs e)
        {
            this.RoughWork.BackColor = Color.Black;
            this.RoughWork.ForeColor = Color.White;

            this.QA.BackColor = Color.White;
            this.QA.ForeColor = Color.Black;

            this.MyIdeas.BackColor = Color.Black;
            this.MyIdeas.ForeColor = Color.White;

            this.Projects.BackColor = Color.Black;
            this.Projects.ForeColor = Color.White;

            this.MyProgress.BackColor = Color.Black;
            this.MyProgress.ForeColor = Color.White;
        }

        private void MyIdeas_Click(object sender, EventArgs e)
        {
            this.RoughWork.BackColor = Color.Black;
            this.RoughWork.ForeColor = Color.White;

            this.QA.BackColor = Color.Black;
            this.QA.ForeColor = Color.White;

            this.MyIdeas.BackColor = Color.White;
            this.MyIdeas.ForeColor = Color.Black;

            this.Projects.BackColor = Color.Black;
            this.Projects.ForeColor = Color.White;

            this.MyProgress.BackColor = Color.Black;
            this.MyProgress.ForeColor = Color.White;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.RoughWork.BackColor = Color.White;
            this.RoughWork.ForeColor = Color.Black;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void Projects_Click(object sender, EventArgs e)
        {
            this.RoughWork.BackColor = Color.Black;
            this.RoughWork.ForeColor = Color.White;

            this.QA.BackColor = Color.Black;
            this.QA.ForeColor = Color.White;

            this.MyIdeas.BackColor = Color.Black;
            this.MyIdeas.ForeColor = Color.White;

            this.Projects.BackColor = Color.White;
            this.Projects.ForeColor = Color.Black;

            this.MyProgress.BackColor = Color.Black;
            this.MyProgress.ForeColor = Color.White;
        }

        private void MyProgress_Click(object sender, EventArgs e)
        {
            this.RoughWork.BackColor = Color.Black;
            this.RoughWork.ForeColor = Color.White;

            this.QA.BackColor = Color.Black;
            this.QA.ForeColor = Color.White;

            this.MyIdeas.BackColor = Color.Black;
            this.MyIdeas.ForeColor = Color.White;

            this.Projects.BackColor = Color.Black;
            this.Projects.ForeColor = Color.White;

            this.MyProgress.BackColor = Color.White;
            this.MyProgress.ForeColor = Color.Black;
        }



        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                
            }
        }
    }
}
