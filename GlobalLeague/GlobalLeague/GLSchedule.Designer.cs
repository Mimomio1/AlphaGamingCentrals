namespace GlobalLeague
{
    partial class GLSchedule
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
            this.GlModes = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.DateSelected = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.Button();
            this.GameDay = new System.Windows.Forms.Label();
            this.Yes = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlModes
            // 
            this.GlModes.AutoSize = true;
            this.GlModes.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlModes.ForeColor = System.Drawing.SystemColors.Control;
            this.GlModes.Location = new System.Drawing.Point(113, 27);
            this.GlModes.Name = "GlModes";
            this.GlModes.Size = new System.Drawing.Size(571, 45);
            this.GlModes.TabIndex = 19;
            this.GlModes.Text = "Alpha Gaming Central Schedule";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.monthCalendar1);
            this.groupBox3.Controls.Add(this.DateSelected);
            this.groupBox3.Controls.Add(this.No);
            this.groupBox3.Controls.Add(this.GameDay);
            this.groupBox3.Controls.Add(this.Yes);
            this.groupBox3.Location = new System.Drawing.Point(111, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 337);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 11;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(286, 42);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // DateSelected
            // 
            this.DateSelected.AutoSize = true;
            this.DateSelected.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSelected.ForeColor = System.Drawing.Color.Gray;
            this.DateSelected.Location = new System.Drawing.Point(6, 137);
            this.DateSelected.Name = "DateSelected";
            this.DateSelected.Size = new System.Drawing.Size(135, 23);
            this.DateSelected.TabIndex = 8;
            this.DateSelected.Text = "Date Selected:";
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.Color.Gray;
            this.No.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.Location = new System.Drawing.Point(169, 203);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(77, 46);
            this.No.TabIndex = 7;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = false;
            // 
            // GameDay
            // 
            this.GameDay.AutoSize = true;
            this.GameDay.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDay.ForeColor = System.Drawing.Color.Gray;
            this.GameDay.Location = new System.Drawing.Point(32, 42);
            this.GameDay.Name = "GameDay";
            this.GameDay.Size = new System.Drawing.Size(214, 45);
            this.GameDay.TabIndex = 6;
            this.GameDay.Text = "Game Day:";
            // 
            // Yes
            // 
            this.Yes.BackColor = System.Drawing.Color.Gray;
            this.Yes.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.Location = new System.Drawing.Point(62, 203);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(79, 46);
            this.Yes.TabIndex = 0;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = false;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Back.Location = new System.Drawing.Point(12, 27);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 27);
            this.btn_Back.TabIndex = 23;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click_1);
            // 
            // GLSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.GlModes);
            this.Controls.Add(this.groupBox3);
            this.Name = "GLSchedule";
            this.Text = "GLSchedule";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GlModes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label DateSelected;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Label GameDay;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Back;
    }
}