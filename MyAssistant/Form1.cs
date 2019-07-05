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

        List<bool> bol = new List<bool> {};
        public MainForm()
        {
            InitializeComponent();
            bol.Add(boolean_declarationfun(RoughWork.BackColor));
            bol.Add(boolean_declarationfun(Projects.BackColor));
            bol.Add(boolean_declarationfun(MyIdeas.BackColor));
            bol.Add(boolean_declarationfun(QA.BackColor));

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        bool boolean_declarationfun(Color a)
        {
            if (a.Equals(Color.Black)) return true; else return false;
        }
       void fun(List<bool> a)
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



      
        private void RoughWork_Click(object sender, EventArgs e)
        {
            //UI Design Section
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
            //Ui Design Complete
            for(int i=0;bol.Count>i;i++) { bol[i]= false; };
            
            bol[0] = true;
            fun(bol);
            Environment.(TextArea.Text)
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
            for (int i = 0; bol.Count > i; i++) { bol[i] = false; };

            bol[1] = true;
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

            for (int i = 0; bol.Count > i; i++) { bol[i] = false; };

            bol[2] = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void TextArea_TextChanged(object sender, EventArgs e)
        {

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
            for (int i = 0; bol.Count > i; i++) { bol[i] = false; };

            bol[3] = true;
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

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
