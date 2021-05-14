namespace GlobalLeague
{
    partial class GLModes
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
            this.btn_PracticeM = new System.Windows.Forms.Button();
            this.btm_standings = new System.Windows.Forms.Button();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.lbl_GLModes = new System.Windows.Forms.Label();
            this.btn_Tourny = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_PracticeM
            // 
            this.btn_PracticeM.BackColor = System.Drawing.Color.Gray;
            this.btn_PracticeM.Location = new System.Drawing.Point(345, 275);
            this.btn_PracticeM.Name = "btn_PracticeM";
            this.btn_PracticeM.Size = new System.Drawing.Size(121, 48);
            this.btn_PracticeM.TabIndex = 26;
            this.btn_PracticeM.Text = "Practice Mode";
            this.btn_PracticeM.UseVisualStyleBackColor = false;
            this.btn_PracticeM.Click += new System.EventHandler(this.btn_PracticeM_Click);
            // 
            // btm_standings
            // 
            this.btm_standings.BackColor = System.Drawing.Color.Gray;
            this.btm_standings.Location = new System.Drawing.Point(345, 207);
            this.btm_standings.Name = "btm_standings";
            this.btm_standings.Size = new System.Drawing.Size(121, 48);
            this.btm_standings.TabIndex = 25;
            this.btm_standings.Text = "Standings";
            this.btm_standings.UseVisualStyleBackColor = false;
            this.btm_standings.Click += new System.EventHandler(this.btm_standings_Click);
            // 
            // btn_schedule
            // 
            this.btn_schedule.BackColor = System.Drawing.Color.Gray;
            this.btn_schedule.Location = new System.Drawing.Point(345, 138);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(121, 48);
            this.btn_schedule.TabIndex = 24;
            this.btn_schedule.Text = "Schedule";
            this.btn_schedule.UseVisualStyleBackColor = false;
            // 
            // lbl_GLModes
            // 
            this.lbl_GLModes.AutoSize = true;
            this.lbl_GLModes.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GLModes.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_GLModes.Location = new System.Drawing.Point(220, 72);
            this.lbl_GLModes.Name = "lbl_GLModes";
            this.lbl_GLModes.Size = new System.Drawing.Size(391, 45);
            this.lbl_GLModes.TabIndex = 23;
            this.lbl_GLModes.Text = "Global League Modes";
            // 
            // btn_Tourny
            // 
            this.btn_Tourny.BackColor = System.Drawing.Color.Gray;
            this.btn_Tourny.Location = new System.Drawing.Point(345, 347);
            this.btn_Tourny.Name = "btn_Tourny";
            this.btn_Tourny.Size = new System.Drawing.Size(121, 48);
            this.btn_Tourny.TabIndex = 26;
            this.btn_Tourny.Text = "Tournament";
            this.btn_Tourny.UseVisualStyleBackColor = false;
            this.btn_Tourny.Click += new System.EventHandler(this.btn_Tourny_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 27;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // GLModes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Tourny);
            this.Controls.Add(this.btn_PracticeM);
            this.Controls.Add(this.btm_standings);
            this.Controls.Add(this.btn_schedule);
            this.Controls.Add(this.lbl_GLModes);
            this.Name = "GLModes";
            this.Text = "GLModes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PracticeM;
        private System.Windows.Forms.Button btm_standings;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Label lbl_GLModes;
        private System.Windows.Forms.Button btn_Tourny;
        private System.Windows.Forms.Button btn_Back;
    }
}