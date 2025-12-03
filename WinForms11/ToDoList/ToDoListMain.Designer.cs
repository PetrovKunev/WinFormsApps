namespace ToDoList
{
    partial class ToDoListMain
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
            txtNewTask = new TextBox();
            lstTasks = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnComplete = new Button();
            SuspendLayout();
            // 
            // txtNewTask
            // 
            txtNewTask.Location = new Point(111, 89);
            txtNewTask.Name = "txtNewTask";
            txtNewTask.Size = new Size(283, 31);
            txtNewTask.TabIndex = 0;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 25;
            lstTasks.Location = new Point(555, 99);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(369, 554);
            lstTasks.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(102, 196);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(292, 104);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добави";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(102, 372);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(292, 104);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Изтрий избраната";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(102, 549);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(292, 104);
            btnComplete.TabIndex = 4;
            btnComplete.Text = "Маркирай като готова";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // ToDoListMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 752);
            Controls.Add(btnComplete);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstTasks);
            Controls.Add(txtNewTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ToDoListMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToDoList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewTask;
        private ListBox lstTasks;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnComplete;
    }
}
