namespace GlobalLeague
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lbl_Mmenu = new System.Windows.Forms.Label();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.btn_SelectGame = new System.Windows.Forms.Button();
            this.btn_GLModes = new System.Windows.Forms.Button();
            this.btn_TeamBuilder = new System.Windows.Forms.Button();
            this.gb_MenuBox = new System.Windows.Forms.GroupBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.gb_MenuBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Mmenu
            // 
            this.lbl_Mmenu.AutoSize = true;
            this.lbl_Mmenu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mmenu.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mmenu.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Mmenu.Location = new System.Drawing.Point(296, 31);
            this.lbl_Mmenu.Name = "lbl_Mmenu";
            this.lbl_Mmenu.Size = new System.Drawing.Size(218, 45);
            this.lbl_Mmenu.TabIndex = 21;
            this.lbl_Mmenu.Text = "Main Menu";
            // 
            // btn_Profile
            // 
            this.btn_Profile.BackColor = System.Drawing.Color.Gray;
            this.btn_Profile.Location = new System.Drawing.Point(143, 21);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(85, 32);
            this.btn_Profile.TabIndex = 0;
            this.btn_Profile.Text = "Profile";
            this.btn_Profile.UseVisualStyleBackColor = false;
            // 
            // btn_SelectGame
            // 
            this.btn_SelectGame.BackColor = System.Drawing.Color.Gray;
            this.btn_SelectGame.Location = new System.Drawing.Point(106, 72);
            this.btn_SelectGame.Name = "btn_SelectGame";
            this.btn_SelectGame.Size = new System.Drawing.Size(154, 64);
            this.btn_SelectGame.TabIndex = 0;
            this.btn_SelectGame.Text = "Select Game";
            this.btn_SelectGame.UseVisualStyleBackColor = false;
            // 
            // btn_GLModes
            // 
            this.btn_GLModes.BackColor = System.Drawing.Color.Gray;
            this.btn_GLModes.Location = new System.Drawing.Point(106, 152);
            this.btn_GLModes.Name = "btn_GLModes";
            this.btn_GLModes.Size = new System.Drawing.Size(154, 64);
            this.btn_GLModes.TabIndex = 0;
            this.btn_GLModes.Text = "GlobalLeagueModes";
            this.btn_GLModes.UseVisualStyleBackColor = false;
            // 
            // btn_TeamBuilder
            // 
            this.btn_TeamBuilder.BackColor = System.Drawing.Color.Gray;
            this.btn_TeamBuilder.Location = new System.Drawing.Point(106, 231);
            this.btn_TeamBuilder.Name = "btn_TeamBuilder";
            this.btn_TeamBuilder.Size = new System.Drawing.Size(154, 64);
            this.btn_TeamBuilder.TabIndex = 0;
            this.btn_TeamBuilder.Text = "Team Builder";
            this.btn_TeamBuilder.UseVisualStyleBackColor = false;
            // 
            // gb_MenuBox
            // 
            this.gb_MenuBox.BackColor = System.Drawing.Color.Lavender;
            this.gb_MenuBox.Controls.Add(this.btn_TeamBuilder);
            this.gb_MenuBox.Controls.Add(this.btn_GLModes);
            this.gb_MenuBox.Controls.Add(this.btn_SelectGame);
            this.gb_MenuBox.Controls.Add(this.btn_Profile);
            this.gb_MenuBox.Location = new System.Drawing.Point(210, 79);
            this.gb_MenuBox.Name = "gb_MenuBox";
            this.gb_MenuBox.Size = new System.Drawing.Size(372, 346);
            this.gb_MenuBox.TabIndex = 20;
            this.gb_MenuBox.TabStop = false;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 22;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_Mmenu);
            this.Controls.Add(this.gb_MenuBox);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.gb_MenuBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Mmenu;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.Button btn_SelectGame;
        private System.Windows.Forms.Button btn_GLModes;
        private System.Windows.Forms.Button btn_TeamBuilder;
        private System.Windows.Forms.GroupBox gb_MenuBox;
        private System.Windows.Forms.Button btn_Back;
    }
}