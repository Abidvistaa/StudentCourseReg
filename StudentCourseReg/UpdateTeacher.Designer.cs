
namespace StudentCourseReg
{
    partial class UpdateTeacher
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
            this.teachercidCombo = new System.Windows.Forms.ComboBox();
            this.deptCombo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.teacherGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_sec_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshButton = new System.Windows.Forms.Button();
            this.teacherSecCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teacherGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Salmon;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.backButton.Location = new System.Drawing.Point(1, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 58);
            this.backButton.TabIndex = 30;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // teachercidCombo
            // 
            this.teachercidCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachercidCombo.FormattingEnabled = true;
            this.teachercidCombo.Items.AddRange(new object[] {
            "100",
            "200",
            "300"});
            this.teachercidCombo.Location = new System.Drawing.Point(433, 226);
            this.teachercidCombo.Name = "teachercidCombo";
            this.teachercidCombo.Size = new System.Drawing.Size(129, 34);
            this.teachercidCombo.TabIndex = 29;
            // 
            // deptCombo
            // 
            this.deptCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptCombo.FormattingEnabled = true;
            this.deptCombo.Items.AddRange(new object[] {
            "CSE",
            "EEE"});
            this.deptCombo.Location = new System.Drawing.Point(433, 158);
            this.deptCombo.Name = "deptCombo";
            this.deptCombo.Size = new System.Drawing.Size(129, 34);
            this.deptCombo.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(605, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 45);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(449, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 40);
            this.label4.TabIndex = 26;
            this.label4.Text = "Update Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(242, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Teacher_C_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(268, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Department";
            // 
            // txtTname
            // 
            this.txtTname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTname.Location = new System.Drawing.Point(433, 98);
            this.txtTname.Name = "txtTname";
            this.txtTname.Size = new System.Drawing.Size(296, 32);
            this.txtTname.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(242, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Teacher Name";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightCoral;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.updateButton.Location = new System.Drawing.Point(433, 359);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(129, 45);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // teacherGrid
            // 
            this.teacherGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.t_name,
            this.dept,
            this.c_id,
            this.t_sec_id});
            this.teacherGrid.Location = new System.Drawing.Point(161, 410);
            this.teacherGrid.Name = "teacherGrid";
            this.teacherGrid.RowHeadersWidth = 62;
            this.teacherGrid.RowTemplate.Height = 28;
            this.teacherGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teacherGrid.Size = new System.Drawing.Size(814, 238);
            this.teacherGrid.TabIndex = 31;
            this.teacherGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherGrid_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // t_name
            // 
            this.t_name.DataPropertyName = "t_name";
            this.t_name.HeaderText = "Teacher Name";
            this.t_name.MinimumWidth = 8;
            this.t_name.Name = "t_name";
            this.t_name.Width = 150;
            // 
            // dept
            // 
            this.dept.DataPropertyName = "dept";
            this.dept.HeaderText = "Department";
            this.dept.MinimumWidth = 8;
            this.dept.Name = "dept";
            this.dept.Width = 150;
            // 
            // c_id
            // 
            this.c_id.DataPropertyName = "c_id";
            this.c_id.HeaderText = "Teacher CourseID";
            this.c_id.MinimumWidth = 8;
            this.c_id.Name = "c_id";
            this.c_id.Width = 150;
            // 
            // t_sec_id
            // 
            this.t_sec_id.DataPropertyName = "t_sec_id";
            this.t_sec_id.HeaderText = "Sec ID";
            this.t_sec_id.MinimumWidth = 8;
            this.t_sec_id.Name = "t_sec_id";
            this.t_sec_id.Width = 150;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Salmon;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.refreshButton.Location = new System.Drawing.Point(1026, -1);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(107, 56);
            this.refreshButton.TabIndex = 32;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // teacherSecCombo
            // 
            this.teacherSecCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherSecCombo.FormattingEnabled = true;
            this.teacherSecCombo.Items.AddRange(new object[] {
            "10",
            "20"});
            this.teacherSecCombo.Location = new System.Drawing.Point(433, 290);
            this.teacherSecCombo.Name = "teacherSecCombo";
            this.teacherSecCombo.Size = new System.Drawing.Size(129, 34);
            this.teacherSecCombo.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(310, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "Sec_ID";
            // 
            // UpdateTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1133, 660);
            this.Controls.Add(this.teacherSecCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.teacherGrid);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.teachercidCombo);
            this.Controls.Add(this.deptCombo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateTeacher";
            this.Load += new System.EventHandler(this.UpdateTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox teachercidCombo;
        private System.Windows.Forms.ComboBox deptCombo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView teacherGrid;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_sec_id;
        private System.Windows.Forms.ComboBox teacherSecCombo;
        private System.Windows.Forms.Label label5;
    }
}