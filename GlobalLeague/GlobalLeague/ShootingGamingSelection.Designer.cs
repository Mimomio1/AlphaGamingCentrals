namespace GlobalLeague
{
    partial class ShootingGamingSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShootingGamingSelection));
            this.btn_Continue = new System.Windows.Forms.Button();
            this.dpd_ChooseGame = new System.Windows.Forms.DomainUpDown();
            this.lbl_GSelection = new System.Windows.Forms.Label();
            this.Box2 = new System.Windows.Forms.GroupBox();
            this.pb_GamePic = new System.Windows.Forms.PictureBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.Box2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GamePic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(323, 358);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(150, 60);
            this.btn_Continue.TabIndex = 38;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            // 
            // dpd_ChooseGame
            // 
            this.dpd_ChooseGame.Location = new System.Drawing.Point(298, 317);
            this.dpd_ChooseGame.Name = "dpd_ChooseGame";
            this.dpd_ChooseGame.Size = new System.Drawing.Size(201, 22);
            this.dpd_ChooseGame.TabIndex = 37;
            this.dpd_ChooseGame.Text = "Choose Game";
            // 
            // lbl_GSelection
            // 
            this.lbl_GSelection.AutoSize = true;
            this.lbl_GSelection.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GSelection.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GSelection.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_GSelection.Location = new System.Drawing.Point(210, 32);
            this.lbl_GSelection.Name = "lbl_GSelection";
            this.lbl_GSelection.Size = new System.Drawing.Size(389, 45);
            this.lbl_GSelection.TabIndex = 36;
            this.lbl_GSelection.Text = "Select Shooting Game";
            // 
            // Box2
            // 
            this.Box2.BackColor = System.Drawing.Color.Lavender;
            this.Box2.Controls.Add(this.pb_GamePic);
            this.Box2.Location = new System.Drawing.Point(282, 89);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(238, 211);
            this.Box2.TabIndex = 39;
            this.Box2.TabStop = false;
            // 
            // pb_GamePic
            // 
            this.pb_GamePic.BackColor = System.Drawing.Color.White;
            this.pb_GamePic.Location = new System.Drawing.Point(16, 12);
            this.pb_GamePic.Name = "pb_GamePic";
            this.pb_GamePic.Size = new System.Drawing.Size(201, 181);
            this.pb_GamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_GamePic.TabIndex = 28;
            this.pb_GamePic.TabStop = false;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 40;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // ShootingGamingSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.dpd_ChooseGame);
            this.Controls.Add(this.lbl_GSelection);
            this.Controls.Add(this.Box2);
            this.Name = "ShootingGamingSelection";
            this.Text = "ShootingGamingSelection";
            this.Box2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_GamePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.DomainUpDown dpd_ChooseGame;
        private System.Windows.Forms.Label lbl_GSelection;
        private System.Windows.Forms.GroupBox Box2;
        private System.Windows.Forms.PictureBox pb_GamePic;
        private System.Windows.Forms.Button btn_Back;
    }
}