
namespace Accounting.App.Login
{
    partial class Loginfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginfrm));
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.Loggb = new System.Windows.Forms.GroupBox();
            this.Usernametxb = new System.Windows.Forms.TextBox();
            this.Passwordtxb = new System.Windows.Forms.TextBox();
            this.Logbtn = new System.Windows.Forms.Button();
            this.UserNameValidator = new ValidationComponents.RequiredFieldValidator(this.components);
            this.Passwordvalidator = new ValidationComponents.RequiredFieldValidator(this.components);
            this.Loggb.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.AutoSize = true;
            this.UserNamelbl.Location = new System.Drawing.Point(273, 19);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(71, 17);
            this.UserNamelbl.TabIndex = 0;
            this.UserNamelbl.Text = "نام کاربری:";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Location = new System.Drawing.Point(285, 62);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(59, 17);
            this.Passwordlbl.TabIndex = 1;
            this.Passwordlbl.Text = "رمز ورود:";
            // 
            // Loggb
            // 
            this.Loggb.Controls.Add(this.Logbtn);
            this.Loggb.Controls.Add(this.Passwordtxb);
            this.Loggb.Controls.Add(this.Usernametxb);
            this.Loggb.Controls.Add(this.UserNamelbl);
            this.Loggb.Controls.Add(this.Passwordlbl);
            this.Loggb.Location = new System.Drawing.Point(12, 10);
            this.Loggb.Name = "Loggb";
            this.Loggb.Size = new System.Drawing.Size(350, 140);
            this.Loggb.TabIndex = 2;
            this.Loggb.TabStop = false;
            // 
            // Usernametxb
            // 
            this.Usernametxb.Location = new System.Drawing.Point(6, 19);
            this.Usernametxb.Name = "Usernametxb";
            this.Usernametxb.Size = new System.Drawing.Size(261, 23);
            this.Usernametxb.TabIndex = 2;
            // 
            // Passwordtxb
            // 
            this.Passwordtxb.Location = new System.Drawing.Point(18, 62);
            this.Passwordtxb.Name = "Passwordtxb";
            this.Passwordtxb.Size = new System.Drawing.Size(261, 23);
            this.Passwordtxb.TabIndex = 3;
            // 
            // Logbtn
            // 
            this.Logbtn.AutoSize = true;
            this.Logbtn.Location = new System.Drawing.Point(265, 102);
            this.Logbtn.Name = "Logbtn";
            this.Logbtn.Size = new System.Drawing.Size(75, 27);
            this.Logbtn.TabIndex = 4;
            this.Logbtn.Text = "ورود";
            this.Logbtn.UseVisualStyleBackColor = true;
            // 
            // UserNameValidator
            // 
            this.UserNameValidator.CancelFocusChangeWhenInvalid = false;
            this.UserNameValidator.ControlToValidate = this.Usernametxb;
            this.UserNameValidator.ErrorMessage = "لطفا نام کاربری را وارد کنید!";
            this.UserNameValidator.Icon = ((System.Drawing.Icon)(resources.GetObject("UserNameValidator.Icon")));
            // 
            // Passwordvalidator
            // 
            this.Passwordvalidator.CancelFocusChangeWhenInvalid = false;
            this.Passwordvalidator.ControlToValidate = this.Passwordtxb;
            this.Passwordvalidator.ErrorMessage = "لطفا رمز ورود را وارد کنید!";
            this.Passwordvalidator.Icon = ((System.Drawing.Icon)(resources.GetObject("Passwordvalidator.Icon")));
            // 
            // Loginfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 155);
            this.Controls.Add(this.Loggb);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Loginfrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Loginfrm_Load);
            this.Loggb.ResumeLayout(false);
            this.Loggb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.GroupBox Loggb;
        private System.Windows.Forms.Button Logbtn;
        private System.Windows.Forms.TextBox Passwordtxb;
        private System.Windows.Forms.TextBox Usernametxb;
        private ValidationComponents.RequiredFieldValidator UserNameValidator;
        private ValidationComponents.RequiredFieldValidator Passwordvalidator;
    }
}