namespace SportSelection
{
    partial class SportSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportSelection));
            this.TeamBuild = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Soccer = new System.Windows.Forms.Button();
            this.Basketball = new System.Windows.Forms.Button();
            this.Football = new System.Windows.Forms.Button();
            this.Box.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamBuild
            // 
            this.TeamBuild.AutoSize = true;
            this.TeamBuild.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamBuild.ForeColor = System.Drawing.SystemColors.Control;
            this.TeamBuild.Location = new System.Drawing.Point(273, 53);
            this.TeamBuild.Name = "TeamBuild";
            this.TeamBuild.Size = new System.Drawing.Size(275, 45);
            this.TeamBuild.TabIndex = 19;
            this.TeamBuild.Text = "Sport Selection";
            // 
            // Box
            // 
            this.Box.BackColor = System.Drawing.Color.White;
            this.Box.Controls.Add(this.Soccer);
            this.Box.Controls.Add(this.pictureBox1);
            this.Box.Location = new System.Drawing.Point(51, 139);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(204, 194);
            this.Box.TabIndex = 15;
            this.Box.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Basketball);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(300, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 194);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.Football);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Location = new System.Drawing.Point(546, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 194);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 114);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(54, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 114);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(55, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 114);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Soccer
            // 
            this.Soccer.BackColor = System.Drawing.Color.Gray;
            this.Soccer.Location = new System.Drawing.Point(46, 153);
            this.Soccer.Name = "Soccer";
            this.Soccer.Size = new System.Drawing.Size(113, 32);
            this.Soccer.TabIndex = 1;
            this.Soccer.Text = "Soccer";
            this.Soccer.UseVisualStyleBackColor = false;
            // 
            // Basketball
            // 
            this.Basketball.BackColor = System.Drawing.Color.Gray;
            this.Basketball.Location = new System.Drawing.Point(54, 153);
            this.Basketball.Name = "Basketball";
            this.Basketball.Size = new System.Drawing.Size(105, 32);
            this.Basketball.TabIndex = 2;
            this.Basketball.Text = "Basketball";
            this.Basketball.UseVisualStyleBackColor = false;
            // 
            // Football
            // 
            this.Football.BackColor = System.Drawing.Color.Gray;
            this.Football.Location = new System.Drawing.Point(55, 153);
            this.Football.Name = "Football";
            this.Football.Size = new System.Drawing.Size(105, 32);
            this.Football.TabIndex = 3;
            this.Football.Text = "Football";
            this.Football.UseVisualStyleBackColor = false;
            // 
            // SportSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TeamBuild);
            this.Controls.Add(this.Box);
            this.Name = "SportSelection";
            this.Text = "Form1";
            this.Box.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TeamBuild;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Soccer;
        private System.Windows.Forms.Button Basketball;
        private System.Windows.Forms.Button Football;
    }
}

