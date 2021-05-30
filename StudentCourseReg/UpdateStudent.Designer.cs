
namespace StudentCourseReg
{
    partial class UpdateStudent
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
            this.txtCgpa = new System.Windows.Forms.TextBox();
            this.deptCombo = new System.Windows.Forms.ComboBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.studentGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Salmon;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 58);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // txtCgpa
            // 
            this.txtCgpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCgpa.Location = new System.Drawing.Point(439, 221);
            this.txtCgpa.Name = "txtCgpa";
            this.txtCgpa.Size = new System.Drawing.Size(296, 32);
            this.txtCgpa.TabIndex = 20;
            // 
            // deptCombo
            // 
            this.deptCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptCombo.FormattingEnabled = true;
            this.deptCombo.Items.AddRange(new object[] {
            "",
            "CSE",
            "EEE"});
            this.deptCombo.Location = new System.Drawing.Point(439, 152);
            this.deptCombo.Name = "deptCombo";
            this.deptCombo.Size = new System.Drawing.Size(137, 34);
            this.deptCombo.TabIndex = 19;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Salmon;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.nextButton.Location = new System.Drawing.Point(602, 287);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(133, 45);
            this.nextButton.TabIndex = 18;
            this.nextButton.Text = "Cancel";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(427, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 40);
            this.label4.TabIndex = 17;
            this.label4.Text = "Update Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(340, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "CGPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(289, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Department";
            // 
            // txtSname
            // 
            this.txtSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSname.Location = new System.Drawing.Point(439, 92);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(296, 32);
            this.txtSname.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(263, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student Name";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Salmon;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.updateButton.Location = new System.Drawing.Point(439, 287);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(129, 45);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // studentGrid
            // 
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.s_name,
            this.cgpa,
            this.dept});
            this.studentGrid.Location = new System.Drawing.Point(193, 349);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.RowHeadersWidth = 62;
            this.studentGrid.RowTemplate.Height = 28;
            this.studentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGrid.Size = new System.Drawing.Size(660, 231);
            this.studentGrid.TabIndex = 22;
            this.studentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGrid_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // s_name
            // 
            this.s_name.DataPropertyName = "s_name";
            this.s_name.HeaderText = "Student Name";
            this.s_name.MinimumWidth = 8;
            this.s_name.Name = "s_name";
            this.s_name.Width = 150;
            // 
            // cgpa
            // 
            this.cgpa.DataPropertyName = "cgpa";
            this.cgpa.HeaderText = "CGPA";
            this.cgpa.MinimumWidth = 8;
            this.cgpa.Name = "cgpa";
            this.cgpa.Width = 150;
            // 
            // dept
            // 
            this.dept.DataPropertyName = "dept";
            this.dept.HeaderText = "Department";
            this.dept.MinimumWidth = 8;
            this.dept.Name = "dept";
            this.dept.Width = 150;
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1062, 616);
            this.Controls.Add(this.studentGrid);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.txtCgpa);
            this.Controls.Add(this.deptCombo);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateStudent";
            this.Load += new System.EventHandler(this.UpdateStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox txtCgpa;
        private System.Windows.Forms.ComboBox deptCombo;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView studentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept;
    }
}