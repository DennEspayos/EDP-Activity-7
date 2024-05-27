namespace Activity4_Ver2
{
    partial class ForgotPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogInLinkLabel = new System.Windows.Forms.LinkLabel();
            this.backtologin_label = new System.Windows.Forms.Label();
            this.showpassCheckbox = new System.Windows.Forms.CheckBox();
            this.confnewpass_textbox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resetpassBtn = new System.Windows.Forms.Button();
            this.newpassword_textbox = new System.Windows.Forms.TextBox();
            this.securityquestion = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.LogInLinkLabel);
            this.panel1.Controls.Add(this.backtologin_label);
            this.panel1.Controls.Add(this.showpassCheckbox);
            this.panel1.Controls.Add(this.confnewpass_textbox);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.resetpassBtn);
            this.panel1.Controls.Add(this.newpassword_textbox);
            this.panel1.Controls.Add(this.securityquestion);
            this.panel1.Controls.Add(this.username_textbox);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Location = new System.Drawing.Point(35, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 434);
            this.panel1.TabIndex = 1;
            // 
            // LogInLinkLabel
            // 
            this.LogInLinkLabel.AutoSize = true;
            this.LogInLinkLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLinkLabel.LinkColor = System.Drawing.Color.Indigo;
            this.LogInLinkLabel.Location = new System.Drawing.Point(190, 380);
            this.LogInLinkLabel.Name = "LogInLinkLabel";
            this.LogInLinkLabel.Size = new System.Drawing.Size(55, 20);
            this.LogInLinkLabel.TabIndex = 28;
            this.LogInLinkLabel.TabStop = true;
            this.LogInLinkLabel.Text = "LOGIN";
            this.LogInLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogInLinkLabel_LinkClicked);
            // 
            // backtologin_label
            // 
            this.backtologin_label.AutoSize = true;
            this.backtologin_label.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtologin_label.ForeColor = System.Drawing.Color.Indigo;
            this.backtologin_label.Location = new System.Drawing.Point(114, 378);
            this.backtologin_label.Name = "backtologin_label";
            this.backtologin_label.Size = new System.Drawing.Size(70, 23);
            this.backtologin_label.TabIndex = 27;
            this.backtologin_label.Text = "Back to";
            // 
            // showpassCheckbox
            // 
            this.showpassCheckbox.AutoSize = true;
            this.showpassCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpassCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showpassCheckbox.Location = new System.Drawing.Point(29, 290);
            this.showpassCheckbox.Name = "showpassCheckbox";
            this.showpassCheckbox.Size = new System.Drawing.Size(124, 20);
            this.showpassCheckbox.TabIndex = 26;
            this.showpassCheckbox.Text = "Show password";
            this.showpassCheckbox.UseVisualStyleBackColor = true;
            this.showpassCheckbox.CheckedChanged += new System.EventHandler(this.showpassCheckbox_CheckedChanged);
            // 
            // confnewpass_textbox
            // 
            this.confnewpass_textbox.BackColor = System.Drawing.Color.White;
            this.confnewpass_textbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confnewpass_textbox.Location = new System.Drawing.Point(29, 252);
            this.confnewpass_textbox.Name = "confnewpass_textbox";
            this.confnewpass_textbox.Size = new System.Drawing.Size(304, 22);
            this.confnewpass_textbox.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(29, 224);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 22);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "Confirm New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Password Recovery";
            // 
            // resetpassBtn
            // 
            this.resetpassBtn.BackColor = System.Drawing.Color.Orange;
            this.resetpassBtn.FlatAppearance.BorderSize = 0;
            this.resetpassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetpassBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetpassBtn.ForeColor = System.Drawing.Color.White;
            this.resetpassBtn.Location = new System.Drawing.Point(29, 325);
            this.resetpassBtn.Name = "resetpassBtn";
            this.resetpassBtn.Size = new System.Drawing.Size(304, 40);
            this.resetpassBtn.TabIndex = 22;
            this.resetpassBtn.Text = "Reset Password";
            this.resetpassBtn.UseVisualStyleBackColor = false;
            this.resetpassBtn.Click += new System.EventHandler(this.resetpassBtn_Click_1);
            // 
            // newpassword_textbox
            // 
            this.newpassword_textbox.BackColor = System.Drawing.Color.White;
            this.newpassword_textbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newpassword_textbox.Location = new System.Drawing.Point(29, 182);
            this.newpassword_textbox.Name = "newpassword_textbox";
            this.newpassword_textbox.Size = new System.Drawing.Size(304, 22);
            this.newpassword_textbox.TabIndex = 15;
            // 
            // securityquestion
            // 
            this.securityquestion.BackColor = System.Drawing.Color.GhostWhite;
            this.securityquestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.securityquestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.securityquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityquestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.securityquestion.Location = new System.Drawing.Point(29, 154);
            this.securityquestion.Multiline = true;
            this.securityquestion.Name = "securityquestion";
            this.securityquestion.Size = new System.Drawing.Size(221, 22);
            this.securityquestion.TabIndex = 14;
            this.securityquestion.Text = "Create New Password";
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.Color.White;
            this.username_textbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.username_textbox.Location = new System.Drawing.Point(29, 117);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(304, 22);
            this.username_textbox.TabIndex = 13;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.GhostWhite;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Cursor = System.Windows.Forms.Cursors.Default;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username.Location = new System.Drawing.Point(29, 88);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(124, 23);
            this.Username.TabIndex = 7;
            this.Username.Text = "Username";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(432, 513);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Recovery";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetpassBtn;
        private System.Windows.Forms.TextBox newpassword_textbox;
        private System.Windows.Forms.TextBox securityquestion;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confnewpass_textbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox showpassCheckbox;
        private System.Windows.Forms.LinkLabel LogInLinkLabel;
        private System.Windows.Forms.Label backtologin_label;
    }
}