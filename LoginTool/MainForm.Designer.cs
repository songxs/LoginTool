namespace LoginTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ResultTbx = new System.Windows.Forms.TextBox();
            this.InfoBrowser = new System.Windows.Forms.WebBrowser();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ConfigMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoConfigMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginBtn.Location = new System.Drawing.Point(505, 309);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(10);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(93, 52);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "登录";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ResultTbx
            // 
            this.ResultTbx.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultTbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTbx.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResultTbx.Location = new System.Drawing.Point(8, 309);
            this.ResultTbx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ResultTbx.Multiline = true;
            this.ResultTbx.Name = "ResultTbx";
            this.ResultTbx.ReadOnly = true;
            this.ResultTbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTbx.Size = new System.Drawing.Size(484, 59);
            this.ResultTbx.TabIndex = 1;
            // 
            // InfoBrowser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.InfoBrowser, 2);
            this.InfoBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoBrowser.Location = new System.Drawing.Point(8, 3);
            this.InfoBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.InfoBrowser.Name = "InfoBrowser";
            this.InfoBrowser.Size = new System.Drawing.Size(597, 293);
            this.InfoBrowser.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigMItem,
            this.HelpMItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(613, 25);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ConfigMItem
            // 
            this.ConfigMItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoConfigMItem});
            this.ConfigMItem.Name = "ConfigMItem";
            this.ConfigMItem.Size = new System.Drawing.Size(44, 21);
            this.ConfigMItem.Text = "设置";
            // 
            // AutoConfigMItem
            // 
            this.AutoConfigMItem.Name = "AutoConfigMItem";
            this.AutoConfigMItem.Size = new System.Drawing.Size(124, 22);
            this.AutoConfigMItem.Text = "配置网卡";
            this.AutoConfigMItem.Click += new System.EventHandler(this.AutoConfigMItem_Click);
            // 
            // HelpMItem
            // 
            this.HelpMItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMItem});
            this.HelpMItem.Name = "HelpMItem";
            this.HelpMItem.Size = new System.Drawing.Size(44, 21);
            this.HelpMItem.Text = "帮助";
            // 
            // AboutMItem
            // 
            this.AboutMItem.Name = "AboutMItem";
            this.AboutMItem.Size = new System.Drawing.Size(100, 22);
            this.AboutMItem.Text = "关于";
            this.AboutMItem.Click += new System.EventHandler(this.AboutMItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.31488F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.68512F));
            this.tableLayoutPanel1.Controls.Add(this.InfoBrowser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ResultTbx, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LoginBtn, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.86253F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.13747F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(613, 376);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 401);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "网格中心实验室上网登陆器 v1.0beta";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox ResultTbx;
        private System.Windows.Forms.WebBrowser InfoBrowser;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ConfigMItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMItem;
        private System.Windows.Forms.ToolStripMenuItem AutoConfigMItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

