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
            this.RoughWork = new Bunifu.UI.WinForms.BunifuLabel();
            this.QA = new Bunifu.UI.WinForms.BunifuLabel();
            this.MyIdeas = new Bunifu.UI.WinForms.BunifuLabel();
            this.Projects = new Bunifu.UI.WinForms.BunifuLabel();
            this.MyProgress = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Home = new Bunifu.UI.WinForms.BunifuLabel();
            this.Exit = new Bunifu.UI.WinForms.BunifuLabel();
            this.Projects_Text = new System.Windows.Forms.RichTextBox();
            this.MyIdeas_Text = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TextArea
            // 
            this.TextArea.AcceptsTab = true;
            this.TextArea.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TextArea.EnableAutoDragDrop = true;
            this.TextArea.ForeColor = System.Drawing.Color.White;
            this.TextArea.Location = new System.Drawing.Point(1, 108);
            this.TextArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextArea.Name = "TextArea";
            this.TextArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextArea.Size = new System.Drawing.Size(1255, 596);
            this.TextArea.TabIndex = 0;
            this.TextArea.Text = "";
            this.TextArea.TextChanged += new System.EventHandler(this.TextArea_TextChanged);
            this.TextArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            // 
            // RoughWork
            // 
            this.RoughWork.AutoEllipsis = true;
            this.RoughWork.AutoSize = false;
            this.RoughWork.BackColor = System.Drawing.Color.Black;
            this.RoughWork.CursorType = null;
            this.RoughWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoughWork.ForeColor = System.Drawing.Color.White;
            this.RoughWork.Location = new System.Drawing.Point(6, 56);
            this.RoughWork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoughWork.Name = "RoughWork";
            this.RoughWork.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RoughWork.Size = new System.Drawing.Size(200, 49);
            this.RoughWork.TabIndex = 6;
            this.RoughWork.Text = "RoughWork";
            this.RoughWork.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RoughWork.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.RoughWork.Click += new System.EventHandler(this.RoughWork_Click);
            // 
            // QA
            // 
            this.QA.AutoEllipsis = true;
            this.QA.AutoSize = false;
            this.QA.BackColor = System.Drawing.Color.Black;
            this.QA.CursorType = null;
            this.QA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QA.ForeColor = System.Drawing.Color.White;
            this.QA.Location = new System.Drawing.Point(209, 56);
            this.QA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QA.Name = "QA";
            this.QA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QA.Size = new System.Drawing.Size(200, 49);
            this.QA.TabIndex = 7;
            this.QA.Text = "QA\'s";
            this.QA.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.QA.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.QA.Click += new System.EventHandler(this.QA_Click);
            // 
            // MyIdeas
            // 
            this.MyIdeas.AutoEllipsis = true;
            this.MyIdeas.AutoSize = false;
            this.MyIdeas.BackColor = System.Drawing.Color.Black;
            this.MyIdeas.CursorType = null;
            this.MyIdeas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyIdeas.ForeColor = System.Drawing.Color.White;
            this.MyIdeas.Location = new System.Drawing.Point(609, 56);
            this.MyIdeas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MyIdeas.Name = "MyIdeas";
            this.MyIdeas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MyIdeas.Size = new System.Drawing.Size(200, 49);
            this.MyIdeas.TabIndex = 8;
            this.MyIdeas.Text = "MyIdeas";
            this.MyIdeas.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyIdeas.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MyIdeas.Click += new System.EventHandler(this.MyIdeas_Click);
            // 
            // Projects
            // 
            this.Projects.AutoEllipsis = true;
            this.Projects.AutoSize = false;
            this.Projects.BackColor = System.Drawing.Color.Black;
            this.Projects.CursorType = null;
            this.Projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects.ForeColor = System.Drawing.Color.White;
            this.Projects.Location = new System.Drawing.Point(409, 56);
            this.Projects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Projects.Name = "Projects";
            this.Projects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Projects.Size = new System.Drawing.Size(200, 49);
            this.Projects.TabIndex = 9;
            this.Projects.Text = "Projects";
            this.Projects.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Projects.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.Projects.Click += new System.EventHandler(this.Projects_Click);
            // 
            // MyProgress
            // 
            this.MyProgress.AutoEllipsis = true;
            this.MyProgress.AutoSize = false;
            this.MyProgress.BackColor = System.Drawing.Color.Black;
            this.MyProgress.CursorType = null;
            this.MyProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyProgress.ForeColor = System.Drawing.Color.White;
            this.MyProgress.Location = new System.Drawing.Point(811, 56);
            this.MyProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MyProgress.Name = "MyProgress";
            this.MyProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MyProgress.Size = new System.Drawing.Size(200, 49);
            this.MyProgress.TabIndex = 10;
            this.MyProgress.Text = "MyProgress";
            this.MyProgress.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyProgress.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MyProgress.Click += new System.EventHandler(this.MyProgress_Click);
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
            // Home
            // 
            this.Home.AutoEllipsis = true;
            this.Home.AutoSize = false;
            this.Home.BackColor = System.Drawing.Color.Black;
            this.Home.CursorType = null;
            this.Home.Font = new System.Drawing.Font("Courier New", 27.75F);
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(511, 2);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Home.Name = "Home";
            this.Home.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Home.Size = new System.Drawing.Size(372, 49);
            this.Home.TabIndex = 12;
            this.Home.Text = "MyAssistant";
            this.Home.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Home.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Exit
            // 
            this.Exit.AutoEllipsis = true;
            this.Exit.AutoSize = false;
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.CursorType = null;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(1209, 11);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Exit.Size = new System.Drawing.Size(48, 33);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "X";
            this.Exit.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Exit.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Projects_Text
            // 
            this.Projects_Text.AcceptsTab = true;
            this.Projects_Text.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Projects_Text.EnableAutoDragDrop = true;
            this.Projects_Text.ForeColor = System.Drawing.Color.White;
            this.Projects_Text.Location = new System.Drawing.Point(1, 108);
            this.Projects_Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.MyIdeas_Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox3.Size = new System.Drawing.Size(1255, 596);
            this.richTextBox3.TabIndex = 16;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1257, 708);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.MyProgress);
            this.Controls.Add(this.Projects);
            this.Controls.Add(this.MyIdeas);
            this.Controls.Add(this.QA);
            this.Controls.Add(this.RoughWork);
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
        private Bunifu.UI.WinForms.BunifuLabel RoughWork;
        private Bunifu.UI.WinForms.BunifuLabel QA;
        private Bunifu.UI.WinForms.BunifuLabel MyIdeas;
        private Bunifu.UI.WinForms.BunifuLabel Projects;
        private Bunifu.UI.WinForms.BunifuLabel MyProgress;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuLabel Home;
        private Bunifu.UI.WinForms.BunifuLabel Exit;
        private System.Windows.Forms.RichTextBox Projects_Text;
        private System.Windows.Forms.RichTextBox MyIdeas_Text;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}

