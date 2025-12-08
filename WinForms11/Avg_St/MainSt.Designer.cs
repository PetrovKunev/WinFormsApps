using System.Drawing;
using System.Windows.Forms;

namespace Avg_St
{
    partial class MainSt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // --- Полета за контролите ---
        private Label labelClass;
        private Label labelNo;
        private Label labelName;
        private Label labelAverage;
        private TextBox textBoxClass;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private TextBox textBoxBEL;
        private TextBox textBoxForeign;
        private TextBox textBoxMath;
        private TextBox textBoxPhys;
        private TextBox textBoxChem;
        private TextBox textBoxBio;
        private Button buttonSave;
        private Button buttonClean;
        private Button buttonFind;

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

        private void InitializeComponent()
        {
            labelClass = new Label();
            labelNo = new Label();
            labelName = new Label();
            labelAverage = new Label();
            textBoxClass = new TextBox();
            textBoxId = new TextBox();
            textBoxName = new TextBox();
            textBoxBEL = new TextBox();
            textBoxForeign = new TextBox();
            textBoxMath = new TextBox();
            textBoxPhys = new TextBox();
            textBoxChem = new TextBox();
            textBoxBio = new TextBox();
            buttonSave = new Button();
            buttonClean = new Button();
            buttonFind = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Location = new Point(29, 33);
            labelClass.Margin = new Padding(4, 0, 4, 0);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(48, 25);
            labelClass.TabIndex = 15;
            labelClass.Text = "Клас";
            // 
            // labelNo
            // 
            labelNo.AutoSize = true;
            labelNo.Location = new Point(206, 33);
            labelNo.Margin = new Padding(4, 0, 4, 0);
            labelNo.Name = "labelNo";
            labelNo.Size = new Size(32, 25);
            labelNo.TabIndex = 14;
            labelNo.Text = "№";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(363, 33);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(47, 25);
            labelName.TabIndex = 13;
            labelName.Text = "Име";
            // 
            // labelAverage
            // 
            labelAverage.AutoSize = true;
            labelAverage.Location = new Point(29, 537);
            labelAverage.Margin = new Padding(4, 0, 4, 0);
            labelAverage.Name = "labelAverage";
            labelAverage.Size = new Size(121, 25);
            labelAverage.TabIndex = 12;
            labelAverage.Text = "Среден успех";
            // 
            // textBoxClass
            // 
            textBoxClass.Location = new Point(29, 67);
            textBoxClass.Margin = new Padding(4, 5, 4, 5);
            textBoxClass.Name = "textBoxClass";
            textBoxClass.Size = new Size(70, 31);
            textBoxClass.TabIndex = 11;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(206, 67);
            textBoxId.Margin = new Padding(4, 5, 4, 5);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(55, 31);
            textBoxId.TabIndex = 10;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(363, 67);
            textBoxName.Margin = new Padding(4, 5, 4, 5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(271, 31);
            textBoxName.TabIndex = 9;
            // 
            // textBoxBEL
            // 
            textBoxBEL.Location = new Point(29, 196);
            textBoxBEL.Margin = new Padding(4, 5, 4, 5);
            textBoxBEL.Name = "textBoxBEL";
            textBoxBEL.Size = new Size(170, 31);
            textBoxBEL.TabIndex = 8;
            // 
            // textBoxForeign
            // 
            textBoxForeign.Location = new Point(240, 196);
            textBoxForeign.Margin = new Padding(4, 5, 4, 5);
            textBoxForeign.Name = "textBoxForeign";
            textBoxForeign.Size = new Size(170, 31);
            textBoxForeign.TabIndex = 7;
            // 
            // textBoxMath
            // 
            textBoxMath.Location = new Point(29, 301);
            textBoxMath.Margin = new Padding(4, 5, 4, 5);
            textBoxMath.Name = "textBoxMath";
            textBoxMath.Size = new Size(170, 31);
            textBoxMath.TabIndex = 6;
            // 
            // textBoxPhys
            // 
            textBoxPhys.Location = new Point(464, 196);
            textBoxPhys.Margin = new Padding(4, 5, 4, 5);
            textBoxPhys.Name = "textBoxPhys";
            textBoxPhys.Size = new Size(170, 31);
            textBoxPhys.TabIndex = 5;
            // 
            // textBoxChem
            // 
            textBoxChem.Location = new Point(464, 301);
            textBoxChem.Margin = new Padding(4, 5, 4, 5);
            textBoxChem.Name = "textBoxChem";
            textBoxChem.Size = new Size(170, 31);
            textBoxChem.TabIndex = 4;
            // 
            // textBoxBio
            // 
            textBoxBio.Location = new Point(240, 301);
            textBoxBio.Margin = new Padding(4, 5, 4, 5);
            textBoxBio.Name = "textBoxBio";
            textBoxBio.Size = new Size(170, 31);
            textBoxBio.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(271, 422);
            buttonSave.Margin = new Padding(4, 5, 4, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(107, 38);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Запази";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClean
            // 
            buttonClean.Location = new Point(29, 422);
            buttonClean.Margin = new Padding(4, 5, 4, 5);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(107, 38);
            buttonClean.TabIndex = 2;
            buttonClean.Text = "Изчисти";
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += buttonClean_Click;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(500, 422);
            buttonFind.Margin = new Padding(4, 5, 4, 5);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(107, 38);
            buttonFind.TabIndex = 0;
            buttonFind.Text = "Търси";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 153);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 16;
            label1.Text = "БЕЛ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 153);
            label2.Name = "label2";
            label2.Size = new Size(33, 25);
            label2.TabIndex = 17;
            label2.Text = "ЧЕ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 258);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 18;
            label3.Text = "Математика";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 258);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 19;
            label4.Text = "Биология";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 258);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 20;
            label5.Text = "Химия";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 153);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 21;
            label6.Text = "Физика";
            // 
            // MainSt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 658);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonFind);
            Controls.Add(buttonSave);
            Controls.Add(buttonClean);
            Controls.Add(textBoxBio);
            Controls.Add(textBoxChem);
            Controls.Add(textBoxPhys);
            Controls.Add(textBoxMath);
            Controls.Add(textBoxForeign);
            Controls.Add(textBoxBEL);
            Controls.Add(textBoxName);
            Controls.Add(textBoxId);
            Controls.Add(textBoxClass);
            Controls.Add(labelAverage);
            Controls.Add(labelName);
            Controls.Add(labelNo);
            Controls.Add(labelClass);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainSt";
            Text = "Class Results";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
