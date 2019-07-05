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
            this.RoughWork = new Bunifu.UI.WinForms.BunifuLabel();
            this.QA = new Bunifu.UI.WinForms.BunifuLabel();
            this.MyIdeas = new Bunifu.UI.WinForms.BunifuLabel();
            this.Projects = new Bunifu.UI.WinForms.BunifuLabel();
            this.MyProgress = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Home = new Bunifu.UI.WinForms.BunifuLabel();
            this.Exit = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(1, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(942, 485);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            // 
            // RoughWork
            // 
            this.RoughWork.AutoEllipsis = true;
            this.RoughWork.AutoSize = false;
            this.RoughWork.BackColor = System.Drawing.Color.Black;
            this.RoughWork.CursorType = null;
            this.RoughWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoughWork.ForeColor = System.Drawing.Color.White;
            this.RoughWork.Location = new System.Drawing.Point(5, 45);
            this.RoughWork.Name = "RoughWork";
            this.RoughWork.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RoughWork.Size = new System.Drawing.Size(150, 40);
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
            this.QA.Location = new System.Drawing.Point(156, 45);
            this.QA.Name = "QA";
            this.QA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QA.Size = new System.Drawing.Size(150, 40);
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
            this.MyIdeas.Location = new System.Drawing.Point(457, 45);
            this.MyIdeas.Name = "MyIdeas";
            this.MyIdeas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MyIdeas.Size = new System.Drawing.Size(150, 40);
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
            this.Projects.Location = new System.Drawing.Point(307, 45);
            this.Projects.Name = "Projects";
            this.Projects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Projects.Size = new System.Drawing.Size(150, 40);
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
            this.MyProgress.Location = new System.Drawing.Point(608, 45);
            this.MyProgress.Name = "MyProgress";
            this.MyProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MyProgress.Size = new System.Drawing.Size(150, 40);
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
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(43, 40);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(44, 41);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(331, 2);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(44, 41);
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
            this.Home.Location = new System.Drawing.Point(383, 2);
            this.Home.Name = "Home";
            this.Home.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Home.Size = new System.Drawing.Size(279, 40);
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
            this.Exit.Location = new System.Drawing.Point(907, 9);
            this.Exit.Name = "Exit";
            this.Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Exit.Size = new System.Drawing.Size(36, 27);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "X";
            this.Exit.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Exit.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(943, 575);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.MyProgress);
            this.Controls.Add(this.Projects);
            this.Controls.Add(this.MyIdeas);
            this.Controls.Add(this.QA);
            this.Controls.Add(this.RoughWork);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAssistant";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private Bunifu.UI.WinForms.BunifuLabel RoughWork;
        private Bunifu.UI.WinForms.BunifuLabel QA;
        private Bunifu.UI.WinForms.BunifuLabel MyIdeas;
        private Bunifu.UI.WinForms.BunifuLabel Projects;
        private Bunifu.UI.WinForms.BunifuLabel MyProgress;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuLabel Home;
        private Bunifu.UI.WinForms.BunifuLabel Exit;
    }
}

