namespace TeamBuilder
{
    partial class TeamB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamB));
            this.TeamBuild = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createteam = new System.Windows.Forms.Label();
            this.TeamName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.JoinTeam = new System.Windows.Forms.Label();
            this.SearchTeam = new System.Windows.Forms.TextBox();
            this.Join_Team = new System.Windows.Forms.Button();
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
            this.Upload = new System.Windows.Forms.Button();
            this.TeamSize = new System.Windows.Forms.DomainUpDown();
            this.SearchTName = new System.DirectoryServices.DirectorySearcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamBuild
            // 
            this.TeamBuild.AutoSize = true;
            this.TeamBuild.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamBuild.ForeColor = System.Drawing.SystemColors.Control;
            this.TeamBuild.Location = new System.Drawing.Point(273, 53);
            this.TeamBuild.Name = "TeamBuild";
            this.TeamBuild.Size = new System.Drawing.Size(253, 45);
            this.TeamBuild.TabIndex = 14;
            this.TeamBuild.Text = "Team Builder";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.TeamSize);
            this.groupBox2.Controls.Add(this.Upload);
            this.groupBox2.Controls.Add(this.createteam);
            this.groupBox2.Controls.Add(this.TeamName);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(451, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 285);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // createteam
            // 
            this.createteam.AutoSize = true;
            this.createteam.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createteam.ForeColor = System.Drawing.Color.Gray;
            this.createteam.Location = new System.Drawing.Point(15, 18);
            this.createteam.Name = "createteam";
            this.createteam.Size = new System.Drawing.Size(274, 45);
            this.createteam.TabIndex = 5;
            this.createteam.Text = "Create A Team";
            // 
            // TeamName
            // 
            this.TeamName.Location = new System.Drawing.Point(71, 79);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(165, 22);
            this.TeamName.TabIndex = 1;
            this.TeamName.Text = "Team Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(97, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.JoinTeam);
            this.groupBox3.Controls.Add(this.SearchTeam);
            this.groupBox3.Controls.Add(this.Join_Team);
            this.groupBox3.Location = new System.Drawing.Point(43, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 285);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // JoinTeam
            // 
            this.JoinTeam.AutoSize = true;
            this.JoinTeam.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinTeam.ForeColor = System.Drawing.Color.Gray;
            this.JoinTeam.Location = new System.Drawing.Point(29, 22);
            this.JoinTeam.Name = "JoinTeam";
            this.JoinTeam.Size = new System.Drawing.Size(230, 45);
            this.JoinTeam.TabIndex = 6;
            this.JoinTeam.Text = "Join A Team";
            // 
            // SearchTeam
            // 
            this.SearchTeam.Location = new System.Drawing.Point(63, 108);
            this.SearchTeam.Name = "SearchTeam";
            this.SearchTeam.Size = new System.Drawing.Size(165, 22);
            this.SearchTeam.TabIndex = 3;
            this.SearchTeam.Text = "Search Team Name";
            // 
            // Join_Team
            // 
            this.Join_Team.BackColor = System.Drawing.Color.Gray;
            this.Join_Team.Location = new System.Drawing.Point(83, 209);
            this.Join_Team.Name = "Join_Team";
            this.Join_Team.Size = new System.Drawing.Size(121, 32);
            this.Join_Team.TabIndex = 0;
            this.Join_Team.Text = "Join A Team";
            this.Join_Team.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.SignIn);
            this.groupBox1.Location = new System.Drawing.Point(451, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 285);
            this.groupBox1.TabIndex = 11;
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
            this.Box.Location = new System.Drawing.Point(43, 113);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(306, 285);
            this.Box.TabIndex = 10;
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
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.Gray;
            this.Upload.Location = new System.Drawing.Point(71, 159);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(63, 32);
            this.Upload.TabIndex = 6;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = false;
            // 
            // TeamSize
            // 
            this.TeamSize.Location = new System.Drawing.Point(147, 165);
            this.TeamSize.Name = "TeamSize";
            this.TeamSize.Size = new System.Drawing.Size(89, 22);
            this.TeamSize.TabIndex = 7;
            this.TeamSize.Text = "TeamSize";
            // 
            // SearchTName
            // 
            this.SearchTName.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.SearchTName.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.SearchTName.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 44);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TeamB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TeamBuild);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Box);
            this.Name = "TeamB";
            this.Text = "Team Builder";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TeamBuild;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DomainUpDown TeamSize;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Label createteam;
        private System.Windows.Forms.TextBox TeamName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label JoinTeam;
        private System.Windows.Forms.TextBox SearchTeam;
        private System.Windows.Forms.Button Join_Team;
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
        private System.DirectoryServices.DirectorySearcher SearchTName;
    }
}

