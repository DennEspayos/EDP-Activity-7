namespace Activity4_Ver2
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.TopSellingBtn = new System.Windows.Forms.Button();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.LowStocksBtn = new System.Windows.Forms.Button();
            this.SignOutBtn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.LogoDesignPicbox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReportsHeaderLbl = new System.Windows.Forms.Label();
            this.Mail = new FontAwesome.Sharp.IconPictureBox();
            this.Notif = new FontAwesome.Sharp.IconPictureBox();
            this.UserIcon = new FontAwesome.Sharp.IconPictureBox();
            this.HomeLbl = new System.Windows.Forms.Label();
            this.HomeIcon = new FontAwesome.Sharp.IconPictureBox();
            this.ReportPanel = new System.Windows.Forms.Panel();
            this.GenReportBtn = new System.Windows.Forms.Button();
            this.PanelMenu.SuspendLayout();
            this.Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoDesignPicbox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Indigo;
            this.PanelMenu.Controls.Add(this.TopSellingBtn);
            this.PanelMenu.Controls.Add(this.SalesBtn);
            this.PanelMenu.Controls.Add(this.LowStocksBtn);
            this.PanelMenu.Controls.Add(this.SignOutBtn);
            this.PanelMenu.Controls.Add(this.Logo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(233, 600);
            this.PanelMenu.TabIndex = 2;
            // 
            // TopSellingBtn
            // 
            this.TopSellingBtn.BackColor = System.Drawing.Color.Indigo;
            this.TopSellingBtn.FlatAppearance.BorderSize = 2;
            this.TopSellingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopSellingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopSellingBtn.ForeColor = System.Drawing.Color.Linen;
            this.TopSellingBtn.Location = new System.Drawing.Point(-5, 262);
            this.TopSellingBtn.Name = "TopSellingBtn";
            this.TopSellingBtn.Size = new System.Drawing.Size(250, 57);
            this.TopSellingBtn.TabIndex = 47;
            this.TopSellingBtn.Text = "Top Selling Products";
            this.TopSellingBtn.UseVisualStyleBackColor = false;
            this.TopSellingBtn.Click += new System.EventHandler(this.TopSellingBtn_Click);

            // 
            // SalesBtn
            // 
            this.SalesBtn.BackColor = System.Drawing.Color.Indigo;
            this.SalesBtn.FlatAppearance.BorderSize = 2;
            this.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBtn.ForeColor = System.Drawing.Color.Linen;
            this.SalesBtn.Location = new System.Drawing.Point(-5, 188);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Size = new System.Drawing.Size(250, 57);
            this.SalesBtn.TabIndex = 46;
            this.SalesBtn.Text = "Sales ";
            this.SalesBtn.UseVisualStyleBackColor = false;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);


            // 
            // LowStocksBtn
            // 
            this.LowStocksBtn.BackColor = System.Drawing.Color.Indigo;
            this.LowStocksBtn.FlatAppearance.BorderSize = 2;
            this.LowStocksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LowStocksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowStocksBtn.ForeColor = System.Drawing.Color.Linen;
            this.LowStocksBtn.Location = new System.Drawing.Point(-5, 115);
            this.LowStocksBtn.Name = "LowStocksBtn";
            this.LowStocksBtn.Size = new System.Drawing.Size(250, 57);
            this.LowStocksBtn.TabIndex = 45;
            this.LowStocksBtn.Text = "Low Stocks Alert";
            this.LowStocksBtn.UseVisualStyleBackColor = false;
            this.LowStocksBtn.Click += new System.EventHandler(this.LowStocksBtn_Click);

            // 
            // SignOutBtn
            // 
            this.SignOutBtn.BackColor = System.Drawing.Color.Lavender;
            this.SignOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignOutBtn.Location = new System.Drawing.Point(26, 476);
            this.SignOutBtn.Name = "SignOutBtn";
            this.SignOutBtn.Size = new System.Drawing.Size(181, 34);
            this.SignOutBtn.TabIndex = 8;
            this.SignOutBtn.Text = "Sign Out";
            this.SignOutBtn.UseVisualStyleBackColor = false;
            // 
            // Logo
            // 
            this.Logo.Controls.Add(this.LogoDesignPicbox);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(233, 109);
            this.Logo.TabIndex = 0;
            // 
            // LogoDesignPicbox
            // 
            this.LogoDesignPicbox.Image = ((System.Drawing.Image)(resources.GetObject("LogoDesignPicbox.Image")));
            this.LogoDesignPicbox.Location = new System.Drawing.Point(-5, 0);
            this.LogoDesignPicbox.Name = "LogoDesignPicbox";
            this.LogoDesignPicbox.Size = new System.Drawing.Size(238, 133);
            this.LogoDesignPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoDesignPicbox.TabIndex = 0;
            this.LogoDesignPicbox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.ReportsHeaderLbl);
            this.panel1.Controls.Add(this.Mail);
            this.panel1.Controls.Add(this.Notif);
            this.panel1.Controls.Add(this.UserIcon);
            this.panel1.Controls.Add(this.HomeLbl);
            this.panel1.Controls.Add(this.HomeIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(233, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 68);
            this.panel1.TabIndex = 3;
            // 
            // ReportsHeaderLbl
            // 
            this.ReportsHeaderLbl.AutoSize = true;
            this.ReportsHeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsHeaderLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReportsHeaderLbl.Location = new System.Drawing.Point(327, 19);
            this.ReportsHeaderLbl.Name = "ReportsHeaderLbl";
            this.ReportsHeaderLbl.Size = new System.Drawing.Size(157, 32);
            this.ReportsHeaderLbl.TabIndex = 5;
            this.ReportsHeaderLbl.Text = "REPORTS";
            this.ReportsHeaderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mail
            // 
            this.Mail.BackColor = System.Drawing.Color.Indigo;
            this.Mail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.Mail.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Mail.Location = new System.Drawing.Point(694, 14);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(33, 32);
            this.Mail.TabIndex = 4;
            this.Mail.TabStop = false;
            // 
            // Notif
            // 
            this.Notif.BackColor = System.Drawing.Color.Indigo;
            this.Notif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Notif.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.Notif.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.Notif.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Notif.Location = new System.Drawing.Point(733, 14);
            this.Notif.Name = "Notif";
            this.Notif.Size = new System.Drawing.Size(33, 32);
            this.Notif.TabIndex = 3;
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
            this.UserIcon.Location = new System.Drawing.Point(772, 14);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(30, 32);
            this.UserIcon.TabIndex = 2;
            this.UserIcon.TabStop = false;
            // 
            // HomeLbl
            // 
            this.HomeLbl.AutoSize = true;
            this.HomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLbl.ForeColor = System.Drawing.Color.Snow;
            this.HomeLbl.Location = new System.Drawing.Point(49, 26);
            this.HomeLbl.Name = "HomeLbl";
            this.HomeLbl.Size = new System.Drawing.Size(54, 20);
            this.HomeLbl.TabIndex = 1;
            this.HomeLbl.Text = "Home";
            this.HomeLbl.Click += new System.EventHandler(this.HomeLbl_Click);
            // 
            // HomeIcon
            // 
            this.HomeIcon.BackColor = System.Drawing.Color.Indigo;
            this.HomeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeIcon.ForeColor = System.Drawing.Color.Snow;
            this.HomeIcon.IconChar = FontAwesome.Sharp.IconChar.House;
            this.HomeIcon.IconColor = System.Drawing.Color.Snow;
            this.HomeIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeIcon.IconSize = 27;
            this.HomeIcon.Location = new System.Drawing.Point(16, 19);
            this.HomeIcon.Name = "HomeIcon";
            this.HomeIcon.Size = new System.Drawing.Size(27, 27);
            this.HomeIcon.TabIndex = 0;
            this.HomeIcon.TabStop = false;
            this.HomeIcon.Click += new System.EventHandler(this.HomeIcon_Click);
            // 
            // ReportPanel
            // 
            this.ReportPanel.BackColor = System.Drawing.SystemColors.Window;
            this.ReportPanel.Location = new System.Drawing.Point(286, 119);
            this.ReportPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ReportPanel.Name = "ReportPanel";
            this.ReportPanel.Size = new System.Drawing.Size(749, 350);
            this.ReportPanel.TabIndex = 36;
            // 
            // GenReportBtn
            // 
            this.GenReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenReportBtn.Location = new System.Drawing.Point(560, 505);
            this.GenReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GenReportBtn.Name = "GenReportBtn";
            this.GenReportBtn.Size = new System.Drawing.Size(157, 36);
            this.GenReportBtn.TabIndex = 42;
            this.GenReportBtn.Text = "Generate Report";
            this.GenReportBtn.UseVisualStyleBackColor = true;
            this.GenReportBtn.Click += new System.EventHandler(this.GenReportBtn_Click);

            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.GenReportBtn);
            this.Controls.Add(this.ReportPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.PanelMenu.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoDesignPicbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button SignOutBtn;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.PictureBox LogoDesignPicbox;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox Mail;
        private FontAwesome.Sharp.IconPictureBox Notif;
        private FontAwesome.Sharp.IconPictureBox UserIcon;
        private System.Windows.Forms.Panel ReportPanel;
        private System.Windows.Forms.Button GenReportBtn;
        private System.Windows.Forms.Button LowStocksBtn;
        private System.Windows.Forms.Button TopSellingBtn;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.Label ReportsHeaderLbl;
        private System.Windows.Forms.Label HomeLbl;
        private FontAwesome.Sharp.IconPictureBox HomeIcon;
    }
}