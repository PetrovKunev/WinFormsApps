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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnSelect = new Button();
            lblSelectedProject = new Label();
            lstAvailableProjects = new ListBox();
            lstSelectedProjects = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(255, 128, 128);
            btnSelect.FlatStyle = FlatStyle.Popup;
            btnSelect.Font = new Font("Calibri", 28F);
            btnSelect.ForeColor = Color.LawnGreen;
            btnSelect.Location = new Point(895, 98);
            btnSelect.Margin = new Padding(6);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(539, 233);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Избери проект";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelectProject_Click;
            // 
            // lblSelectedProject
            // 
            lblSelectedProject.AutoSize = true;
            lblSelectedProject.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedProject.ForeColor = Color.GhostWhite;
            lblSelectedProject.Location = new Point(808, 548);
            lblSelectedProject.Margin = new Padding(6, 0, 6, 0);
            lblSelectedProject.Name = "lblSelectedProject";
            lblSelectedProject.Size = new Size(807, 86);
            lblSelectedProject.TabIndex = 1;
            lblSelectedProject.Text = "______________________";
            // 
            // lstAvailableProjects
            // 
            lstAvailableProjects.BackColor = SystemColors.Info;
            lstAvailableProjects.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstAvailableProjects.FormattingEnabled = true;
            lstAvailableProjects.ItemHeight = 66;
            lstAvailableProjects.Location = new Point(74, 98);
            lstAvailableProjects.Margin = new Padding(6);
            lstAvailableProjects.Name = "lstAvailableProjects";
            lstAvailableProjects.Size = new Size(600, 862);
            lstAvailableProjects.TabIndex = 2;
            // 
            // lstSelectedProjects
            // 
            lstSelectedProjects.BackColor = SystemColors.Info;
            lstSelectedProjects.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstSelectedProjects.FormattingEnabled = true;
            lstSelectedProjects.ItemHeight = 66;
            lstSelectedProjects.Location = new Point(1640, 98);
            lstSelectedProjects.Margin = new Padding(6);
            lstSelectedProjects.Name = "lstSelectedProjects";
            lstSelectedProjects.Size = new Size(600, 862);
            lstSelectedProjects.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(74, 43);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(303, 46);
            label1.TabIndex = 4;
            label1.Text = "Налични проекти";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(1640, 43);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(301, 46);
            label2.TabIndex = 5;
            label2.Text = "Избрани проекти";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(2308, 1278);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstSelectedProjects);
            Controls.Add(lstAvailableProjects);
            Controls.Add(lblSelectedProject);
            Controls.Add(btnSelect);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
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
        private Label label1;
        private Label label2;
    }
}
