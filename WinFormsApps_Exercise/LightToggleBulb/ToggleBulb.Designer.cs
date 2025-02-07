namespace LightToggleBulb
{
    partial class ToggleBulb
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
            pictureBoxBulb = new PictureBox();
            btnToggle = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBulb).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxBulb
            // 
            pictureBoxBulb.Image = Properties.Resources.BulbOff;
            pictureBoxBulb.Location = new Point(373, 46);
            pictureBoxBulb.Name = "pictureBoxBulb";
            pictureBoxBulb.Size = new Size(1017, 883);
            pictureBoxBulb.TabIndex = 0;
            pictureBoxBulb.TabStop = false;
            // 
            // btnToggle
            // 
            btnToggle.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnToggle.Location = new Point(373, 1052);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(1017, 144);
            btnToggle.TabIndex = 1;
            btnToggle.Text = "Превключи светлината";
            btnToggle.UseVisualStyleBackColor = true;
            btnToggle.Click += buttonToggle_Click;
            // 
            // ToggleBulb
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1816, 1335);
            Controls.Add(btnToggle);
            Controls.Add(pictureBoxBulb);
            Name = "ToggleBulb";
            Text = "Light Bulb";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBulb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxBulb;
        private Button btnToggle;
    }
}
