
namespace StudentCourseReg
{
    partial class AssignCourse
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
            this.backButton = new System.Windows.Forms.Button();
            this.coursesectionidCombo = new System.Windows.Forms.ComboBox();
            this.coursenameCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.secidCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sectionidCombo = new System.Windows.Forms.Label();
            this.addsecButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.courseidCombo = new System.Windows.Forms.ComboBox();
            this.showcourseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Salmon;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.backButton.Location = new System.Drawing.Point(1, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 58);
            this.backButton.TabIndex = 30;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // coursesectionidCombo
            // 
            this.coursesectionidCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesectionidCombo.FormattingEnabled = true;
            this.coursesectionidCombo.Items.AddRange(new object[] {
            "10",
            "20"});
            this.coursesectionidCombo.Location = new System.Drawing.Point(374, 267);
            this.coursesectionidCombo.Name = "coursesectionidCombo";
            this.coursesectionidCombo.Size = new System.Drawing.Size(129, 34);
            this.coursesectionidCombo.TabIndex = 29;
            // 
            // coursenameCombo
            // 
            this.coursenameCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursenameCombo.FormattingEnabled = true;
            this.coursenameCombo.Items.AddRange(new object[] {
            "C#",
            "Java",
            "DLD"});
            this.coursenameCombo.Location = new System.Drawing.Point(374, 199);
            this.coursenameCombo.Name = "coursenameCombo";
            this.coursenameCombo.Size = new System.Drawing.Size(129, 34);
            this.coursenameCombo.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(194, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 52);
            this.label4.TabIndex = 26;
            this.label4.Text = "Add Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(138, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Course-Sec ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(146, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(183, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Course ID";
            // 
            // addCourseButton
            // 
            this.addCourseButton.BackColor = System.Drawing.Color.LightCoral;
            this.addCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.addCourseButton.Location = new System.Drawing.Point(374, 362);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(129, 58);
            this.addCourseButton.TabIndex = 21;
            this.addCourseButton.Text = "Add";
            this.addCourseButton.UseVisualStyleBackColor = false;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(913, 227);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 30);
            this.radioButton2.TabIndex = 47;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(836, 229);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 30);
            this.radioButton1.TabIndex = 46;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // secidCombo
            // 
            this.secidCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secidCombo.FormattingEnabled = true;
            this.secidCombo.Items.AddRange(new object[] {
            "10",
            "20"});
            this.secidCombo.Location = new System.Drawing.Point(836, 146);
            this.secidCombo.Name = "secidCombo";
            this.secidCombo.Size = new System.Drawing.Size(129, 34);
            this.secidCombo.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(634, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 26);
            this.label5.TabIndex = 43;
            this.label5.Text = "Section Name";
            // 
            // sectionidCombo
            // 
            this.sectionidCombo.AutoSize = true;
            this.sectionidCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionidCombo.ForeColor = System.Drawing.Color.DarkBlue;
            this.sectionidCombo.Location = new System.Drawing.Point(671, 146);
            this.sectionidCombo.Name = "sectionidCombo";
            this.sectionidCombo.Size = new System.Drawing.Size(113, 26);
            this.sectionidCombo.TabIndex = 42;
            this.sectionidCombo.Text = "Section ID";
            // 
            // addsecButton
            // 
            this.addsecButton.BackColor = System.Drawing.Color.LightCoral;
            this.addsecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsecButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.addsecButton.Location = new System.Drawing.Point(836, 361);
            this.addsecButton.Name = "addsecButton";
            this.addsecButton.Size = new System.Drawing.Size(139, 59);
            this.addsecButton.TabIndex = 41;
            this.addsecButton.Text = "Add";
            this.addsecButton.UseVisualStyleBackColor = false;
            this.addsecButton.Click += new System.EventHandler(this.addsecButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label7.Location = new System.Drawing.Point(707, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 52);
            this.label7.TabIndex = 48;
            this.label7.Text = "Add Section";
            // 
            // courseidCombo
            // 
            this.courseidCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseidCombo.FormattingEnabled = true;
            this.courseidCombo.Items.AddRange(new object[] {
            "100",
            "200",
            "300"});
            this.courseidCombo.Location = new System.Drawing.Point(374, 131);
            this.courseidCombo.Name = "courseidCombo";
            this.courseidCombo.Size = new System.Drawing.Size(129, 34);
            this.courseidCombo.TabIndex = 49;
            // 
            // showcourseButton
            // 
            this.showcourseButton.BackColor = System.Drawing.Color.LightCoral;
            this.showcourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcourseButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.showcourseButton.Location = new System.Drawing.Point(595, 446);
            this.showcourseButton.Name = "showcourseButton";
            this.showcourseButton.Size = new System.Drawing.Size(150, 75);
            this.showcourseButton.TabIndex = 50;
            this.showcourseButton.Text = "Show Course";
            this.showcourseButton.UseVisualStyleBackColor = false;
            this.showcourseButton.Click += new System.EventHandler(this.showcourseButton_Click);
            // 
            // AssignCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1170, 586);
            this.Controls.Add(this.showcourseButton);
            this.Controls.Add(this.courseidCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.secidCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sectionidCombo);
            this.Controls.Add(this.addsecButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.coursesectionidCombo);
            this.Controls.Add(this.coursenameCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCourseButton);
            this.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssignCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignCourse";
            this.Load += new System.EventHandler(this.AssignCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox coursesectionidCombo;
        private System.Windows.Forms.ComboBox coursenameCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox secidCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sectionidCombo;
        private System.Windows.Forms.Button addsecButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox courseidCombo;
        private System.Windows.Forms.Button showcourseButton;
    }
}