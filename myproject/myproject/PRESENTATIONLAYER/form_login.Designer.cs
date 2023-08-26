
namespace myproject.PRESENTATIONLAYER
{
    partial class form_login
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_username = new DevExpress.XtraEditors.TextEdit();
            this.txt_pass = new DevExpress.XtraEditors.TextEdit();
            this.login_buton = new DevExpress.XtraEditors.SimpleButton();
            this.cencel_buton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(70, 86);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.MaximumSize = new System.Drawing.Size(125, 125);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم المستخدم";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(70, 155);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl2.MaximumSize = new System.Drawing.Size(156, 156);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = ":كلمة المرور";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(188, 84);
            this.txt_username.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(365, 22);
            this.txt_username.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(188, 153);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(365, 22);
            this.txt_pass.TabIndex = 3;
            // 
            // login_buton
            // 
            this.login_buton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.login_buton.Appearance.Options.UseBackColor = true;
            this.login_buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_buton.Location = new System.Drawing.Point(408, 232);
            this.login_buton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.login_buton.Name = "login_buton";
            this.login_buton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.login_buton.Size = new System.Drawing.Size(108, 34);
            this.login_buton.TabIndex = 4;
            this.login_buton.Text = "الدخول";
            this.login_buton.Click += new System.EventHandler(this.login_buton_Click);
            // 
            // cencel_buton
            // 
            this.cencel_buton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cencel_buton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.cencel_buton.Appearance.Options.UseBackColor = true;
            this.cencel_buton.AppearancePressed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cencel_buton.AppearancePressed.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.cencel_buton.AppearancePressed.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cencel_buton.AppearancePressed.FontStyleDelta = System.Drawing.FontStyle.Italic;
            this.cencel_buton.AppearancePressed.Options.UseBackColor = true;
            this.cencel_buton.AppearancePressed.Options.UseBorderColor = true;
            this.cencel_buton.AppearancePressed.Options.UseFont = true;
            this.cencel_buton.AutoSize = true;
            this.cencel_buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cencel_buton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cencel_buton.Location = new System.Drawing.Point(243, 232);
            this.cencel_buton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cencel_buton.Name = "cencel_buton";
            this.cencel_buton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.cencel_buton.Size = new System.Drawing.Size(115, 33);
            this.cencel_buton.TabIndex = 5;
            this.cencel_buton.Text = "الغاء الدخول";
            this.cencel_buton.Click += new System.EventHandler(this.cencel_buton_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 280);
            this.Controls.Add(this.cencel_buton);
            this.Controls.Add(this.login_buton);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "نافذة الدخول";
            this.Load += new System.EventHandler(this.form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_username;
        private DevExpress.XtraEditors.TextEdit txt_pass;
        private DevExpress.XtraEditors.SimpleButton login_buton;
        private DevExpress.XtraEditors.SimpleButton cencel_buton;
    }
}