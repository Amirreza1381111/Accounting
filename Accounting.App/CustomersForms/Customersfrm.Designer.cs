
namespace Accounting.App
{
    partial class Customersfrm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddCustomertsb = new System.Windows.Forms.ToolStripButton();
            this.EditCustomertsb = new System.Windows.Forms.ToolStripButton();
            this.DeleteCustomertsb = new System.Windows.Forms.ToolStripButton();
            this.RefrshCustomerstsb = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.SearchCustomertstb = new System.Windows.Forms.ToolStripTextBox();
            this.Customersdgv = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customersdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCustomertsb,
            this.EditCustomertsb,
            this.DeleteCustomertsb,
            this.RefrshCustomerstsb,
            this.toolStripLabel1,
            this.SearchCustomertstb});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(582, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddCustomertsb
            // 
            this.AddCustomertsb.Image = global::Accounting.App.Properties.Resources._1371475930_filenew;
            this.AddCustomertsb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddCustomertsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddCustomertsb.Name = "AddCustomertsb";
            this.AddCustomertsb.Size = new System.Drawing.Size(102, 64);
            this.AddCustomertsb.Text = "افزودن شخص";
            this.AddCustomertsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddCustomertsb.Click += new System.EventHandler(this.AddCustomertsb_Click);
            // 
            // EditCustomertsb
            // 
            this.EditCustomertsb.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.EditCustomertsb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditCustomertsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditCustomertsb.Name = "EditCustomertsb";
            this.EditCustomertsb.Size = new System.Drawing.Size(105, 64);
            this.EditCustomertsb.Text = "ویرایش شخص";
            this.EditCustomertsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditCustomertsb.Click += new System.EventHandler(this.EditCustomertsb_Click);
            // 
            // DeleteCustomertsb
            // 
            this.DeleteCustomertsb.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.DeleteCustomertsb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteCustomertsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCustomertsb.Name = "DeleteCustomertsb";
            this.DeleteCustomertsb.Size = new System.Drawing.Size(91, 64);
            this.DeleteCustomertsb.Text = "حذف شخص";
            this.DeleteCustomertsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteCustomertsb.Click += new System.EventHandler(this.DeleteCustomertsb_Click);
            // 
            // RefrshCustomerstsb
            // 
            this.RefrshCustomerstsb.Image = global::Accounting.App.Properties.Resources._1371476368_Synchronize;
            this.RefrshCustomerstsb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefrshCustomerstsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefrshCustomerstsb.Name = "RefrshCustomerstsb";
            this.RefrshCustomerstsb.Size = new System.Drawing.Size(76, 64);
            this.RefrshCustomerstsb.Text = "بروزرسانی";
            this.RefrshCustomerstsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefrshCustomerstsb.Click += new System.EventHandler(this.RefrshCustomerstsb_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(61, 64);
            this.toolStripLabel1.Text = "جستوجو";
            // 
            // SearchCustomertstb
            // 
            this.SearchCustomertstb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchCustomertstb.Name = "SearchCustomertstb";
            this.SearchCustomertstb.Size = new System.Drawing.Size(100, 67);
            this.SearchCustomertstb.Click += new System.EventHandler(this.SearchCustomertstb_Click);
            this.SearchCustomertstb.TextChanged += new System.EventHandler(this.SearchCustomertstb_TextChanged);
            // 
            // Customersdgv
            // 
            this.Customersdgv.AllowUserToAddRows = false;
            this.Customersdgv.AllowUserToDeleteRows = false;
            this.Customersdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Customersdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customersdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FullName,
            this.Mobile,
            this.Email,
            this.Address,
            this.CustomerImage});
            this.Customersdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customersdgv.Location = new System.Drawing.Point(0, 67);
            this.Customersdgv.Name = "Customersdgv";
            this.Customersdgv.ReadOnly = true;
            this.Customersdgv.RowHeadersWidth = 51;
            this.Customersdgv.RowTemplate.Height = 24;
            this.Customersdgv.Size = new System.Drawing.Size(582, 336);
            this.Customersdgv.TabIndex = 1;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "آیدی شخص";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "شماره تماس";
            this.Mobile.MinimumWidth = 6;
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "آدرس";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Visible = false;
            // 
            // CustomerImage
            // 
            this.CustomerImage.DataPropertyName = "CustomerImage";
            this.CustomerImage.HeaderText = "تصویر شخص";
            this.CustomerImage.MinimumWidth = 6;
            this.CustomerImage.Name = "CustomerImage";
            this.CustomerImage.ReadOnly = true;
            this.CustomerImage.Visible = false;
            // 
            // Customersfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.Customersdgv);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Customersfrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت اشخاص";
            this.Load += new System.EventHandler(this.Customersfrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customersdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddCustomertsb;
        private System.Windows.Forms.ToolStripButton EditCustomertsb;
        private System.Windows.Forms.ToolStripButton DeleteCustomertsb;
        private System.Windows.Forms.ToolStripButton RefrshCustomerstsb;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView Customersdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerImage;
        private System.Windows.Forms.ToolStripTextBox SearchCustomertstb;
    }
}