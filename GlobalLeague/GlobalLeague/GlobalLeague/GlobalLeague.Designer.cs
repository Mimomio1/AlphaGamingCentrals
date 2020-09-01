namespace GlobalLeague
{
    partial class GlobalLeague
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalLeague));
            this.Box = new System.Windows.Forms.GroupBox();
            this.Captain = new System.Windows.Forms.Button();
            this.Box2 = new System.Windows.Forms.GroupBox();
            this.Player = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GLeagues = new System.Windows.Forms.Label();
            this.Box.SuspendLayout();
            this.Box2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.BackColor = System.Drawing.Color.Lavender;
            this.Box.Controls.Add(this.Captain);
            this.Box.Location = new System.Drawing.Point(21, 121);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(238, 211);
            this.Box.TabIndex = 0;
            this.Box.TabStop = false;
            // 
            // Captain
            // 
            this.Captain.BackColor = System.Drawing.Color.Gray;
            this.Captain.Location = new System.Drawing.Point(58, 94);
            this.Captain.Name = "Captain";
            this.Captain.Size = new System.Drawing.Size(121, 32);
            this.Captain.TabIndex = 0;
            this.Captain.Text = "Captain";
            this.Captain.UseVisualStyleBackColor = false;
            this.Captain.Click += new System.EventHandler(this.Captain_Click);
            // 
            // Box2
            // 
            this.Box2.BackColor = System.Drawing.Color.Lavender;
            this.Box2.Controls.Add(this.Player);
            this.Box2.Location = new System.Drawing.Point(540, 121);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(238, 211);
            this.Box2.TabIndex = 1;
            this.Box2.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Gray;
            this.Player.Location = new System.Drawing.Point(59, 89);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(121, 32);
            this.Player.TabIndex = 1;
            this.Player.Text = "Player";
            this.Player.UseVisualStyleBackColor = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(284, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 173);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // GLeagues
            // 
            this.GLeagues.AutoSize = true;
            this.GLeagues.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GLeagues.ForeColor = System.Drawing.SystemColors.Control;
            this.GLeagues.Location = new System.Drawing.Point(257, 49);
            this.GLeagues.Name = "GLeagues";
            this.GLeagues.Size = new System.Drawing.Size(284, 45);
            this.GLeagues.TabIndex = 3;
            this.GLeagues.Text = "Global Leagues";
            // 
            // GlobalLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GLeagues);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box);
            this.Name = "GlobalLeague";
            this.Text = "Form1";
            this.Box.ResumeLayout(false);
            this.Box2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.Button Captain;
        private System.Windows.Forms.GroupBox Box2;
        private System.Windows.Forms.Button Player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label GLeagues;
    }
}

