namespace LoginTool
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.label1 = new System.Windows.Forms.Label();
            this.macTbx = new System.Windows.Forms.TextBox();
            this.roomTbx = new System.Windows.Forms.TextBox();
            this.seatTbx = new System.Windows.Forms.TextBox();
            this.userTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seatDiagramLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAC:";
            // 
            // macTbx
            // 
            this.macTbx.Location = new System.Drawing.Point(72, 13);
            this.macTbx.Name = "macTbx";
            this.macTbx.ReadOnly = true;
            this.macTbx.Size = new System.Drawing.Size(337, 21);
            this.macTbx.TabIndex = 1;
            // 
            // roomTbx
            // 
            this.roomTbx.Location = new System.Drawing.Point(72, 40);
            this.roomTbx.Name = "roomTbx";
            this.roomTbx.Size = new System.Drawing.Size(100, 21);
            this.roomTbx.TabIndex = 0;
            // 
            // seatTbx
            // 
            this.seatTbx.Location = new System.Drawing.Point(72, 67);
            this.seatTbx.Name = "seatTbx";
            this.seatTbx.Size = new System.Drawing.Size(100, 21);
            this.seatTbx.TabIndex = 1;
            // 
            // userTbx
            // 
            this.userTbx.Location = new System.Drawing.Point(309, 40);
            this.userTbx.Name = "userTbx";
            this.userTbx.Size = new System.Drawing.Size(100, 21);
            this.userTbx.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "房间号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "座位号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "使用者姓名(*)：";
            // 
            // seatDiagramLink
            // 
            this.seatDiagramLink.AutoSize = true;
            this.seatDiagramLink.Location = new System.Drawing.Point(15, 100);
            this.seatDiagramLink.Name = "seatDiagramLink";
            this.seatDiagramLink.Size = new System.Drawing.Size(89, 12);
            this.seatDiagramLink.TabIndex = 8;
            this.seatDiagramLink.TabStop = true;
            this.seatDiagramLink.Text = "点击查看座位图";
            this.seatDiagramLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.seatDiagramLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 8F);
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 11);
            this.label5.TabIndex = 9;
            this.label5.Text = "说明：需以管理者模式运行。房间座位号请尽量按实际填写，以避免IP冲突。";
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(309, 70);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(100, 42);
            this.ConfirmBtn.TabIndex = 3;
            this.ConfirmBtn.Text = "确定";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 161);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seatDiagramLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userTbx);
            this.Controls.Add(this.seatTbx);
            this.Controls.Add(this.roomTbx);
            this.Controls.Add(this.macTbx);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.ShowIcon = false;
            this.Text = "网卡配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox macTbx;
        private System.Windows.Forms.TextBox roomTbx;
        private System.Windows.Forms.TextBox seatTbx;
        private System.Windows.Forms.TextBox userTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel seatDiagramLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}