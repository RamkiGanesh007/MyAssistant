namespace MyAssistant
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Rough = new System.Windows.Forms.Button();
            this.QA = new System.Windows.Forms.Button();
            this.Projects = new System.Windows.Forms.Button();
            this.MyProgr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(1, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(1144, 550);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            // 
            // Rough
            // 
            this.Rough.BackColor = System.Drawing.Color.White;
            this.Rough.ForeColor = System.Drawing.Color.Black;
            this.Rough.Location = new System.Drawing.Point(-1, 1);
            this.Rough.Name = "Rough";
            this.Rough.Size = new System.Drawing.Size(169, 49);
            this.Rough.TabIndex = 1;
            this.Rough.Text = "Rough_Work";
            this.Rough.UseVisualStyleBackColor = false;
            this.Rough.Click += new System.EventHandler(this.button1_Click);
            // 
            // QA
            // 
            this.QA.BackColor = System.Drawing.Color.White;
            this.QA.ForeColor = System.Drawing.Color.Black;
            this.QA.Location = new System.Drawing.Point(169, 1);
            this.QA.Name = "QA";
            this.QA.Size = new System.Drawing.Size(169, 49);
            this.QA.TabIndex = 2;
            this.QA.Text = "QA\'s";
            this.QA.UseVisualStyleBackColor = false;
            this.QA.Click += new System.EventHandler(this.QA_Click);
            // 
            // Projects
            // 
            this.Projects.BackColor = System.Drawing.Color.White;
            this.Projects.ForeColor = System.Drawing.Color.Black;
            this.Projects.Location = new System.Drawing.Point(338, 1);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(169, 49);
            this.Projects.TabIndex = 3;
            this.Projects.Text = "Projects";
            this.Projects.UseVisualStyleBackColor = false;
            this.Projects.Click += new System.EventHandler(this.Projects_Click);
            // 
            // MyProgr
            // 
            this.MyProgr.BackColor = System.Drawing.Color.White;
            this.MyProgr.ForeColor = System.Drawing.Color.Black;
            this.MyProgr.Location = new System.Drawing.Point(507, 1);
            this.MyProgr.Name = "MyProgr";
            this.MyProgr.Size = new System.Drawing.Size(169, 49);
            this.MyProgr.TabIndex = 4;
            this.MyProgr.Text = "MyProgress";
            this.MyProgr.UseVisualStyleBackColor = false;
            this.MyProgr.Click += new System.EventHandler(this.MyProgr_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.MyProgr);
            this.Controls.Add(this.Projects);
            this.Controls.Add(this.QA);
            this.Controls.Add(this.Rough);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAssistant";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Rough;
        private System.Windows.Forms.Button QA;
        private System.Windows.Forms.Button Projects;
        private System.Windows.Forms.Button MyProgr;
    }
}

