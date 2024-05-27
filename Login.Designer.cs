namespace Activity4_Ver2
{
    partial class Login
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
            this.CreateNewAcc = new System.Windows.Forms.LinkLabel();
            this.LOGINbtn = new System.Windows.Forms.Button();
            this.showpass_checkbox = new System.Windows.Forms.CheckBox();
            this.F_Password = new System.Windows.Forms.LinkLabel();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.CreateNewAcc);
            this.panel1.Controls.Add(this.LOGINbtn);
            this.panel1.Controls.Add(this.showpass_checkbox);
            this.panel1.Controls.Add(this.F_Password);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.username_textbox);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(34, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 434);
            this.panel1.TabIndex = 0;
            // 
            // CreateNewAcc
            // 
            this.CreateNewAcc.AutoSize = true;
            this.CreateNewAcc.LinkColor = System.Drawing.Color.Black;
            this.CreateNewAcc.Location = new System.Drawing.Point(117, 388);
            this.CreateNewAcc.Name = "CreateNewAcc";
            this.CreateNewAcc.Size = new System.Drawing.Size(128, 16);
            this.CreateNewAcc.TabIndex = 11;
            this.CreateNewAcc.TabStop = true;
            this.CreateNewAcc.Text = "Create New Account";
            this.CreateNewAcc.VisitedLinkColor = System.Drawing.Color.Blue;
            this.CreateNewAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewAcc_LinkClicked);
            // 
            // LOGINbtn
            // 
            this.LOGINbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.LOGINbtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LOGINbtn.FlatAppearance.BorderSize = 0;
            this.LOGINbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LOGINbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LOGINbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGINbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGINbtn.Location = new System.Drawing.Point(30, 324);
            this.LOGINbtn.Name = "LOGINbtn";
            this.LOGINbtn.Size = new System.Drawing.Size(304, 47);
            this.LOGINbtn.TabIndex = 16;
            this.LOGINbtn.Text = "LOGIN";
            this.LOGINbtn.UseVisualStyleBackColor = false;
            this.LOGINbtn.Click += new System.EventHandler(this.LOGINbtn_Click);

            // 
            // showpass_checkbox
            // 
            this.showpass_checkbox.AutoSize = true;
            this.showpass_checkbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.showpass_checkbox.Location = new System.Drawing.Point(30, 281);
            this.showpass_checkbox.Name = "showpass_checkbox";
            this.showpass_checkbox.Size = new System.Drawing.Size(125, 20);
            this.showpass_checkbox.TabIndex = 10;
            this.showpass_checkbox.Text = "Show Password";
            this.showpass_checkbox.UseVisualStyleBackColor = true;
            this.showpass_checkbox.CheckedChanged += new System.EventHandler(this.showpass_checkbox_CheckedChanged);

            // 
            // F_Password
            // 
            this.F_Password.AutoSize = true;
            this.F_Password.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.F_Password.LinkColor = System.Drawing.Color.Black;
            this.F_Password.Location = new System.Drawing.Point(218, 282);
            this.F_Password.Name = "F_Password";
            this.F_Password.Size = new System.Drawing.Size(116, 16);
            this.F_Password.TabIndex = 15;
            this.F_Password.TabStop = true;
            this.F_Password.Text = "Forgot Password?";
            this.F_Password.VisitedLinkColor = System.Drawing.Color.Blue;
            this.F_Password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.F_Password_LinkClicked);

            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.Color.White;
            this.password_textbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.password_textbox.Location = new System.Drawing.Point(30, 234);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(304, 22);
            this.password_textbox.TabIndex = 15;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.GhostWhite;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.Location = new System.Drawing.Point(30, 206);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(125, 22);
            this.Password.TabIndex = 14;
            this.Password.Text = "Password";
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.Color.White;
            this.username_textbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.username_textbox.Location = new System.Drawing.Point(30, 163);
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
            this.Username.Location = new System.Drawing.Point(30, 134);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(125, 23);
            this.Username.TabIndex = 7;
            this.Username.Text = "Username";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 63);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOG IN";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(38, 63);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 39);
            this.panel2.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(432, 513);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button LOGINbtn;
        private System.Windows.Forms.CheckBox showpass_checkbox;
        private System.Windows.Forms.LinkLabel F_Password;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.LinkLabel CreateNewAcc;
    }
}

