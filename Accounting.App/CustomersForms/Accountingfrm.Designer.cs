
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accountingfrm));
            this.Customersgb = new System.Windows.Forms.GroupBox();
            this.Customersdgv = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchCustomerlbl = new System.Windows.Forms.Label();
            this.SearchCustomertxb = new System.Windows.Forms.TextBox();
            this.CustomerFullNamelbl = new System.Windows.Forms.Label();
            this.CustomerFullNametxb = new System.Windows.Forms.TextBox();
            this.AmountRange = new ValidationComponents.RangeValidator(this.components);
            this.FullNamevalid = new ValidationComponents.RequiredFieldValidator(this.components);
            this.AccountingTypelbl = new System.Windows.Forms.Label();
            this.Amountlbl = new System.Windows.Forms.Label();
            this.Descriptionlbl = new System.Windows.Forms.Label();
            this.Receiveradio = new System.Windows.Forms.RadioButton();
            this.Payradio = new System.Windows.Forms.RadioButton();
            this.Amountnud = new System.Windows.Forms.NumericUpDown();
            this.Descriptiontxb = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Customersgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customersdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amountnud)).BeginInit();
            this.SuspendLayout();
            // 
            // Customersgb
            // 
            this.Customersgb.Controls.Add(this.SearchCustomertxb);
            this.Customersgb.Controls.Add(this.SearchCustomerlbl);
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
            this.Customersdgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Customersdgv.Location = new System.Drawing.Point(3, 53);
            this.Customersdgv.Name = "Customersdgv";
            this.Customersdgv.ReadOnly = true;
            this.Customersdgv.RowHeadersWidth = 51;
            this.Customersdgv.RowTemplate.Height = 24;
            this.Customersdgv.Size = new System.Drawing.Size(194, 273);
            this.Customersdgv.TabIndex = 0;
            this.Customersdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Customersdgv_CellClick);
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
            this.FullName.Width = 141;
            // 
            // SearchCustomerlbl
            // 
            this.SearchCustomerlbl.AutoSize = true;
            this.SearchCustomerlbl.Location = new System.Drawing.Point(136, 23);
            this.SearchCustomerlbl.Name = "SearchCustomerlbl";
            this.SearchCustomerlbl.Size = new System.Drawing.Size(58, 17);
            this.SearchCustomerlbl.TabIndex = 1;
            this.SearchCustomerlbl.Text = "جستوجو";
            // 
            // SearchCustomertxb
            // 
            this.SearchCustomertxb.Location = new System.Drawing.Point(6, 23);
            this.SearchCustomertxb.Name = "SearchCustomertxb";
            this.SearchCustomertxb.Size = new System.Drawing.Size(124, 23);
            this.SearchCustomertxb.TabIndex = 2;
            this.SearchCustomertxb.TextChanged += new System.EventHandler(this.SearchCustomertxb_TextChanged);
            // 
            // CustomerFullNamelbl
            // 
            this.CustomerFullNamelbl.AutoSize = true;
            this.CustomerFullNamelbl.Location = new System.Drawing.Point(311, 9);
            this.CustomerFullNamelbl.Name = "CustomerFullNamelbl";
            this.CustomerFullNamelbl.Size = new System.Drawing.Size(191, 17);
            this.CustomerFullNamelbl.TabIndex = 1;
            this.CustomerFullNamelbl.Text = "نام و نام خانوادگی طرف حساب:";
            this.CustomerFullNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerFullNametxb
            // 
            this.CustomerFullNametxb.Location = new System.Drawing.Point(218, 35);
            this.CustomerFullNametxb.Name = "CustomerFullNametxb";
            this.CustomerFullNametxb.ReadOnly = true;
            this.CustomerFullNametxb.Size = new System.Drawing.Size(260, 23);
            this.CustomerFullNametxb.TabIndex = 2;
            // 
            // AmountRange
            // 
            this.AmountRange.CancelFocusChangeWhenInvalid = false;
            this.AmountRange.ControlToValidate = this.Amountnud;
            this.AmountRange.ErrorMessage = "لطفا مبلغی را بین ۱ تا ۹۹۹۹۹ وارد کنید.";
            this.AmountRange.Icon = ((System.Drawing.Icon)(resources.GetObject("AmountRange.Icon")));
            this.AmountRange.MaximumValue = "99999";
            this.AmountRange.MinimumValue = "1";
            this.AmountRange.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // FullNamevalid
            // 
            this.FullNamevalid.CancelFocusChangeWhenInvalid = false;
            this.FullNamevalid.ControlToValidate = this.CustomerFullNametxb;
            this.FullNamevalid.ErrorMessage = "لطفا شخصی را از لیست اشخاص انتخاب کنید!";
            this.FullNamevalid.Icon = ((System.Drawing.Icon)(resources.GetObject("FullNamevalid.Icon")));
            // 
            // AccountingTypelbl
            // 
            this.AccountingTypelbl.AutoSize = true;
            this.AccountingTypelbl.Location = new System.Drawing.Point(424, 79);
            this.AccountingTypelbl.Name = "AccountingTypelbl";
            this.AccountingTypelbl.Size = new System.Drawing.Size(78, 17);
            this.AccountingTypelbl.TabIndex = 3;
            this.AccountingTypelbl.Text = "نوع تراکنش:";
            // 
            // Amountlbl
            // 
            this.Amountlbl.AutoSize = true;
            this.Amountlbl.Location = new System.Drawing.Point(417, 122);
            this.Amountlbl.Name = "Amountlbl";
            this.Amountlbl.Size = new System.Drawing.Size(85, 17);
            this.Amountlbl.TabIndex = 4;
            this.Amountlbl.Text = "مبلغ تراکنش:";
            // 
            // Descriptionlbl
            // 
            this.Descriptionlbl.AutoSize = true;
            this.Descriptionlbl.Location = new System.Drawing.Point(433, 167);
            this.Descriptionlbl.Name = "Descriptionlbl";
            this.Descriptionlbl.Size = new System.Drawing.Size(64, 17);
            this.Descriptionlbl.TabIndex = 5;
            this.Descriptionlbl.Text = "توضیحات:";
            // 
            // Receiveradio
            // 
            this.Receiveradio.AutoSize = true;
            this.Receiveradio.Location = new System.Drawing.Point(350, 77);
            this.Receiveradio.Name = "Receiveradio";
            this.Receiveradio.Size = new System.Drawing.Size(68, 21);
            this.Receiveradio.TabIndex = 6;
            this.Receiveradio.TabStop = true;
            this.Receiveradio.Text = "دریافت";
            this.Receiveradio.UseVisualStyleBackColor = true;
            // 
            // Payradio
            // 
            this.Payradio.AutoSize = true;
            this.Payradio.Location = new System.Drawing.Point(273, 79);
            this.Payradio.Name = "Payradio";
            this.Payradio.Size = new System.Drawing.Size(71, 21);
            this.Payradio.TabIndex = 7;
            this.Payradio.TabStop = true;
            this.Payradio.Text = "پرداخت";
            this.Payradio.UseVisualStyleBackColor = true;
            // 
            // Amountnud
            // 
            this.Amountnud.Location = new System.Drawing.Point(218, 122);
            this.Amountnud.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Amountnud.Name = "Amountnud";
            this.Amountnud.Size = new System.Drawing.Size(193, 23);
            this.Amountnud.TabIndex = 8;
            this.Amountnud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amountnud.ValueChanged += new System.EventHandler(this.Amountnud_ValueChanged);
            // 
            // Descriptiontxb
            // 
            this.Descriptiontxb.Location = new System.Drawing.Point(218, 167);
            this.Descriptiontxb.Multiline = true;
            this.Descriptiontxb.Name = "Descriptiontxb";
            this.Descriptiontxb.Size = new System.Drawing.Size(209, 141);
            this.Descriptiontxb.TabIndex = 9;
            // 
            // Savebtn
            // 
            this.Savebtn.AutoSize = true;
            this.Savebtn.Location = new System.Drawing.Point(219, 314);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 27);
            this.Savebtn.TabIndex = 10;
            this.Savebtn.Text = "ثبت";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Accountingfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 353);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Descriptiontxb);
            this.Controls.Add(this.Amountnud);
            this.Controls.Add(this.Payradio);
            this.Controls.Add(this.Receiveradio);
            this.Controls.Add(this.Descriptionlbl);
            this.Controls.Add(this.Amountlbl);
            this.Controls.Add(this.AccountingTypelbl);
            this.Controls.Add(this.CustomerFullNametxb);
            this.Controls.Add(this.CustomerFullNamelbl);
            this.Controls.Add(this.Customersgb);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Accountingfrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.Accountingfrm_Load);
            this.Customersgb.ResumeLayout(false);
            this.Customersgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customersdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amountnud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Customersgb;
        private System.Windows.Forms.DataGridView Customersdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.TextBox SearchCustomertxb;
        private System.Windows.Forms.Label SearchCustomerlbl;
        private System.Windows.Forms.Label CustomerFullNamelbl;
        private System.Windows.Forms.TextBox CustomerFullNametxb;
        private ValidationComponents.RangeValidator AmountRange;
        private ValidationComponents.RequiredFieldValidator FullNamevalid;
        private System.Windows.Forms.Label AccountingTypelbl;
        private System.Windows.Forms.Label Amountlbl;
        private System.Windows.Forms.Label Descriptionlbl;
        private System.Windows.Forms.RadioButton Receiveradio;
        private System.Windows.Forms.RadioButton Payradio;
        private System.Windows.Forms.NumericUpDown Amountnud;
        private System.Windows.Forms.TextBox Descriptiontxb;
        private System.Windows.Forms.Button Savebtn;
    }
}