
namespace StudentCourseReg
{
    partial class UpdateCourse
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
            this.courseidCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.secidCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sectionidCombo = new System.Windows.Forms.Label();
            this.updatesecButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.coursesectionidCombo = new System.Windows.Forms.ComboBox();
            this.coursenameCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.upCourseGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_sec_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upSecGrid = new System.Windows.Forms.DataGridView();
            this.secID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletecourseButton = new System.Windows.Forms.Button();
            this.deletesecButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upCourseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upSecGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // courseidCombo
            // 
            this.courseidCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseidCombo.FormattingEnabled = true;
            this.courseidCombo.Items.AddRange(new object[] {
            "100",
            "200",
            "300"});
            this.courseidCombo.Location = new System.Drawing.Point(378, 84);
            this.courseidCombo.Name = "courseidCombo";
            this.courseidCombo.Size = new System.Drawing.Size(129, 34);
            this.courseidCombo.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(770, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 46);
            this.label7.TabIndex = 64;
            this.label7.Text = "Update Section";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(1038, 156);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 30);
            this.radioButton2.TabIndex = 63;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(961, 156);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 30);
            this.radioButton1.TabIndex = 62;
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
            this.secidCombo.Location = new System.Drawing.Point(961, 84);
            this.secidCombo.Name = "secidCombo";
            this.secidCombo.Size = new System.Drawing.Size(129, 34);
            this.secidCombo.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(773, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 26);
            this.label5.TabIndex = 60;
            this.label5.Text = "Section Name";
            // 
            // sectionidCombo
            // 
            this.sectionidCombo.AutoSize = true;
            this.sectionidCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionidCombo.ForeColor = System.Drawing.Color.DarkBlue;
            this.sectionidCombo.Location = new System.Drawing.Point(810, 88);
            this.sectionidCombo.Name = "sectionidCombo";
            this.sectionidCombo.Size = new System.Drawing.Size(113, 26);
            this.sectionidCombo.TabIndex = 59;
            this.sectionidCombo.Text = "Section ID";
            // 
            // updatesecButton
            // 
            this.updatesecButton.BackColor = System.Drawing.Color.LightCoral;
            this.updatesecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatesecButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.updatesecButton.Location = new System.Drawing.Point(804, 312);
            this.updatesecButton.Name = "updatesecButton";
            this.updatesecButton.Size = new System.Drawing.Size(130, 56);
            this.updatesecButton.TabIndex = 58;
            this.updatesecButton.Text = "Update";
            this.updatesecButton.UseVisualStyleBackColor = false;
            this.updatesecButton.Click += new System.EventHandler(this.updatesecButton_Click_1);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Salmon;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.backButton.Location = new System.Drawing.Point(0, -1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 58);
            this.backButton.TabIndex = 57;
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
            this.coursesectionidCombo.Location = new System.Drawing.Point(378, 220);
            this.coursesectionidCombo.Name = "coursesectionidCombo";
            this.coursesectionidCombo.Size = new System.Drawing.Size(129, 34);
            this.coursesectionidCombo.TabIndex = 56;
            // 
            // coursenameCombo
            // 
            this.coursenameCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursenameCombo.FormattingEnabled = true;
            this.coursenameCombo.Items.AddRange(new object[] {
            "C#",
            "Java",
            "DLD"});
            this.coursenameCombo.Location = new System.Drawing.Point(378, 152);
            this.coursenameCombo.Name = "coursenameCombo";
            this.coursenameCombo.Size = new System.Drawing.Size(129, 34);
            this.coursenameCombo.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(206, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 46);
            this.label4.TabIndex = 54;
            this.label4.Text = "Update Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(181, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 53;
            this.label3.Text = "Course-Sec ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(189, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 52;
            this.label2.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(226, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 51;
            this.label1.Text = "Course ID";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightCoral;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.updateButton.Location = new System.Drawing.Point(182, 312);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(129, 56);
            this.updateButton.TabIndex = 50;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // upCourseGrid
            // 
            this.upCourseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upCourseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.c_id,
            this.c_name,
            this.c_sec_id});
            this.upCourseGrid.Location = new System.Drawing.Point(12, 374);
            this.upCourseGrid.Name = "upCourseGrid";
            this.upCourseGrid.RowHeadersWidth = 62;
            this.upCourseGrid.RowTemplate.Height = 28;
            this.upCourseGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.upCourseGrid.Size = new System.Drawing.Size(655, 264);
            this.upCourseGrid.TabIndex = 66;
            this.upCourseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.upCourseGrid_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // c_id
            // 
            this.c_id.DataPropertyName = "c_id";
            this.c_id.HeaderText = "Course ID";
            this.c_id.MinimumWidth = 8;
            this.c_id.Name = "c_id";
            this.c_id.Width = 150;
            // 
            // c_name
            // 
            this.c_name.DataPropertyName = "c_name";
            this.c_name.HeaderText = "Course Name";
            this.c_name.MinimumWidth = 8;
            this.c_name.Name = "c_name";
            this.c_name.Width = 150;
            // 
            // c_sec_id
            // 
            this.c_sec_id.DataPropertyName = "c_sec_id";
            this.c_sec_id.HeaderText = "CourseSec ID";
            this.c_sec_id.MinimumWidth = 8;
            this.c_sec_id.Name = "c_sec_id";
            this.c_sec_id.Width = 150;
            // 
            // upSecGrid
            // 
            this.upSecGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upSecGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.secID,
            this.sec_id,
            this.sec_name});
            this.upSecGrid.Location = new System.Drawing.Point(716, 374);
            this.upSecGrid.Name = "upSecGrid";
            this.upSecGrid.RowHeadersWidth = 62;
            this.upSecGrid.RowTemplate.Height = 28;
            this.upSecGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.upSecGrid.Size = new System.Drawing.Size(511, 264);
            this.upSecGrid.TabIndex = 67;
            this.upSecGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.upSecGrid_CellClick);
            // 
            // secID
            // 
            this.secID.DataPropertyName = "secID";
            this.secID.HeaderText = "secID";
            this.secID.MinimumWidth = 8;
            this.secID.Name = "secID";
            this.secID.Width = 150;
            // 
            // sec_id
            // 
            this.sec_id.DataPropertyName = "sec_id";
            this.sec_id.HeaderText = "Section ID";
            this.sec_id.MinimumWidth = 8;
            this.sec_id.Name = "sec_id";
            this.sec_id.Width = 150;
            // 
            // sec_name
            // 
            this.sec_name.DataPropertyName = "sec_name";
            this.sec_name.HeaderText = "Section Name";
            this.sec_name.MinimumWidth = 8;
            this.sec_name.Name = "sec_name";
            this.sec_name.Width = 150;
            // 
            // deletecourseButton
            // 
            this.deletecourseButton.BackColor = System.Drawing.Color.LightCoral;
            this.deletecourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletecourseButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.deletecourseButton.Location = new System.Drawing.Point(378, 312);
            this.deletecourseButton.Name = "deletecourseButton";
            this.deletecourseButton.Size = new System.Drawing.Size(129, 56);
            this.deletecourseButton.TabIndex = 68;
            this.deletecourseButton.Text = "Delete";
            this.deletecourseButton.UseVisualStyleBackColor = false;
            this.deletecourseButton.Click += new System.EventHandler(this.deletecourseButton_Click);
            // 
            // deletesecButton
            // 
            this.deletesecButton.BackColor = System.Drawing.Color.LightCoral;
            this.deletesecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletesecButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.deletesecButton.Location = new System.Drawing.Point(996, 312);
            this.deletesecButton.Name = "deletesecButton";
            this.deletesecButton.Size = new System.Drawing.Size(132, 56);
            this.deletesecButton.TabIndex = 69;
            this.deletesecButton.Text = "Delete";
            this.deletesecButton.UseVisualStyleBackColor = false;
            this.deletesecButton.Click += new System.EventHandler(this.deletesecButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.AutoSize = true;
            this.refreshButton.BackColor = System.Drawing.Color.Salmon;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.refreshButton.Location = new System.Drawing.Point(1136, 0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(103, 58);
            this.refreshButton.TabIndex = 72;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // UpdateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1239, 668);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deletesecButton);
            this.Controls.Add(this.deletecourseButton);
            this.Controls.Add(this.upSecGrid);
            this.Controls.Add(this.upCourseGrid);
            this.Controls.Add(this.courseidCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.secidCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sectionidCombo);
            this.Controls.Add(this.updatesecButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.coursesectionidCombo);
            this.Controls.Add(this.coursenameCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCourse";
            this.Load += new System.EventHandler(this.UpdateCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upCourseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upSecGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox courseidCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox secidCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sectionidCombo;
        private System.Windows.Forms.Button updatesecButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox coursesectionidCombo;
        private System.Windows.Forms.ComboBox coursenameCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView upCourseGrid;
        private System.Windows.Forms.DataGridView upSecGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_sec_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn secID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec_name;
        private System.Windows.Forms.Button deletecourseButton;
        private System.Windows.Forms.Button deletesecButton;
        private System.Windows.Forms.Button refreshButton;
    }
}