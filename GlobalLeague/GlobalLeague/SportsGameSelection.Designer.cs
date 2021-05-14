namespace GlobalLeague
{
    partial class SportsGameSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportsGameSelection));
            this.btn_Continue = new System.Windows.Forms.Button();
            this.dpd_ChooseG = new System.Windows.Forms.DomainUpDown();
            this.lbl_GSSelection = new System.Windows.Forms.Label();
            this.Box2 = new System.Windows.Forms.GroupBox();
            this.pb_GamePic = new System.Windows.Forms.PictureBox();
            this.bck_button = new System.Windows.Forms.Button();
            this.Box2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GamePic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(315, 358);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(150, 60);
            this.btn_Continue.TabIndex = 34;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            // 
            // dpd_ChooseG
            // 
            this.dpd_ChooseG.Location = new System.Drawing.Point(290, 317);
            this.dpd_ChooseG.Name = "dpd_ChooseG";
            this.dpd_ChooseG.Size = new System.Drawing.Size(201, 22);
            this.dpd_ChooseG.TabIndex = 33;
            this.dpd_ChooseG.Text = "Choose Game";
            // 
            // lbl_GSSelection
            // 
            this.lbl_GSSelection.AutoSize = true;
            this.lbl_GSSelection.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GSSelection.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GSSelection.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_GSSelection.Location = new System.Drawing.Point(216, 32);
            this.lbl_GSSelection.Name = "lbl_GSSelection";
            this.lbl_GSSelection.Size = new System.Drawing.Size(353, 45);
            this.lbl_GSSelection.TabIndex = 32;
            this.lbl_GSSelection.Text = "Select Sports Game";
            // 
            // Box2
            // 
            this.Box2.BackColor = System.Drawing.Color.Lavender;
            this.Box2.Controls.Add(this.pb_GamePic);
            this.Box2.Location = new System.Drawing.Point(272, 90);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(238, 211);
            this.Box2.TabIndex = 35;
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
            // bck_button
            // 
            this.bck_button.Location = new System.Drawing.Point(21, 23);
            this.bck_button.Name = "bck_button";
            this.bck_button.Size = new System.Drawing.Size(75, 23);
            this.bck_button.TabIndex = 36;
            this.bck_button.Text = "Back";
            this.bck_button.UseVisualStyleBackColor = true;
            this.bck_button.Click += new System.EventHandler(this.bck_button_Click);
            // 
            // SportsGameSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bck_button);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.dpd_ChooseG);
            this.Controls.Add(this.lbl_GSSelection);
            this.Controls.Add(this.Box2);
            this.Name = "SportsGameSelection";
            this.Text = "SportsGameSelection";
            this.Box2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_GamePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.DomainUpDown dpd_ChooseG;
        private System.Windows.Forms.Label lbl_GSSelection;
        private System.Windows.Forms.GroupBox Box2;
        private System.Windows.Forms.PictureBox pb_GamePic;
        private System.Windows.Forms.Button bck_button;
    }
}