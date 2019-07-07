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
            this.TextArea = new System.Windows.Forms.RichTextBox();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Projects_Text = new System.Windows.Forms.RichTextBox();
            this.MyIdeas_Text = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.RoughWork = new System.Windows.Forms.Label();
            this.QA = new System.Windows.Forms.Label();
            this.Projects = new System.Windows.Forms.Label();
            this.MyIdeas = new System.Windows.Forms.Label();
            this.MyProgress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextArea
            // 
            this.TextArea.AcceptsTab = true;
            this.TextArea.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TextArea.EnableAutoDragDrop = true;
            this.TextArea.ForeColor = System.Drawing.Color.White;
            this.TextArea.Location = new System.Drawing.Point(2, 109);
            this.TextArea.Margin = new System.Windows.Forms.Padding(4);
            this.TextArea.Name = "TextArea";
            this.TextArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextArea.Size = new System.Drawing.Size(1255, 596);
            this.TextArea.TabIndex = 0;
            this.TextArea.Text = "";
            this.TextArea.TextChanged += new System.EventHandler(this.TextArea_TextChanged);
            this.TextArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 1;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(58, 49);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(59, 50);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(441, 2);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(59, 50);
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 1;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Projects_Text
            // 
            this.Projects_Text.AcceptsTab = true;
            this.Projects_Text.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Projects_Text.EnableAutoDragDrop = true;
            this.Projects_Text.ForeColor = System.Drawing.Color.White;
            this.Projects_Text.Location = new System.Drawing.Point(1, 108);
            this.Projects_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Projects_Text.Name = "Projects_Text";
            this.Projects_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Projects_Text.Size = new System.Drawing.Size(1255, 596);
            this.Projects_Text.TabIndex = 14;
            this.Projects_Text.Text = "";
            // 
            // MyIdeas_Text
            // 
            this.MyIdeas_Text.AcceptsTab = true;
            this.MyIdeas_Text.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MyIdeas_Text.EnableAutoDragDrop = true;
            this.MyIdeas_Text.ForeColor = System.Drawing.Color.White;
            this.MyIdeas_Text.Location = new System.Drawing.Point(0, 108);
            this.MyIdeas_Text.Margin = new System.Windows.Forms.Padding(4);
            this.MyIdeas_Text.Name = "MyIdeas_Text";
            this.MyIdeas_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MyIdeas_Text.Size = new System.Drawing.Size(1255, 596);
            this.MyIdeas_Text.TabIndex = 15;
            this.MyIdeas_Text.Text = "";
            this.MyIdeas_Text.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.AcceptsTab = true;
            this.richTextBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox3.EnableAutoDragDrop = true;
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(0, 108);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox3.Size = new System.Drawing.Size(1255, 596);
            this.richTextBox3.TabIndex = 16;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // RoughWork
            // 
            this.RoughWork.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoughWork.Location = new System.Drawing.Point(12, 56);
            this.RoughWork.Name = "RoughWork";
            this.RoughWork.Size = new System.Drawing.Size(203, 48);
            this.RoughWork.TabIndex = 17;
            this.RoughWork.Text = "RoughWork";
            this.RoughWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RoughWork.Click += new System.EventHandler(this.RoughWork_Click);
            // 
            // QA
            // 
            this.QA.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QA.Location = new System.Drawing.Point(199, 57);
            this.QA.Name = "QA";
            this.QA.Size = new System.Drawing.Size(203, 48);
            this.QA.TabIndex = 18;
            this.QA.Text = "QA\'s";
            this.QA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QA.Click += new System.EventHandler(this.QA_Click);
            // 
            // Projects
            // 
            this.Projects.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects.Location = new System.Drawing.Point(408, 57);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(203, 48);
            this.Projects.TabIndex = 19;
            this.Projects.Text = "Projects";
            this.Projects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Projects.Click += new System.EventHandler(this.Projects_Click);
            // 
            // MyIdeas
            // 
            this.MyIdeas.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyIdeas.Location = new System.Drawing.Point(617, 57);
            this.MyIdeas.Name = "MyIdeas";
            this.MyIdeas.Size = new System.Drawing.Size(203, 48);
            this.MyIdeas.TabIndex = 20;
            this.MyIdeas.Text = "MyIdeas";
            this.MyIdeas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyIdeas.Click += new System.EventHandler(this.MyIdeas_Click);
            // 
            // MyProgress
            // 
            this.MyProgress.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyProgress.Location = new System.Drawing.Point(819, 57);
            this.MyProgress.Name = "MyProgress";
            this.MyProgress.Size = new System.Drawing.Size(203, 48);
            this.MyProgress.TabIndex = 21;
            this.MyProgress.Text = "MyProgress";
            this.MyProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyProgress.Click += new System.EventHandler(this.MyProgress_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 48);
            this.label6.TabIndex = 22;
            this.label6.Text = "MyAssistant";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1257, 708);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MyProgress);
            this.Controls.Add(this.MyIdeas);
            this.Controls.Add(this.Projects);
            this.Controls.Add(this.QA);
            this.Controls.Add(this.RoughWork);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.TextArea);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.MyIdeas_Text);
            this.Controls.Add(this.Projects_Text);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAssistant";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextArea;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.RichTextBox Projects_Text;
        private System.Windows.Forms.RichTextBox MyIdeas_Text;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label RoughWork;
        private System.Windows.Forms.Label QA;
        private System.Windows.Forms.Label Projects;
        private System.Windows.Forms.Label MyIdeas;
        private System.Windows.Forms.Label MyProgress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}

