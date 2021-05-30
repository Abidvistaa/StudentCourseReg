
namespace StudentCourseReg
{
    partial class RegistrationStudent
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
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.deptCombo = new System.Windows.Forms.ComboBox();
            this.txtCgpa = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Salmon;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.addButton.Location = new System.Drawing.Point(397, 354);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(129, 45);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(206, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Name";
            // 
            // txtSname
            // 
            this.txtSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSname.Location = new System.Drawing.Point(397, 140);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(296, 32);
            this.txtSname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(232, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(283, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "CGPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(330, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Registration Student";
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Salmon;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.nextButton.Location = new System.Drawing.Point(560, 354);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(133, 45);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Show";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // deptCombo
            // 
            this.deptCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptCombo.FormattingEnabled = true;
            this.deptCombo.Items.AddRange(new object[] {
            "CSE",
            "EEE"});
            this.deptCombo.Location = new System.Drawing.Point(397, 200);
            this.deptCombo.Name = "deptCombo";
            this.deptCombo.Size = new System.Drawing.Size(137, 34);
            this.deptCombo.TabIndex = 9;
            // 
            // txtCgpa
            // 
            this.txtCgpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCgpa.Location = new System.Drawing.Point(397, 269);
            this.txtCgpa.Name = "txtCgpa";
            this.txtCgpa.Size = new System.Drawing.Size(296, 32);
            this.txtCgpa.TabIndex = 10;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Salmon;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.backButton.Location = new System.Drawing.Point(1, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 58);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RegistrationStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(932, 457);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.txtCgpa);
            this.Controls.Add(this.deptCombo);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "RegistrationStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ComboBox deptCombo;
        private System.Windows.Forms.TextBox txtCgpa;
        private System.Windows.Forms.Button backButton;
    }
}