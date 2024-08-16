
namespace Accounting.App.CustomersForms
{
    partial class Accountingfrm
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
            this.Customersgb = new System.Windows.Forms.GroupBox();
            this.Customersdgv = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customersgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customersdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Customersgb
            // 
            this.Customersgb.Controls.Add(this.Customersdgv);
            this.Customersgb.Location = new System.Drawing.Point(12, 12);
            this.Customersgb.Name = "Customersgb";
            this.Customersgb.Size = new System.Drawing.Size(200, 329);
            this.Customersgb.TabIndex = 0;
            this.Customersgb.TabStop = false;
            this.Customersgb.Text = "اشخاص";
            // 
            // Customersdgv
            // 
            this.Customersdgv.AllowUserToAddRows = false;
            this.Customersdgv.AllowUserToDeleteRows = false;
            this.Customersdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customersdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FullName});
            this.Customersdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customersdgv.Location = new System.Drawing.Point(3, 19);
            this.Customersdgv.Name = "Customersdgv";
            this.Customersdgv.ReadOnly = true;
            this.Customersdgv.RowHeadersWidth = 51;
            this.Customersdgv.RowTemplate.Height = 24;
            this.Customersdgv.Size = new System.Drawing.Size(194, 307);
            this.Customersdgv.TabIndex = 0;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "کد شخص";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            this.CustomerID.Width = 125;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 125;
            // 
            // Accountingfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 353);
            this.Controls.Add(this.Customersgb);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Accountingfrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.Accountingfrm_Load);
            this.Customersgb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Customersdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Customersgb;
        private System.Windows.Forms.DataGridView Customersdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
    }
}