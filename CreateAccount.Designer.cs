namespace Activity4_Ver2
{
    partial class CreateAccount
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
            this.createacc_label = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.TextBox();
            this.pass_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.TextBox();
            this.showpass_checkbox = new System.Windows.Forms.CheckBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.alreadyhaveanacc_label = new System.Windows.Forms.Label();
            this.backtologin_label = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.TextBox();
            this.LogInLinkLabel = new System.Windows.Forms.LinkLabel();
            this.confpass_textbox = new System.Windows.Forms.TextBox();
            this.confpass_label = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createacc_label
            // 
            this.createacc_label.AutoSize = true;
            this.createacc_label.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createacc_label.ForeColor = System.Drawing.Color.Indigo;
            this.createacc_label.Location = new System.Drawing.Point(38, 38);
            this.createacc_label.Name = "createacc_label";
            this.createacc_label.Size = new System.Drawing.Size(217, 38);
            this.createacc_label.TabIndex = 0;
            this.createacc_label.Text = "Create Account";
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.username_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_textbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.username_textbox.Location = new System.Drawing.Point(53, 131);
            this.username_textbox.Multiline = true;
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(324, 28);
            this.username_textbox.TabIndex = 15;
            // 
            // username_label
            // 
            this.username_label.BackColor = System.Drawing.Color.White;
            this.username_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.username_label.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.Gray;
            this.username_label.Location = new System.Drawing.Point(45, 102);
            this.username_label.Multiline = true;
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(159, 23);
            this.username_label.TabIndex = 14;
            this.username_label.Text = "Username";
            // 
            // pass_textbox
            // 
            this.pass_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.pass_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_textbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pass_textbox.Location = new System.Drawing.Point(53, 203);
            this.pass_textbox.Multiline = true;
            this.pass_textbox.Name = "pass_textbox";
            this.pass_textbox.Size = new System.Drawing.Size(324, 28);
            this.pass_textbox.TabIndex = 17;
            // 
            // password_label
            // 
            this.password_label.BackColor = System.Drawing.Color.White;
            this.password_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.password_label.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.Gray;
            this.password_label.Location = new System.Drawing.Point(45, 174);
            this.password_label.Multiline = true;
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(180, 23);
            this.password_label.TabIndex = 16;
            this.password_label.Text = "Password";
            // 
            // showpass_checkbox
            // 
            this.showpass_checkbox.AutoSize = true;
            this.showpass_checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpass_checkbox.ForeColor = System.Drawing.Color.DimGray;
            this.showpass_checkbox.Location = new System.Drawing.Point(53, 363);
            this.showpass_checkbox.Name = "showpass_checkbox";
            this.showpass_checkbox.Size = new System.Drawing.Size(121, 20);
            this.showpass_checkbox.TabIndex = 20;
            this.showpass_checkbox.Text = "Show Password";
            this.showpass_checkbox.UseVisualStyleBackColor = true;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Orange;
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(53, 405);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(324, 40);
            this.registerBtn.TabIndex = 21;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // alreadyhaveanacc_label
            // 
            this.alreadyhaveanacc_label.AutoSize = true;
            this.alreadyhaveanacc_label.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alreadyhaveanacc_label.ForeColor = System.Drawing.Color.Gray;
            this.alreadyhaveanacc_label.Location = new System.Drawing.Point(129, 460);
            this.alreadyhaveanacc_label.Name = "alreadyhaveanacc_label";
            this.alreadyhaveanacc_label.Size = new System.Drawing.Size(169, 17);
            this.alreadyhaveanacc_label.TabIndex = 22;
            this.alreadyhaveanacc_label.Text = "Already Have an Account?";
            // 
            // backtologin_label
            // 
            this.backtologin_label.AutoSize = true;
            this.backtologin_label.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtologin_label.ForeColor = System.Drawing.Color.Indigo;
            this.backtologin_label.Location = new System.Drawing.Point(144, 486);
            this.backtologin_label.Name = "backtologin_label";
            this.backtologin_label.Size = new System.Drawing.Size(70, 23);
            this.backtologin_label.TabIndex = 23;
            this.backtologin_label.Text = "Back to";
            // 
            // email_textbox
            // 
            this.email_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.email_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_textbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.email_textbox.Location = new System.Drawing.Point(53, 329);
            this.email_textbox.Multiline = true;
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(324, 28);
            this.email_textbox.TabIndex = 25;
            // 
            // email_label
            // 
            this.email_label.BackColor = System.Drawing.Color.White;
            this.email_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.email_label.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.Gray;
            this.email_label.Location = new System.Drawing.Point(45, 300);
            this.email_label.Multiline = true;
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(180, 23);
            this.email_label.TabIndex = 24;
            this.email_label.Text = "Email";
            // 
            // LogInLinkLabel
            // 
            this.LogInLinkLabel.AutoSize = true;
            this.LogInLinkLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLinkLabel.LinkColor = System.Drawing.Color.Indigo;
            this.LogInLinkLabel.Location = new System.Drawing.Point(220, 488);
            this.LogInLinkLabel.Name = "LogInLinkLabel";
            this.LogInLinkLabel.Size = new System.Drawing.Size(55, 20);
            this.LogInLinkLabel.TabIndex = 26;
            this.LogInLinkLabel.TabStop = true;
            this.LogInLinkLabel.Text = "LOGIN";
            this.LogInLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogInLinkLabel_LinkClicked);
            // 
            // confpass_textbox
            // 
            this.confpass_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.confpass_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confpass_textbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confpass_textbox.Location = new System.Drawing.Point(53, 266);
            this.confpass_textbox.Multiline = true;
            this.confpass_textbox.Name = "confpass_textbox";
            this.confpass_textbox.Size = new System.Drawing.Size(324, 28);
            this.confpass_textbox.TabIndex = 28;
            // 
            // confpass_label
            // 
            this.confpass_label.BackColor = System.Drawing.Color.White;
            this.confpass_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confpass_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.confpass_label.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confpass_label.ForeColor = System.Drawing.Color.Gray;
            this.confpass_label.Location = new System.Drawing.Point(45, 237);
            this.confpass_label.Multiline = true;
            this.confpass_label.Name = "confpass_label";
            this.confpass_label.Size = new System.Drawing.Size(180, 23);
            this.confpass_label.TabIndex = 27;
            this.confpass_label.Text = "Confirm Password";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 535);
            this.Controls.Add(this.confpass_textbox);
            this.Controls.Add(this.confpass_label);
            this.Controls.Add(this.LogInLinkLabel);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.backtologin_label);
            this.Controls.Add(this.alreadyhaveanacc_label);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.showpass_checkbox);
            this.Controls.Add(this.pass_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.createacc_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createacc_label;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox username_label;
        private System.Windows.Forms.TextBox pass_textbox;
        private System.Windows.Forms.TextBox password_label;
        private System.Windows.Forms.CheckBox showpass_checkbox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label alreadyhaveanacc_label;
        private System.Windows.Forms.Label backtologin_label;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox email_label;
        private System.Windows.Forms.LinkLabel LogInLinkLabel;
        private System.Windows.Forms.TextBox confpass_textbox;
        private System.Windows.Forms.TextBox confpass_label;
    }
}