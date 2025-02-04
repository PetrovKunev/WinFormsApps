namespace SelectProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelect = new Button();
            lblSelectedProject = new Label();
            lstAvailableProjects = new ListBox();
            lstSelectedProjects = new ListBox();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(255, 128, 128);
            btnSelect.Font = new Font("Calibri", 28F);
            btnSelect.ForeColor = Color.LawnGreen;
            btnSelect.Location = new Point(482, 46);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(290, 109);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Избери проект";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += this.btnSelectProject_Click;
            // 
            // lblSelectedProject
            // 
            lblSelectedProject.AutoSize = true;
            lblSelectedProject.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedProject.ForeColor = SystemColors.ButtonHighlight;
            lblSelectedProject.Location = new Point(471, 261);
            lblSelectedProject.Name = "lblSelectedProject";
            lblSelectedProject.Size = new Size(104, 42);
            lblSelectedProject.TabIndex = 1;
            lblSelectedProject.Text = "label1";
            // 
            // lstAvailableProjects
            // 
            lstAvailableProjects.FormattingEnabled = true;
            lstAvailableProjects.ItemHeight = 15;
            lstAvailableProjects.Location = new Point(40, 46);
            lstAvailableProjects.Name = "lstAvailableProjects";
            lstAvailableProjects.Size = new Size(325, 454);
            lstAvailableProjects.TabIndex = 2;
            // 
            // lstSelectedProjects
            // 
            lstSelectedProjects.FormattingEnabled = true;
            lstSelectedProjects.ItemHeight = 15;
            lstSelectedProjects.Location = new Point(883, 46);
            lstSelectedProjects.Name = "lstSelectedProjects";
            lstSelectedProjects.Size = new Size(325, 454);
            lstSelectedProjects.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1243, 599);
            Controls.Add(lstSelectedProjects);
            Controls.Add(lstAvailableProjects);
            Controls.Add(lblSelectedProject);
            Controls.Add(btnSelect);
            Name = "MainForm";
            Text = "Select Projects";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelect;
        private Label lblSelectedProject;
        private ListBox lstAvailableProjects;
        private ListBox lstSelectedProjects;
    }
}
