
namespace Accounting.App.CustomersForms
{
    partial class AddOrEditCustomerfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditCustomerfrm));
            this.CustomerInfogb = new System.Windows.Forms.GroupBox();
            this.Addresstxb = new System.Windows.Forms.TextBox();
            this.Emailtxb = new System.Windows.Forms.TextBox();
            this.Mobiletxb = new System.Windows.Forms.TextBox();
            this.FullNametxb = new System.Windows.Forms.TextBox();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Mobilelbl = new System.Windows.Forms.Label();
            this.FullNamelbl = new System.Windows.Forms.Label();
            this.CustomerImagegb = new System.Windows.Forms.GroupBox();
            this.SelectPicturebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.PcCustomerpb = new System.Windows.Forms.PictureBox();
            this.FullNameValidator = new ValidationComponents.RequiredFieldValidator(this.components);
            this.MobileValidator = new ValidationComponents.RequiredFieldValidator(this.components);
            this.CustomerInfogb.SuspendLayout();
            this.CustomerImagegb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcCustomerpb)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerInfogb
            // 
            this.CustomerInfogb.Controls.Add(this.Addresstxb);
            this.CustomerInfogb.Controls.Add(this.Emailtxb);
            this.CustomerInfogb.Controls.Add(this.Mobiletxb);
            this.CustomerInfogb.Controls.Add(this.FullNametxb);
            this.CustomerInfogb.Controls.Add(this.Addresslbl);
            this.CustomerInfogb.Controls.Add(this.Emaillbl);
            this.CustomerInfogb.Controls.Add(this.Mobilelbl);
            this.CustomerInfogb.Controls.Add(this.FullNamelbl);
            this.CustomerInfogb.Location = new System.Drawing.Point(237, 12);
            this.CustomerInfogb.Name = "CustomerInfogb";
            this.CustomerInfogb.Size = new System.Drawing.Size(313, 246);
            this.CustomerInfogb.TabIndex = 0;
            this.CustomerInfogb.TabStop = false;
            this.CustomerInfogb.Text = "اطلاعات شخص";
            // 
            // Addresstxb
            // 
            this.Addresstxb.Location = new System.Drawing.Point(6, 144);
            this.Addresstxb.Multiline = true;
            this.Addresstxb.Name = "Addresstxb";
            this.Addresstxb.Size = new System.Drawing.Size(253, 83);
            this.Addresstxb.TabIndex = 7;
            // 
            // Emailtxb
            // 
            this.Emailtxb.Location = new System.Drawing.Point(6, 108);
            this.Emailtxb.Name = "Emailtxb";
            this.Emailtxb.Size = new System.Drawing.Size(253, 23);
            this.Emailtxb.TabIndex = 6;
            // 
            // Mobiletxb
            // 
            this.Mobiletxb.Location = new System.Drawing.Point(6, 72);
            this.Mobiletxb.Name = "Mobiletxb";
            this.Mobiletxb.Size = new System.Drawing.Size(253, 23);
            this.Mobiletxb.TabIndex = 5;
            // 
            // FullNametxb
            // 
            this.FullNametxb.Location = new System.Drawing.Point(6, 35);
            this.FullNametxb.Name = "FullNametxb";
            this.FullNametxb.Size = new System.Drawing.Size(179, 23);
            this.FullNametxb.TabIndex = 4;
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Addresslbl.Location = new System.Drawing.Point(265, 144);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(40, 21);
            this.Addresslbl.TabIndex = 3;
            this.Addresslbl.Text = "آدرس:";
            this.Addresslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Addresslbl.UseCompatibleTextRendering = true;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Location = new System.Drawing.Point(265, 108);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(44, 17);
            this.Emaillbl.TabIndex = 2;
            this.Emaillbl.Text = "ایمیل:";
            // 
            // Mobilelbl
            // 
            this.Mobilelbl.AutoSize = true;
            this.Mobilelbl.Location = new System.Drawing.Point(265, 72);
            this.Mobilelbl.Name = "Mobilelbl";
            this.Mobilelbl.Size = new System.Drawing.Size(48, 17);
            this.Mobilelbl.TabIndex = 1;
            this.Mobilelbl.Text = "موبایل:";
            // 
            // FullNamelbl
            // 
            this.FullNamelbl.AutoSize = true;
            this.FullNamelbl.Location = new System.Drawing.Point(191, 35);
            this.FullNamelbl.Name = "FullNamelbl";
            this.FullNamelbl.Size = new System.Drawing.Size(117, 17);
            this.FullNamelbl.TabIndex = 0;
            this.FullNamelbl.Text = "نام و نام خانوادگی:";
            this.FullNamelbl.Click += new System.EventHandler(this.FullNamelbl_Click);
            // 
            // CustomerImagegb
            // 
            this.CustomerImagegb.Controls.Add(this.SelectPicturebtn);
            this.CustomerImagegb.Controls.Add(this.PcCustomerpb);
            this.CustomerImagegb.Location = new System.Drawing.Point(12, 12);
            this.CustomerImagegb.Name = "CustomerImagegb";
            this.CustomerImagegb.Size = new System.Drawing.Size(219, 246);
            this.CustomerImagegb.TabIndex = 1;
            this.CustomerImagegb.TabStop = false;
            this.CustomerImagegb.Text = "تصویر شخص";
            // 
            // SelectPicturebtn
            // 
            this.SelectPicturebtn.AutoSize = true;
            this.SelectPicturebtn.Location = new System.Drawing.Point(6, 215);
            this.SelectPicturebtn.Name = "SelectPicturebtn";
            this.SelectPicturebtn.Size = new System.Drawing.Size(206, 27);
            this.SelectPicturebtn.TabIndex = 1;
            this.SelectPicturebtn.Text = "انتخاب تصویر";
            this.SelectPicturebtn.UseVisualStyleBackColor = true;
            this.SelectPicturebtn.Click += new System.EventHandler(this.SelectPicturebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.AutoSize = true;
            this.Savebtn.Location = new System.Drawing.Point(428, 265);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(118, 27);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "افزودن شخص";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // PcCustomerpb
            // 
            this.PcCustomerpb.Image = global::Accounting.App.Properties.Resources.images;
            this.PcCustomerpb.Location = new System.Drawing.Point(6, 22);
            this.PcCustomerpb.Name = "PcCustomerpb";
            this.PcCustomerpb.Size = new System.Drawing.Size(207, 186);
            this.PcCustomerpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcCustomerpb.TabIndex = 0;
            this.PcCustomerpb.TabStop = false;
            // 
            // FullNameValidator
            // 
            this.FullNameValidator.CancelFocusChangeWhenInvalid = false;
            this.FullNameValidator.ControlToValidate = this.FullNametxb;
            this.FullNameValidator.ErrorMessage = "لطفا نام را وارد کنید!";
            this.FullNameValidator.Icon = ((System.Drawing.Icon)(resources.GetObject("FullNameValidator.Icon")));
            // 
            // MobileValidator
            // 
            this.MobileValidator.CancelFocusChangeWhenInvalid = false;
            this.MobileValidator.ControlToValidate = this.Mobiletxb;
            this.MobileValidator.ErrorMessage = "لطفا شماره موبایل را وارد کنید!";
            this.MobileValidator.Icon = ((System.Drawing.Icon)(resources.GetObject("MobileValidator.Icon")));
            // 
            // AddOrEditCustomerfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 303);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.CustomerImagegb);
            this.Controls.Add(this.CustomerInfogb);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddOrEditCustomerfrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن شخص جدید";
            this.Load += new System.EventHandler(this.AddOrEditCustomerfrm_Load);
            this.CustomerInfogb.ResumeLayout(false);
            this.CustomerInfogb.PerformLayout();
            this.CustomerImagegb.ResumeLayout(false);
            this.CustomerImagegb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcCustomerpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomerInfogb;
        private System.Windows.Forms.TextBox Addresstxb;
        private System.Windows.Forms.TextBox Emailtxb;
        private System.Windows.Forms.TextBox Mobiletxb;
        private System.Windows.Forms.TextBox FullNametxb;
        private System.Windows.Forms.Label Addresslbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label Mobilelbl;
        private System.Windows.Forms.Label FullNamelbl;
        private System.Windows.Forms.GroupBox CustomerImagegb;
        private System.Windows.Forms.Button SelectPicturebtn;
        private System.Windows.Forms.PictureBox PcCustomerpb;
        private System.Windows.Forms.Button Savebtn;
        private ValidationComponents.RequiredFieldValidator FullNameValidator;
        private ValidationComponents.RequiredFieldValidator MobileValidator;
    }
}