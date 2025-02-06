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
            lstAvailableProjects = new ListBox();
            lstSelectedProjects = new ListBox();
            label1 = new Label();
            label2 = new Label();
            cmbTeams = new ComboBox();
            lblSelectedProject = new Label();
            btnRemoveProject = new Button();
            btnEditAvailableProject = new Button();
            btnDeleteAvailableProject = new Button();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.Salmon;
            btnSelect.Font = new Font("Calibri", 28F);
            btnSelect.ForeColor = Color.Ivory;
            btnSelect.Location = new Point(891, 373);
            btnSelect.Margin = new Padding(6);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(539, 233);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Избери проект";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelectProject_Click;
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
            // cmbTeams
            // 
            cmbTeams.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbTeams.FormattingEnabled = true;
            cmbTeams.Location = new Point(853, 98);
            cmbTeams.Name = "cmbTeams";
            cmbTeams.Size = new Size(603, 67);
            cmbTeams.TabIndex = 6;
            // 
            // lblSelectedProject
            // 
            lblSelectedProject.AutoSize = true;
            lblSelectedProject.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedProject.ForeColor = Color.GhostWhite;
            lblSelectedProject.Location = new Point(599, 1151);
            lblSelectedProject.Margin = new Padding(6, 0, 6, 0);
            lblSelectedProject.Name = "lblSelectedProject";
            lblSelectedProject.Size = new Size(1052, 86);
            lblSelectedProject.TabIndex = 1;
            lblSelectedProject.Text = "_____________________________";
            // 
            // btnRemoveProject
            // 
            btnRemoveProject.BackColor = Color.Khaki;
            btnRemoveProject.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRemoveProject.ForeColor = SystemColors.InfoText;
            btnRemoveProject.Location = new Point(1640, 1019);
            btnRemoveProject.Name = "btnRemoveProject";
            btnRemoveProject.Size = new Size(600, 102);
            btnRemoveProject.TabIndex = 7;
            btnRemoveProject.Text = "Премахване на проект";
            btnRemoveProject.UseVisualStyleBackColor = false;
            btnRemoveProject.Click += btnRemoveProject_Click;
            // 
            // btnEditAvailableProject
            // 
            btnEditAvailableProject.BackColor = Color.YellowGreen;
            btnEditAvailableProject.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEditAvailableProject.ForeColor = SystemColors.ControlLightLight;
            btnEditAvailableProject.Location = new Point(74, 1019);
            btnEditAvailableProject.Name = "btnEditAvailableProject";
            btnEditAvailableProject.Size = new Size(289, 102);
            btnEditAvailableProject.TabIndex = 8;
            btnEditAvailableProject.Text = "Редактирай";
            btnEditAvailableProject.UseVisualStyleBackColor = false;
            btnEditAvailableProject.Click += btnEditAvailableProject_Click;
            // 
            // btnDeleteAvailableProject
            // 
            btnDeleteAvailableProject.BackColor = Color.Firebrick;
            btnDeleteAvailableProject.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteAvailableProject.ForeColor = SystemColors.ControlLightLight;
            btnDeleteAvailableProject.Location = new Point(385, 1019);
            btnDeleteAvailableProject.Name = "btnDeleteAvailableProject";
            btnDeleteAvailableProject.Size = new Size(289, 102);
            btnDeleteAvailableProject.TabIndex = 9;
            btnDeleteAvailableProject.Text = "Изтрий";
            btnDeleteAvailableProject.UseVisualStyleBackColor = false;
            btnDeleteAvailableProject.Click += btnDeleteAvailableProject_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(2308, 1278);
            Controls.Add(btnDeleteAvailableProject);
            Controls.Add(btnEditAvailableProject);
            Controls.Add(btnRemoveProject);
            Controls.Add(cmbTeams);
            Controls.Add(btnSelect);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstSelectedProjects);
            Controls.Add(lstAvailableProjects);
            Controls.Add(lblSelectedProject);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Select Projects";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelect;
        private ListBox lstAvailableProjects;
        private ListBox lstSelectedProjects;
        private Label label1;
        private Label label2;
        private ComboBox cmbTeams;
        private Label lblSelectedProject;
        private Button btnRemoveProject;
        private Button btnEditAvailableProject;
        private Button btnDeleteAvailableProject;
    }
}
