namespace GlobalLeague
{
    partial class Player
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
            this.PlayerName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Email2 = new System.Windows.Forms.TextBox();
            this.Yname = new System.Windows.Forms.TextBox();
            this.SignUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.ForeColor = System.Drawing.SystemColors.Control;
            this.PlayerName.Location = new System.Drawing.Point(312, 51);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(182, 45);
            this.PlayerName.TabIndex = 7;
            this.PlayerName.Text = "PLAYER";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.SignIn);
            this.groupBox1.Location = new System.Drawing.Point(451, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 285);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(89, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sign In";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(71, 131);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(165, 22);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(71, 79);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(165, 22);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email";
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.Gray;
            this.SignIn.Location = new System.Drawing.Point(97, 209);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(121, 32);
            this.SignIn.TabIndex = 0;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = false;
            // 
            // Box
            // 
            this.Box.BackColor = System.Drawing.Color.Lavender;
            this.Box.Controls.Add(this.label2);
            this.Box.Controls.Add(this.Pass);
            this.Box.Controls.Add(this.Email2);
            this.Box.Controls.Add(this.Yname);
            this.Box.Controls.Add(this.SignUp);
            this.Box.Location = new System.Drawing.Point(43, 115);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(306, 285);
            this.Box.TabIndex = 5;
            this.Box.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(75, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sign Up";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(63, 147);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(165, 22);
            this.Pass.TabIndex = 4;
            this.Pass.Text = "Password";
            // 
            // Email2
            // 
            this.Email2.Location = new System.Drawing.Point(63, 108);
            this.Email2.Name = "Email2";
            this.Email2.Size = new System.Drawing.Size(165, 22);
            this.Email2.TabIndex = 3;
            this.Email2.Text = "Email";
            // 
            // Yname
            // 
            this.Yname.Location = new System.Drawing.Point(63, 70);
            this.Yname.Name = "Yname";
            this.Yname.Size = new System.Drawing.Size(165, 22);
            this.Yname.TabIndex = 2;
            this.Yname.Text = "Your name";
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.Gray;
            this.SignUp.Location = new System.Drawing.Point(83, 209);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(121, 32);
            this.SignUp.TabIndex = 0;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Box);
            this.Name = "Player";
            this.Text = "Player";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox Email2;
        private System.Windows.Forms.TextBox Yname;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button button1;
    }
}