namespace Modes
{
    partial class Modes
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
            this.GLModes = new System.Windows.Forms.Label();
            this.Schedule = new System.Windows.Forms.Button();
            this.Standings = new System.Windows.Forms.Button();
            this.Playoffs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GLModes
            // 
            this.GLModes.AutoSize = true;
            this.GLModes.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GLModes.ForeColor = System.Drawing.SystemColors.Control;
            this.GLModes.Location = new System.Drawing.Point(200, 59);
            this.GLModes.Name = "GLModes";
            this.GLModes.Size = new System.Drawing.Size(391, 45);
            this.GLModes.TabIndex = 19;
            this.GLModes.Text = "Global League Modes";
            this.GLModes.Click += new System.EventHandler(this.GLModes_Click);
            // 
            // Schedule
            // 
            this.Schedule.BackColor = System.Drawing.Color.Gray;
            this.Schedule.Location = new System.Drawing.Point(340, 138);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(121, 32);
            this.Schedule.TabIndex = 20;
            this.Schedule.Text = "Schedule";
            this.Schedule.UseVisualStyleBackColor = false;
            // 
            // Standings
            // 
            this.Standings.BackColor = System.Drawing.Color.Gray;
            this.Standings.Location = new System.Drawing.Point(340, 209);
            this.Standings.Name = "Standings";
            this.Standings.Size = new System.Drawing.Size(121, 32);
            this.Standings.TabIndex = 21;
            this.Standings.Text = "Standings";
            this.Standings.UseVisualStyleBackColor = false;
            // 
            // Playoffs
            // 
            this.Playoffs.BackColor = System.Drawing.Color.Gray;
            this.Playoffs.Location = new System.Drawing.Point(341, 289);
            this.Playoffs.Name = "Playoffs";
            this.Playoffs.Size = new System.Drawing.Size(121, 32);
            this.Playoffs.TabIndex = 22;
            this.Playoffs.Text = "Playoffs";
            this.Playoffs.UseVisualStyleBackColor = false;
            // 
            // Modes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Playoffs);
            this.Controls.Add(this.Standings);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.GLModes);
            this.Name = "Modes";
            this.Text = "Global League Modes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GLModes;
        private System.Windows.Forms.Button Schedule;
        private System.Windows.Forms.Button Standings;
        private System.Windows.Forms.Button Playoffs;
    }
}

