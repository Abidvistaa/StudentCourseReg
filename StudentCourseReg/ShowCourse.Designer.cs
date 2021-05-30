
namespace StudentCourseReg
{
    partial class ShowCourse
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
            this.addmoreButton = new System.Windows.Forms.Button();
            this.showcourseGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.showcourseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addmoreButton
            // 
            this.addmoreButton.BackColor = System.Drawing.Color.LightCoral;
            this.addmoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmoreButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.addmoreButton.Location = new System.Drawing.Point(899, 482);
            this.addmoreButton.Name = "addmoreButton";
            this.addmoreButton.Size = new System.Drawing.Size(105, 117);
            this.addmoreButton.TabIndex = 22;
            this.addmoreButton.Text = "Add More";
            this.addmoreButton.UseVisualStyleBackColor = false;
            this.addmoreButton.Click += new System.EventHandler(this.addmoreButton_Click);
            // 
            // showcourseGrid
            // 
            this.showcourseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showcourseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.c_id,
            this.c_name,
            this.sec_name});
            this.showcourseGrid.Location = new System.Drawing.Point(201, 169);
            this.showcourseGrid.Name = "showcourseGrid";
            this.showcourseGrid.RowHeadersWidth = 62;
            this.showcourseGrid.RowTemplate.Height = 28;
            this.showcourseGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showcourseGrid.Size = new System.Drawing.Size(662, 429);
            this.showcourseGrid.TabIndex = 23;
            this.showcourseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showcourseGrid_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
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
            // sec_name
            // 
            this.sec_name.DataPropertyName = "sec_name";
            this.sec_name.HeaderText = "Section Name";
            this.sec_name.MinimumWidth = 8;
            this.sec_name.Name = "sec_name";
            this.sec_name.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(440, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 52);
            this.label1.TabIndex = 24;
            this.label1.Text = "Showing Course";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightCoral;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.updateButton.Location = new System.Drawing.Point(899, 170);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(105, 126);
            this.updateButton.TabIndex = 25;
            this.updateButton.Text = "Edit";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.deleteButton.Location = new System.Drawing.Point(899, 325);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 128);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Remove";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Salmon;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.backButton.Location = new System.Drawing.Point(1, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 55);
            this.backButton.TabIndex = 58;
            this.backButton.Text = "Home";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(818, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(762, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(445, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 62;
            this.label4.Text = "SearchCourse";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(201, 132);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 31);
            this.textBox1.TabIndex = 61;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ShowCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1074, 631);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showcourseGrid);
            this.Controls.Add(this.addmoreButton);
            this.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "ShowCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowCourse";
            this.Load += new System.EventHandler(this.ShowCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showcourseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addmoreButton;
        private System.Windows.Forms.DataGridView showcourseGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec_name;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}