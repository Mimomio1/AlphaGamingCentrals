namespace GlobalLeague
{
    partial class Tournament
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
            this.lbl_TournMode = new System.Windows.Forms.Label();
            this.btn_JoinTourn = new System.Windows.Forms.Button();
            this.pb_GamePic = new System.Windows.Forms.PictureBox();
            this.btn_SelectTourn = new System.Windows.Forms.DomainUpDown();
            this.btn_Back = new System.Windows.Forms.Button();
            this.cb_Duo = new System.Windows.Forms.CheckBox();
            this.cb_Trio = new System.Windows.Forms.CheckBox();
            this.cb_Quad = new System.Windows.Forms.CheckBox();
            this.cb_Solo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GamePic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TournMode
            // 
            this.lbl_TournMode.AutoSize = true;
            this.lbl_TournMode.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TournMode.ForeColor = System.Drawing.Color.White;
            this.lbl_TournMode.Location = new System.Drawing.Point(230, 40);
            this.lbl_TournMode.Name = "lbl_TournMode";
            this.lbl_TournMode.Size = new System.Drawing.Size(332, 48);
            this.lbl_TournMode.TabIndex = 0;
            this.lbl_TournMode.Text = "Tournament Mode";
            // 
            // btn_JoinTourn
            // 
            this.btn_JoinTourn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JoinTourn.Location = new System.Drawing.Point(311, 394);
            this.btn_JoinTourn.Name = "btn_JoinTourn";
            this.btn_JoinTourn.Size = new System.Drawing.Size(167, 33);
            this.btn_JoinTourn.TabIndex = 1;
            this.btn_JoinTourn.Text = "Join Tournament";
            this.btn_JoinTourn.UseVisualStyleBackColor = true;
            // 
            // pb_GamePic
            // 
            this.pb_GamePic.BackColor = System.Drawing.Color.White;
            this.pb_GamePic.Location = new System.Drawing.Point(268, 119);
            this.pb_GamePic.Name = "pb_GamePic";
            this.pb_GamePic.Size = new System.Drawing.Size(258, 160);
            this.pb_GamePic.TabIndex = 2;
            this.pb_GamePic.TabStop = false;
            // 
            // btn_SelectTourn
            // 
            this.btn_SelectTourn.Location = new System.Drawing.Point(289, 354);
            this.btn_SelectTourn.Name = "btn_SelectTourn";
            this.btn_SelectTourn.Size = new System.Drawing.Size(201, 22);
            this.btn_SelectTourn.TabIndex = 34;
            this.btn_SelectTourn.Text = "Select Tournament";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 35;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // cb_Duo
            // 
            this.cb_Duo.AutoSize = true;
            this.cb_Duo.ForeColor = System.Drawing.Color.White;
            this.cb_Duo.Location = new System.Drawing.Point(330, 307);
            this.cb_Duo.Name = "cb_Duo";
            this.cb_Duo.Size = new System.Drawing.Size(56, 21);
            this.cb_Duo.TabIndex = 36;
            this.cb_Duo.Text = "Duo";
            this.cb_Duo.UseVisualStyleBackColor = true;
            // 
            // cb_Trio
            // 
            this.cb_Trio.AutoSize = true;
            this.cb_Trio.ForeColor = System.Drawing.Color.White;
            this.cb_Trio.Location = new System.Drawing.Point(410, 307);
            this.cb_Trio.Name = "cb_Trio";
            this.cb_Trio.Size = new System.Drawing.Size(55, 21);
            this.cb_Trio.TabIndex = 36;
            this.cb_Trio.Text = "Trio";
            this.cb_Trio.UseVisualStyleBackColor = true;
            // 
            // cb_Quad
            // 
            this.cb_Quad.AutoSize = true;
            this.cb_Quad.ForeColor = System.Drawing.Color.White;
            this.cb_Quad.Location = new System.Drawing.Point(484, 307);
            this.cb_Quad.Name = "cb_Quad";
            this.cb_Quad.Size = new System.Drawing.Size(65, 21);
            this.cb_Quad.TabIndex = 36;
            this.cb_Quad.Text = "Quad";
            this.cb_Quad.UseVisualStyleBackColor = true;
            // 
            // cb_Solo
            // 
            this.cb_Solo.AutoSize = true;
            this.cb_Solo.ForeColor = System.Drawing.Color.White;
            this.cb_Solo.Location = new System.Drawing.Point(247, 307);
            this.cb_Solo.Name = "cb_Solo";
            this.cb_Solo.Size = new System.Drawing.Size(58, 21);
            this.cb_Solo.TabIndex = 36;
            this.cb_Solo.Text = "Solo";
            this.cb_Solo.UseVisualStyleBackColor = true;
            // 
            // Tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_Quad);
            this.Controls.Add(this.cb_Trio);
            this.Controls.Add(this.cb_Solo);
            this.Controls.Add(this.cb_Duo);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_SelectTourn);
            this.Controls.Add(this.pb_GamePic);
            this.Controls.Add(this.btn_JoinTourn);
            this.Controls.Add(this.lbl_TournMode);
            this.Name = "Tournament";
            this.Text = "Select Tournament";
            ((System.ComponentModel.ISupportInitialize)(this.pb_GamePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TournMode;
        private System.Windows.Forms.Button btn_JoinTourn;
        private System.Windows.Forms.PictureBox pb_GamePic;
        private System.Windows.Forms.DomainUpDown btn_SelectTourn;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.CheckBox cb_Duo;
        private System.Windows.Forms.CheckBox cb_Trio;
        private System.Windows.Forms.CheckBox cb_Quad;
        private System.Windows.Forms.CheckBox cb_Solo;
    }
}