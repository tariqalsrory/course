
namespace myproject.PRESENTATIONLAYER
{
    partial class Form_add_product
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_product_items = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_number_product = new DevExpress.XtraEditors.TextEdit();
            this.txt_name_product = new DevExpress.XtraEditors.TextEdit();
            this.txt_qty_prouct = new DevExpress.XtraEditors.TextEdit();
            this.txt_price_product = new DevExpress.XtraEditors.TextEdit();
            this.addproduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_product_items.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_number_product.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name_product.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty_prouct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price_product.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.addproduct);
            this.groupControl1.Controls.Add(this.txt_price_product);
            this.groupControl1.Controls.Add(this.txt_qty_prouct);
            this.groupControl1.Controls.Add(this.txt_name_product);
            this.groupControl1.Controls.Add(this.txt_number_product);
            this.groupControl1.Controls.Add(this.txt_product_items);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(13, 13);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(487, 424);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات المنتج";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "صنف المنتج";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "رقم المنتج";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم المنتج";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = " الكمية";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "سعر المنتج";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_product_items
            // 
            this.txt_product_items.Location = new System.Drawing.Point(59, 62);
            this.txt_product_items.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_product_items.Name = "txt_product_items";
            this.txt_product_items.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_product_items.Size = new System.Drawing.Size(269, 22);
            this.txt_product_items.TabIndex = 5;
            // 
            // txt_number_product
            // 
            this.txt_number_product.Location = new System.Drawing.Point(59, 113);
            this.txt_number_product.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_number_product.Name = "txt_number_product";
            this.txt_number_product.Size = new System.Drawing.Size(269, 22);
            this.txt_number_product.TabIndex = 6;
            // 
            // txt_name_product
            // 
            this.txt_name_product.Location = new System.Drawing.Point(59, 164);
            this.txt_name_product.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_name_product.Name = "txt_name_product";
            this.txt_name_product.Size = new System.Drawing.Size(269, 22);
            this.txt_name_product.TabIndex = 7;
            // 
            // txt_qty_prouct
            // 
            this.txt_qty_prouct.Location = new System.Drawing.Point(59, 215);
            this.txt_qty_prouct.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_qty_prouct.Name = "txt_qty_prouct";
            this.txt_qty_prouct.Size = new System.Drawing.Size(269, 22);
            this.txt_qty_prouct.TabIndex = 8;
            // 
            // txt_price_product
            // 
            this.txt_price_product.Location = new System.Drawing.Point(59, 274);
            this.txt_price_product.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_price_product.Name = "txt_price_product";
            this.txt_price_product.Size = new System.Drawing.Size(269, 22);
            this.txt_price_product.TabIndex = 9;
            // 
            // addproduct
            // 
            this.addproduct.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addproduct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addproduct.Location = new System.Drawing.Point(184, 335);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(75, 23);
            this.addproduct.TabIndex = 10;
            this.addproduct.Text = "اضافة";
            this.addproduct.UseVisualStyleBackColor = false;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // Form_add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.groupControl1);
            this.Name = "Form_add_product";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة منتج جديد";
            this.Load += new System.EventHandler(this.Form_add_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_product_items.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_number_product.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name_product.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty_prouct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price_product.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_price_product;
        private DevExpress.XtraEditors.TextEdit txt_qty_prouct;
        private DevExpress.XtraEditors.TextEdit txt_name_product;
        private DevExpress.XtraEditors.TextEdit txt_number_product;
        private DevExpress.XtraEditors.ComboBoxEdit txt_product_items;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addproduct;
    }
}