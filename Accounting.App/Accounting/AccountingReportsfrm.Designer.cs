
namespace Accounting.App.Accounting
{
    partial class AccountingReportsfrm
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
            this.Edittsb = new System.Windows.Forms.ToolStripButton();
            this.Deletetsb = new System.Windows.Forms.ToolStripButton();
            this.Refreshtsb = new System.Windows.Forms.ToolStripButton();
            this.Printtsb = new System.Windows.Forms.ToolStripButton();
            this.Filtergb = new System.Windows.Forms.GroupBox();
            this.Filterbtn = new System.Windows.Forms.Button();
            this.ToDatemtb = new System.Windows.Forms.MaskedTextBox();
            this.FromDatemtb = new System.Windows.Forms.MaskedTextBox();
            this.ToDatelbl = new System.Windows.Forms.Label();
            this.FromDatelbl = new System.Windows.Forms.Label();
            this.Customercb = new System.Windows.Forms.ComboBox();
            this.Customerlbl = new System.Windows.Forms.Label();
            this.Reportdgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.Filtergb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reportdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edittsb,
            this.Deletetsb,
            this.Refreshtsb,
            this.Printtsb});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(632, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Edittsb
            // 
            this.Edittsb.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.Edittsb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Edittsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edittsb.Name = "Edittsb";
            this.Edittsb.Size = new System.Drawing.Size(59, 64);
            this.Edittsb.Text = "ویرایش";
            this.Edittsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Edittsb.Click += new System.EventHandler(this.Edittsb_Click);
            // 
            // Deletetsb
            // 
            this.Deletetsb.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.Deletetsb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Deletetsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Deletetsb.Name = "Deletetsb";
            this.Deletetsb.Size = new System.Drawing.Size(45, 64);
            this.Deletetsb.Text = "حذف";
            this.Deletetsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Deletetsb.Click += new System.EventHandler(this.Deletetsb_Click);
            // 
            // Refreshtsb
            // 
            this.Refreshtsb.Image = global::Accounting.App.Properties.Resources._1371476342_Refresh;
            this.Refreshtsb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Refreshtsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refreshtsb.Name = "Refreshtsb";
            this.Refreshtsb.Size = new System.Drawing.Size(76, 64);
            this.Refreshtsb.Text = "بروزرسانی";
            this.Refreshtsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Refreshtsb.Click += new System.EventHandler(this.Refreshtsb_Click);
            // 
            // Printtsb
            // 
            this.Printtsb.Image = global::Accounting.App.Properties.Resources._1371476276_Print;
            this.Printtsb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Printtsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Printtsb.Name = "Printtsb";
            this.Printtsb.Size = new System.Drawing.Size(44, 64);
            this.Printtsb.Text = "چاپ";
            this.Printtsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Filtergb
            // 
            this.Filtergb.Controls.Add(this.Filterbtn);
            this.Filtergb.Controls.Add(this.ToDatemtb);
            this.Filtergb.Controls.Add(this.FromDatemtb);
            this.Filtergb.Controls.Add(this.ToDatelbl);
            this.Filtergb.Controls.Add(this.FromDatelbl);
            this.Filtergb.Controls.Add(this.Customercb);
            this.Filtergb.Controls.Add(this.Customerlbl);
            this.Filtergb.Location = new System.Drawing.Point(12, 71);
            this.Filtergb.Name = "Filtergb";
            this.Filtergb.Size = new System.Drawing.Size(608, 50);
            this.Filtergb.TabIndex = 1;
            this.Filtergb.TabStop = false;
            this.Filtergb.Text = "جستوجو";
            // 
            // Filterbtn
            // 
            this.Filterbtn.AutoSize = true;
            this.Filterbtn.Location = new System.Drawing.Point(6, 19);
            this.Filterbtn.Name = "Filterbtn";
            this.Filterbtn.Size = new System.Drawing.Size(75, 27);
            this.Filterbtn.TabIndex = 6;
            this.Filterbtn.Text = "انجام";
            this.Filterbtn.UseVisualStyleBackColor = true;
            this.Filterbtn.Click += new System.EventHandler(this.Filterbtn_Click);
            // 
            // ToDatemtb
            // 
            this.ToDatemtb.Location = new System.Drawing.Point(85, 19);
            this.ToDatemtb.Mask = "0000/00/00";
            this.ToDatemtb.Name = "ToDatemtb";
            this.ToDatemtb.Size = new System.Drawing.Size(73, 23);
            this.ToDatemtb.TabIndex = 5;
            this.ToDatemtb.ValidatingType = typeof(System.DateTime);
            // 
            // FromDatemtb
            // 
            this.FromDatemtb.Location = new System.Drawing.Point(222, 19);
            this.FromDatemtb.Mask = "0000/00/00";
            this.FromDatemtb.Name = "FromDatemtb";
            this.FromDatemtb.Size = new System.Drawing.Size(75, 23);
            this.FromDatemtb.TabIndex = 4;
            this.FromDatemtb.ValidatingType = typeof(System.DateTime);
            // 
            // ToDatelbl
            // 
            this.ToDatelbl.AutoSize = true;
            this.ToDatelbl.Location = new System.Drawing.Point(164, 22);
            this.ToDatelbl.Name = "ToDatelbl";
            this.ToDatelbl.Size = new System.Drawing.Size(52, 17);
            this.ToDatelbl.TabIndex = 3;
            this.ToDatelbl.Text = "تا تاریخ:";
            // 
            // FromDatelbl
            // 
            this.FromDatelbl.AutoSize = true;
            this.FromDatelbl.Location = new System.Drawing.Point(303, 19);
            this.FromDatelbl.Name = "FromDatelbl";
            this.FromDatelbl.Size = new System.Drawing.Size(52, 17);
            this.FromDatelbl.TabIndex = 2;
            this.FromDatelbl.Text = "از تاریخ:";
            // 
            // Customercb
            // 
            this.Customercb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Customercb.FormattingEnabled = true;
            this.Customercb.Location = new System.Drawing.Point(361, 19);
            this.Customercb.Name = "Customercb";
            this.Customercb.Size = new System.Drawing.Size(152, 24);
            this.Customercb.TabIndex = 1;
            this.Customercb.SelectedIndexChanged += new System.EventHandler(this.Customercb_SelectedIndexChanged);
            // 
            // Customerlbl
            // 
            this.Customerlbl.AutoSize = true;
            this.Customerlbl.Location = new System.Drawing.Point(519, 19);
            this.Customerlbl.Name = "Customerlbl";
            this.Customerlbl.Size = new System.Drawing.Size(83, 17);
            this.Customerlbl.TabIndex = 0;
            this.Customerlbl.Text = "طرف حساب:";
            // 
            // Reportdgv
            // 
            this.Reportdgv.AllowUserToAddRows = false;
            this.Reportdgv.AllowUserToDeleteRows = false;
            this.Reportdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Reportdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reportdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerID,
            this.FullName,
            this.Amount,
            this.Datetime,
            this.Description});
            this.Reportdgv.Location = new System.Drawing.Point(18, 127);
            this.Reportdgv.Name = "Reportdgv";
            this.Reportdgv.ReadOnly = true;
            this.Reportdgv.RowHeadersWidth = 51;
            this.Reportdgv.RowTemplate.Height = 24;
            this.Reportdgv.Size = new System.Drawing.Size(602, 264);
            this.Reportdgv.TabIndex = 2;
            this.Reportdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "کد تراکنش";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "کد طرف حساب";
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
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "مبلغ";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Datetime
            // 
            this.Datetime.DataPropertyName = "Datetime";
            this.Datetime.HeaderText = "تاریخ";
            this.Datetime.MinimumWidth = 6;
            this.Datetime.Name = "Datetime";
            this.Datetime.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "بابت";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // AccountingReportsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.Reportdgv);
            this.Controls.Add(this.Filtergb);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AccountingReportsfrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AccountingReports";
            this.Load += new System.EventHandler(this.AccountingReportsfrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Filtergb.ResumeLayout(false);
            this.Filtergb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reportdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Edittsb;
        private System.Windows.Forms.ToolStripButton Deletetsb;
        private System.Windows.Forms.ToolStripButton Refreshtsb;
        private System.Windows.Forms.ToolStripButton Printtsb;
        private System.Windows.Forms.GroupBox Filtergb;
        private System.Windows.Forms.MaskedTextBox ToDatemtb;
        private System.Windows.Forms.MaskedTextBox FromDatemtb;
        private System.Windows.Forms.Label ToDatelbl;
        private System.Windows.Forms.Label FromDatelbl;
        private System.Windows.Forms.ComboBox Customercb;
        private System.Windows.Forms.Label Customerlbl;
        private System.Windows.Forms.DataGridView Reportdgv;
        private System.Windows.Forms.Button Filterbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}