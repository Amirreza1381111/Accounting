
namespace Accounting.App
{
    partial class Mainfrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Settingtsb = new System.Windows.Forms.ToolStripSplitButton();
            this.LoginSettingbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.Customersbtn = new System.Windows.Forms.ToolStripButton();
            this.AddAccountingtsb = new System.Windows.Forms.ToolStripButton();
            this.PayReportstsb = new System.Windows.Forms.ToolStripButton();
            this.ReceiveReportstsb = new System.Windows.Forms.ToolStripButton();
            this.backgroundpb = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Datetssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timetssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeTimer = new System.Windows.Forms.Timer(this.components);
            this.Reportgb = new System.Windows.Forms.GroupBox();
            this.RemainShowlbl = new System.Windows.Forms.Label();
            this.PayShowlbl = new System.Windows.Forms.Label();
            this.ReceiveShowlbl = new System.Windows.Forms.Label();
            this.RemainReportlbl = new System.Windows.Forms.Label();
            this.PayReportlbl = new System.Windows.Forms.Label();
            this.ReceiveReportlbl = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundpb)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.Reportgb.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settingtsb,
            this.Customersbtn,
            this.AddAccountingtsb,
            this.PayReportstsb,
            this.ReceiveReportstsb});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Settingtsb
            // 
            this.Settingtsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Settingtsb.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginSettingbtn});
            this.Settingtsb.Image = ((System.Drawing.Image)(resources.GetObject("Settingtsb.Image")));
            this.Settingtsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Settingtsb.Name = "Settingtsb";
            this.Settingtsb.Size = new System.Drawing.Size(85, 64);
            this.Settingtsb.Text = "تنضیمات";
            // 
            // LoginSettingbtn
            // 
            this.LoginSettingbtn.Name = "LoginSettingbtn";
            this.LoginSettingbtn.Size = new System.Drawing.Size(182, 26);
            this.LoginSettingbtn.Text = "تنضیمات ورود";
            this.LoginSettingbtn.Click += new System.EventHandler(this.LoginSettingbtn_Click);
            // 
            // Customersbtn
            // 
            this.Customersbtn.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.Customersbtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Customersbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Customersbtn.Name = "Customersbtn";
            this.Customersbtn.Size = new System.Drawing.Size(115, 64);
            this.Customersbtn.Text = "مدیریت اشخاص";
            this.Customersbtn.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Customersbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Customersbtn.Click += new System.EventHandler(this.Customersbtn_Click);
            // 
            // AddAccountingtsb
            // 
            this.AddAccountingtsb.Image = global::Accounting.App.Properties.Resources.list2;
            this.AddAccountingtsb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddAccountingtsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddAccountingtsb.Name = "AddAccountingtsb";
            this.AddAccountingtsb.Size = new System.Drawing.Size(92, 64);
            this.AddAccountingtsb.Text = "تراکنش جدید";
            this.AddAccountingtsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddAccountingtsb.Click += new System.EventHandler(this.AddAccountingtsb_Click);
            // 
            // PayReportstsb
            // 
            this.PayReportstsb.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.PayReportstsb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PayReportstsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PayReportstsb.Name = "PayReportstsb";
            this.PayReportstsb.Size = new System.Drawing.Size(124, 64);
            this.PayReportstsb.Text = "گزارش پرداختی ها";
            this.PayReportstsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PayReportstsb.Click += new System.EventHandler(this.PayReportstsb_Click);
            // 
            // ReceiveReportstsb
            // 
            this.ReceiveReportstsb.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.ReceiveReportstsb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReceiveReportstsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReceiveReportstsb.Name = "ReceiveReportstsb";
            this.ReceiveReportstsb.Size = new System.Drawing.Size(125, 64);
            this.ReceiveReportstsb.Text = "گزارش دریافتی ها";
            this.ReceiveReportstsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ReceiveReportstsb.Click += new System.EventHandler(this.ReceiveReportstsb_Click);
            // 
            // backgroundpb
            // 
            this.backgroundpb.Image = global::Accounting.App.Properties.Resources.Untitled_1;
            this.backgroundpb.Location = new System.Drawing.Point(12, 261);
            this.backgroundpb.Name = "backgroundpb";
            this.backgroundpb.Size = new System.Drawing.Size(218, 211);
            this.backgroundpb.TabIndex = 1;
            this.backgroundpb.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Datetssl,
            this.Timetssl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Datetssl
            // 
            this.Datetssl.Name = "Datetssl";
            this.Datetssl.Size = new System.Drawing.Size(62, 20);
            this.Datetssl.Text = "Datetssl";
            this.Datetssl.Click += new System.EventHandler(this.Datetssl_Click);
            // 
            // Timetssl
            // 
            this.Timetssl.Name = "Timetssl";
            this.Timetssl.Size = new System.Drawing.Size(63, 20);
            this.Timetssl.Text = "Timetssl";
            // 
            // TimeTimer
            // 
            this.TimeTimer.Enabled = true;
            this.TimeTimer.Interval = 1000;
            this.TimeTimer.Tick += new System.EventHandler(this.TimeTimer_Tick);
            // 
            // Reportgb
            // 
            this.Reportgb.Controls.Add(this.RemainShowlbl);
            this.Reportgb.Controls.Add(this.PayShowlbl);
            this.Reportgb.Controls.Add(this.ReceiveShowlbl);
            this.Reportgb.Controls.Add(this.RemainReportlbl);
            this.Reportgb.Controls.Add(this.PayReportlbl);
            this.Reportgb.Controls.Add(this.ReceiveReportlbl);
            this.Reportgb.Location = new System.Drawing.Point(430, 71);
            this.Reportgb.Name = "Reportgb";
            this.Reportgb.Size = new System.Drawing.Size(340, 180);
            this.Reportgb.TabIndex = 3;
            this.Reportgb.TabStop = false;
            this.Reportgb.Text = "گزارشات این ماه:";
            // 
            // RemainShowlbl
            // 
            this.RemainShowlbl.Location = new System.Drawing.Point(6, 99);
            this.RemainShowlbl.Name = "RemainShowlbl";
            this.RemainShowlbl.Size = new System.Drawing.Size(236, 17);
            this.RemainShowlbl.TabIndex = 5;
            this.RemainShowlbl.Text = "0";
            // 
            // PayShowlbl
            // 
            this.PayShowlbl.Location = new System.Drawing.Point(6, 68);
            this.PayShowlbl.Name = "PayShowlbl";
            this.PayShowlbl.Size = new System.Drawing.Size(236, 17);
            this.PayShowlbl.TabIndex = 4;
            this.PayShowlbl.Text = "0";
            // 
            // ReceiveShowlbl
            // 
            this.ReceiveShowlbl.Location = new System.Drawing.Point(6, 34);
            this.ReceiveShowlbl.Name = "ReceiveShowlbl";
            this.ReceiveShowlbl.Size = new System.Drawing.Size(236, 17);
            this.ReceiveShowlbl.TabIndex = 3;
            this.ReceiveShowlbl.Text = "0";
            // 
            // RemainReportlbl
            // 
            this.RemainReportlbl.AutoSize = true;
            this.RemainReportlbl.Location = new System.Drawing.Point(248, 99);
            this.RemainReportlbl.Name = "RemainReportlbl";
            this.RemainReportlbl.Size = new System.Drawing.Size(86, 17);
            this.RemainReportlbl.TabIndex = 2;
            this.RemainReportlbl.Text = "مانده حساب:";
            // 
            // PayReportlbl
            // 
            this.PayReportlbl.AutoSize = true;
            this.PayReportlbl.Location = new System.Drawing.Point(248, 68);
            this.PayReportlbl.Name = "PayReportlbl";
            this.PayReportlbl.Size = new System.Drawing.Size(75, 17);
            this.PayReportlbl.TabIndex = 1;
            this.PayReportlbl.Text = "دریافتی ها:";
            // 
            // ReceiveReportlbl
            // 
            this.ReceiveReportlbl.AutoSize = true;
            this.ReceiveReportlbl.Location = new System.Drawing.Point(248, 34);
            this.ReceiveReportlbl.Name = "ReceiveReportlbl";
            this.ReceiveReportlbl.Size = new System.Drawing.Size(72, 17);
            this.ReceiveReportlbl.TabIndex = 0;
            this.ReceiveReportlbl.Text = "پرداخت ها:";
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Reportgb);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.backgroundpb);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Mainfrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامه حسابداری شخصی";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundpb)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Reportgb.ResumeLayout(false);
            this.Reportgb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Customersbtn;
        private System.Windows.Forms.ToolStripButton AddAccountingtsb;
        private System.Windows.Forms.ToolStripButton PayReportstsb;
        private System.Windows.Forms.ToolStripButton ReceiveReportstsb;
        private System.Windows.Forms.PictureBox backgroundpb;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Datetssl;
        private System.Windows.Forms.ToolStripStatusLabel Timetssl;
        private System.Windows.Forms.Timer TimeTimer;
        private System.Windows.Forms.ToolStripSplitButton Settingtsb;
        private System.Windows.Forms.ToolStripMenuItem LoginSettingbtn;
        private System.Windows.Forms.GroupBox Reportgb;
        private System.Windows.Forms.Label RemainShowlbl;
        private System.Windows.Forms.Label PayShowlbl;
        private System.Windows.Forms.Label ReceiveShowlbl;
        private System.Windows.Forms.Label RemainReportlbl;
        private System.Windows.Forms.Label PayReportlbl;
        private System.Windows.Forms.Label ReceiveReportlbl;
    }
}

