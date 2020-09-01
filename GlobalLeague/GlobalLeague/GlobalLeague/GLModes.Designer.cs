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
            this.Playoffs = new System.Windows.Forms.Button();
            this.Standings = new System.Windows.Forms.Button();
            this.Schedule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Playoffs
            // 
            this.Playoffs.BackColor = System.Drawing.Color.Gray;
            this.Playoffs.Location = new System.Drawing.Point(346, 324);
            this.Playoffs.Name = "Playoffs";
            this.Playoffs.Size = new System.Drawing.Size(121, 32);
            this.Playoffs.TabIndex = 26;
            this.Playoffs.Text = "Playoffs";
            this.Playoffs.UseVisualStyleBackColor = false;
            // 
            // Standings
            // 
            this.Standings.BackColor = System.Drawing.Color.Gray;
            this.Standings.Location = new System.Drawing.Point(345, 244);
            this.Standings.Name = "Standings";
            this.Standings.Size = new System.Drawing.Size(121, 32);
            this.Standings.TabIndex = 25;
            this.Standings.Text = "Standings";
            this.Standings.UseVisualStyleBackColor = false;
            // 
            // Schedule
            // 
            this.Schedule.BackColor = System.Drawing.Color.Gray;
            this.Schedule.Location = new System.Drawing.Point(345, 173);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(121, 32);
            this.Schedule.TabIndex = 24;
            this.Schedule.Text = "Schedule";
            this.Schedule.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(205, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 45);
            this.label1.TabIndex = 23;
            this.label1.Text = "Global League Modes";
            // 
            // GLModes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Playoffs);
            this.Controls.Add(this.Standings);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.label1);
            this.Name = "GLModes";
            this.Text = "GLModes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Playoffs;
        private System.Windows.Forms.Button Standings;
        private System.Windows.Forms.Button Schedule;
        private System.Windows.Forms.Label label1;
    }
}