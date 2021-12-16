
namespace ClientWcfService1WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddHealthData = new System.Windows.Forms.Button();
            this.buttonHealthData = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonAddHealthData);
            this.panelMenu.Controls.Add(this.buttonHealthData);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.Image = global::ClientWcfService1WinFormsApp.Properties.Resources.icons8_close_window_50;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(0, 501);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonExit.Size = new System.Drawing.Size(200, 60);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "   Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAddHealthData
            // 
            this.buttonAddHealthData.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddHealthData.FlatAppearance.BorderSize = 0;
            this.buttonAddHealthData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddHealthData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddHealthData.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddHealthData.Image = global::ClientWcfService1WinFormsApp.Properties.Resources.icons8_add_50;
            this.buttonAddHealthData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddHealthData.Location = new System.Drawing.Point(0, 140);
            this.buttonAddHealthData.Name = "buttonAddHealthData";
            this.buttonAddHealthData.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonAddHealthData.Size = new System.Drawing.Size(200, 60);
            this.buttonAddHealthData.TabIndex = 2;
            this.buttonAddHealthData.Text = "Add Health Data";
            this.buttonAddHealthData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddHealthData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddHealthData.UseVisualStyleBackColor = true;
            this.buttonAddHealthData.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHealthData
            // 
            this.buttonHealthData.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHealthData.FlatAppearance.BorderSize = 0;
            this.buttonHealthData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHealthData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHealthData.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHealthData.Image = global::ClientWcfService1WinFormsApp.Properties.Resources.icons8_health_data_50_white;
            this.buttonHealthData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHealthData.Location = new System.Drawing.Point(0, 80);
            this.buttonHealthData.Name = "buttonHealthData";
            this.buttonHealthData.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonHealthData.Size = new System.Drawing.Size(200, 60);
            this.buttonHealthData.TabIndex = 1;
            this.buttonHealthData.Text = "   Health Data";
            this.buttonHealthData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHealthData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHealthData.UseVisualStyleBackColor = true;
            this.buttonHealthData.Click += new System.EventHandler(this.buttonHealthData_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panelLogo.Controls.Add(this.buttonHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHome.Image = global::ClientWcfService1WinFormsApp.Properties.Resources.icons8_apple_logo_60;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(200, 80);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panelTitlebar.Controls.Add(this.labelTitle);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(200, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(659, 80);
            this.panelTitlebar.TabIndex = 1;
            this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseDown);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(160, 17);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(316, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Apple Watch Data Center";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackgroundImage = global::ClientWcfService1WinFormsApp.Properties.Resources.icons8_apple_watch_96;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(659, 481);
            this.panelDesktop.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Apple Watch Data Center";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddHealthData;
        private System.Windows.Forms.Button buttonHealthData;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

