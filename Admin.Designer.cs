using System;
using System.Windows.Forms;

namespace Activity4_Ver2
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ReportIconBtn = new FontAwesome.Sharp.IconButton();
            this.AboutIconBtn = new FontAwesome.Sharp.IconButton();
            this.SignOutBtn = new System.Windows.Forms.Button();
            this.SettingsIconBtn = new FontAwesome.Sharp.IconButton();
            this.AdminIconBtn = new FontAwesome.Sharp.IconButton();
            this.OrdersIconBtn = new FontAwesome.Sharp.IconButton();
            this.ProductIconBtn = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Mail = new FontAwesome.Sharp.IconPictureBox();
            this.Notif = new FontAwesome.Sharp.IconPictureBox();
            this.UserIcon = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsnLabel = new System.Windows.Forms.Label();
            this.usnTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.accountsPanel = new System.Windows.Forms.Panel();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.PanelMenu.SuspendLayout();
            this.Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Indigo;
            this.PanelMenu.Controls.Add(this.ReportIconBtn);
            this.PanelMenu.Controls.Add(this.AboutIconBtn);
            this.PanelMenu.Controls.Add(this.SignOutBtn);
            this.PanelMenu.Controls.Add(this.SettingsIconBtn);
            this.PanelMenu.Controls.Add(this.AdminIconBtn);
            this.PanelMenu.Controls.Add(this.OrdersIconBtn);
            this.PanelMenu.Controls.Add(this.ProductIconBtn);
            this.PanelMenu.Controls.Add(this.Logo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(233, 600);
            this.PanelMenu.TabIndex = 2;
            // 
            // ReportIconBtn
            // 
            this.ReportIconBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportIconBtn.FlatAppearance.BorderSize = 0;
            this.ReportIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportIconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportIconBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ReportIconBtn.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.ReportIconBtn.IconColor = System.Drawing.Color.DarkOrange;
            this.ReportIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReportIconBtn.IconSize = 40;
            this.ReportIconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportIconBtn.Location = new System.Drawing.Point(0, 425);
            this.ReportIconBtn.Name = "ReportIconBtn";
            this.ReportIconBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ReportIconBtn.Size = new System.Drawing.Size(233, 62);
            this.ReportIconBtn.TabIndex = 10;
            this.ReportIconBtn.Text = "REPORT";
            this.ReportIconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportIconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReportIconBtn.UseVisualStyleBackColor = true;
            // 
            // AboutIconBtn
            // 
            this.AboutIconBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutIconBtn.FlatAppearance.BorderSize = 0;
            this.AboutIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutIconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutIconBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AboutIconBtn.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.AboutIconBtn.IconColor = System.Drawing.Color.DarkOrange;
            this.AboutIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AboutIconBtn.IconSize = 40;
            this.AboutIconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutIconBtn.Location = new System.Drawing.Point(0, 363);
            this.AboutIconBtn.Name = "AboutIconBtn";
            this.AboutIconBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AboutIconBtn.Size = new System.Drawing.Size(233, 62);
            this.AboutIconBtn.TabIndex = 9;
            this.AboutIconBtn.Text = "ABOUT";
            this.AboutIconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutIconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AboutIconBtn.UseVisualStyleBackColor = true;
            // 
            // SignOutBtn
            // 
            this.SignOutBtn.BackColor = System.Drawing.Color.Lavender;
            this.SignOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignOutBtn.Location = new System.Drawing.Point(23, 511);
            this.SignOutBtn.Name = "SignOutBtn";
            this.SignOutBtn.Size = new System.Drawing.Size(181, 34);
            this.SignOutBtn.TabIndex = 8;
            this.SignOutBtn.Text = "Sign Out";
            this.SignOutBtn.UseVisualStyleBackColor = false;
            this.SignOutBtn.Click += new System.EventHandler(this.SignOutBtn_Click);
            // 
            // SettingsIconBtn
            // 
            this.SettingsIconBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsIconBtn.FlatAppearance.BorderSize = 0;
            this.SettingsIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsIconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsIconBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SettingsIconBtn.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.SettingsIconBtn.IconColor = System.Drawing.Color.DarkOrange;
            this.SettingsIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsIconBtn.IconSize = 40;
            this.SettingsIconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsIconBtn.Location = new System.Drawing.Point(0, 301);
            this.SettingsIconBtn.Name = "SettingsIconBtn";
            this.SettingsIconBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SettingsIconBtn.Size = new System.Drawing.Size(233, 62);
            this.SettingsIconBtn.TabIndex = 6;
            this.SettingsIconBtn.Text = "SETTINGS";
            this.SettingsIconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsIconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsIconBtn.UseVisualStyleBackColor = true;
            // 
            // AdminIconBtn
            // 
            this.AdminIconBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminIconBtn.FlatAppearance.BorderSize = 0;
            this.AdminIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminIconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminIconBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AdminIconBtn.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.AdminIconBtn.IconColor = System.Drawing.Color.DarkOrange;
            this.AdminIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AdminIconBtn.IconSize = 40;
            this.AdminIconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminIconBtn.Location = new System.Drawing.Point(0, 239);
            this.AdminIconBtn.Name = "AdminIconBtn";
            this.AdminIconBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AdminIconBtn.Size = new System.Drawing.Size(233, 62);
            this.AdminIconBtn.TabIndex = 4;
            this.AdminIconBtn.Text = "ADMIN";
            this.AdminIconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminIconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AdminIconBtn.UseVisualStyleBackColor = true;
            // 
            // OrdersIconBtn
            // 
            this.OrdersIconBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdersIconBtn.FlatAppearance.BorderSize = 0;
            this.OrdersIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersIconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersIconBtn.ForeColor = System.Drawing.Color.Transparent;
            this.OrdersIconBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.OrdersIconBtn.IconColor = System.Drawing.Color.DarkOrange;
            this.OrdersIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OrdersIconBtn.IconSize = 40;
            this.OrdersIconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersIconBtn.Location = new System.Drawing.Point(0, 178);
            this.OrdersIconBtn.Name = "OrdersIconBtn";
            this.OrdersIconBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.OrdersIconBtn.Size = new System.Drawing.Size(233, 61);
            this.OrdersIconBtn.TabIndex = 3;
            this.OrdersIconBtn.Text = "ORDERS";
            this.OrdersIconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersIconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrdersIconBtn.UseVisualStyleBackColor = true;
            // 
            // ProductIconBtn
            // 
            this.ProductIconBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductIconBtn.FlatAppearance.BorderSize = 0;
            this.ProductIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductIconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIconBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ProductIconBtn.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.ProductIconBtn.IconColor = System.Drawing.Color.DarkOrange;
            this.ProductIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProductIconBtn.IconSize = 40;
            this.ProductIconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductIconBtn.Location = new System.Drawing.Point(0, 109);
            this.ProductIconBtn.Name = "ProductIconBtn";
            this.ProductIconBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ProductIconBtn.Size = new System.Drawing.Size(233, 69);
            this.ProductIconBtn.TabIndex = 1;
            this.ProductIconBtn.Text = "PRODUCTS";
            this.ProductIconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductIconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductIconBtn.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            this.Logo.Controls.Add(this.pictureBox1);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(233, 109);
            this.Logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Mail);
            this.panel1.Controls.Add(this.Notif);
            this.panel1.Controls.Add(this.UserIcon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(233, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 109);
            this.panel1.TabIndex = 4;
            // 
            // Mail
            // 
            this.Mail.BackColor = System.Drawing.Color.Indigo;
            this.Mail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.Mail.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Mail.Location = new System.Drawing.Point(726, 34);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(33, 32);
            this.Mail.TabIndex = 7;
            this.Mail.TabStop = false;
            // 
            // Notif
            // 
            this.Notif.BackColor = System.Drawing.Color.Indigo;
            this.Notif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Notif.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.Notif.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.Notif.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Notif.Location = new System.Drawing.Point(765, 34);
            this.Notif.Name = "Notif";
            this.Notif.Size = new System.Drawing.Size(33, 32);
            this.Notif.TabIndex = 6;
            this.Notif.TabStop = false;
            // 
            // UserIcon
            // 
            this.UserIcon.BackColor = System.Drawing.Color.Indigo;
            this.UserIcon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserIcon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.UserIcon.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserIcon.IconSize = 30;
            this.UserIcon.Location = new System.Drawing.Point(804, 34);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(30, 32);
            this.UserIcon.TabIndex = 5;
            this.UserIcon.TabStop = false;
            this.UserIcon.Click += new System.EventHandler(this.UserIcon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Management";
            // 
            // UsnLabel
            // 
            this.UsnLabel.AutoSize = true;
            this.UsnLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsnLabel.ForeColor = System.Drawing.Color.White;
            this.UsnLabel.Location = new System.Drawing.Point(325, 417);
            this.UsnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsnLabel.Name = "UsnLabel";
            this.UsnLabel.Size = new System.Drawing.Size(89, 23);
            this.UsnLabel.TabIndex = 40;
            this.UsnLabel.Text = "Username";
            // 
            // usnTextbox
            // 
            this.usnTextbox.Location = new System.Drawing.Point(329, 444);
            this.usnTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usnTextbox.Name = "usnTextbox";
            this.usnTextbox.Size = new System.Drawing.Size(253, 22);
            this.usnTextbox.TabIndex = 39;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(719, 419);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 23);
            this.emailLabel.TabIndex = 38;
            this.emailLabel.Text = "Email";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(723, 444);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(253, 22);
            this.emailTextbox.TabIndex = 37;
            // 
            // accountsPanel
            // 
            this.accountsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.accountsPanel.Location = new System.Drawing.Point(329, 201);
            this.accountsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.accountsPanel.Name = "accountsPanel";
            this.accountsPanel.Size = new System.Drawing.Size(647, 194);
            this.accountsPanel.TabIndex = 35;
            this.accountsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.accountsPanel_Paint);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.Location = new System.Drawing.Point(479, 137);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(497, 34);
            this.searchTextbox.TabIndex = 36;
            this.searchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(600, 511);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(112, 36);
            this.Update.TabIndex = 41;
            this.Update.Text = "UPDATE";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.Window;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(329, 137);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(112, 34);
            this.SearchBtn.TabIndex = 42;
            this.SearchBtn.Text = "SEARCH";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.UsnLabel);
            this.Controls.Add(this.usnTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.accountsPanel);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.PanelMenu.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private FontAwesome.Sharp.IconButton ReportIconBtn;
        private FontAwesome.Sharp.IconButton AboutIconBtn;
        private System.Windows.Forms.Button SignOutBtn;
        private FontAwesome.Sharp.IconButton SettingsIconBtn;
        private FontAwesome.Sharp.IconButton AdminIconBtn;
        private FontAwesome.Sharp.IconButton OrdersIconBtn;
        private FontAwesome.Sharp.IconButton ProductIconBtn;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox Mail;
        private FontAwesome.Sharp.IconPictureBox Notif;
        private FontAwesome.Sharp.IconPictureBox UserIcon;
        private Label UsnLabel;
        private TextBox usnTextbox;
        private Label emailLabel;
        private TextBox emailTextbox;
        private Panel accountsPanel;
        private TextBox searchTextbox;
        private new Button Update;
        private Button SearchBtn;
    }
}