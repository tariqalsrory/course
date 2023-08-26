
namespace myproject.PRESENTATIONLAYER
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.files = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.login1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.logout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.products = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.addnewproducts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.manageproducts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.items = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.add_new_items = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.manage_items = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.customers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.add_new_customer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.manage_customers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.sales = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.add_new_sales = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.manage_thesales = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator5 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.users = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.add_new_user = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.manage_users = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator6 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.files,
            this.accordionControlSeparator3,
            this.products,
            this.accordionControlSeparator1,
            this.items,
            this.accordionControlSeparator2,
            this.customers,
            this.accordionControlSeparator4,
            this.sales,
            this.accordionControlSeparator5,
            this.users,
            this.accordionControlSeparator6});
            this.accordionControl1.Location = new System.Drawing.Point(1, 5);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(271, 472);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // files
            // 
            this.files.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.login1,
            this.logout});
            this.files.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.files.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("files.ImageOptions.SvgImage")));
            this.files.Name = "files";
            this.files.Text = "ملف";
            this.files.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // login1
            // 
            this.login1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.login1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("login1.ImageOptions.SvgImage")));
            this.login1.Name = "login1";
            this.login1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.login1.Text = "تسجيل الدخول";
            this.login1.Click += new System.EventHandler(this.accordionControlElement2_Click);
            // 
            // logout
            // 
            this.logout.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.logout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("logout.ImageOptions.SvgImage")));
            this.logout.Name = "logout";
            this.logout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.logout.Text = "تسجيل الخروج";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // products
            // 
            this.products.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.addnewproducts,
            this.manageproducts});
            this.products.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.products.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("products.ImageOptions.SvgImage")));
            this.products.Name = "products";
            this.products.Text = "المنتجات";
            // 
            // addnewproducts
            // 
            this.addnewproducts.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.addnewproducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("addnewproducts.ImageOptions.SvgImage")));
            this.addnewproducts.Name = "addnewproducts";
            this.addnewproducts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.addnewproducts.Text = "اضافة منتج جديد";
            // 
            // manageproducts
            // 
            this.manageproducts.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.manageproducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("manageproducts.ImageOptions.SvgImage")));
            this.manageproducts.Name = "manageproducts";
            this.manageproducts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.manageproducts.Text = "ادارة المنتجات";
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // items
            // 
            this.items.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.add_new_items,
            this.manage_items});
            this.items.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.items.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("items.ImageOptions.SvgImage")));
            this.items.Name = "items";
            this.items.Text = "الاصناف";
            // 
            // add_new_items
            // 
            this.add_new_items.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.add_new_items.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("add_new_items.ImageOptions.SvgImage")));
            this.add_new_items.Name = "add_new_items";
            this.add_new_items.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.add_new_items.Text = "اضافة صنف جديد";
            // 
            // manage_items
            // 
            this.manage_items.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.manage_items.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("manage_items.ImageOptions.Image")));
            this.manage_items.Name = "manage_items";
            this.manage_items.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.manage_items.Text = "ادارة الاصناف";
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // customers
            // 
            this.customers.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.add_new_customer,
            this.manage_customers});
            this.customers.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.customers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("customers.ImageOptions.Image")));
            this.customers.Name = "customers";
            this.customers.Text = "العملاء";
            // 
            // add_new_customer
            // 
            this.add_new_customer.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.add_new_customer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("add_new_customer.ImageOptions.Image")));
            this.add_new_customer.Name = "add_new_customer";
            this.add_new_customer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.add_new_customer.Text = "اضافة عميل جديد";
            // 
            // manage_customers
            // 
            this.manage_customers.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.manage_customers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("manage_customers.ImageOptions.Image")));
            this.manage_customers.Name = "manage_customers";
            this.manage_customers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.manage_customers.Text = "ادارة العملاء";
            // 
            // accordionControlSeparator4
            // 
            this.accordionControlSeparator4.Name = "accordionControlSeparator4";
            // 
            // sales
            // 
            this.sales.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.add_new_sales,
            this.manage_thesales});
            this.sales.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.sales.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sales.ImageOptions.SvgImage")));
            this.sales.Name = "sales";
            this.sales.Text = "المبيعات";
            this.sales.Click += new System.EventHandler(this.accordionControlElement13_Click);
            // 
            // add_new_sales
            // 
            this.add_new_sales.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.add_new_sales.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("add_new_sales.ImageOptions.SvgImage")));
            this.add_new_sales.Name = "add_new_sales";
            this.add_new_sales.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.add_new_sales.Text = "اضافة بيع جديد";
            // 
            // manage_thesales
            // 
            this.manage_thesales.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.manage_thesales.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("manage_thesales.ImageOptions.SvgImage")));
            this.manage_thesales.Name = "manage_thesales";
            this.manage_thesales.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.manage_thesales.Text = "ادارة المبيعات";
            // 
            // accordionControlSeparator5
            // 
            this.accordionControlSeparator5.Name = "accordionControlSeparator5";
            // 
            // users
            // 
            this.users.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.add_new_user,
            this.manage_users});
            this.users.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.users.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("users.ImageOptions.SvgImage")));
            this.users.Name = "users";
            this.users.Text = "المستخمين";
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // add_new_user
            // 
            this.add_new_user.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.add_new_user.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("add_new_user.ImageOptions.SvgImage")));
            this.add_new_user.Name = "add_new_user";
            this.add_new_user.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.add_new_user.Text = "اضافة مستخدم جديد";
            // 
            // manage_users
            // 
            this.manage_users.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.manage_users.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("manage_users.ImageOptions.SvgImage")));
            this.manage_users.Name = "manage_users";
            this.manage_users.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.manage_users.Text = "ادارة المستخدمين";
            // 
            // accordionControlSeparator6
            // 
            this.accordionControlSeparator6.Name = "accordionControlSeparator6";
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.accordionControl1);
            this.IsMdiContainer = true;
            this.Name = "MAIN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "النافذة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MAIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator6;
        public DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        public DevExpress.XtraBars.Navigation.AccordionControlElement files;
        public DevExpress.XtraBars.Navigation.AccordionControlElement login1;
        public DevExpress.XtraBars.Navigation.AccordionControlElement logout;
        public DevExpress.XtraBars.Navigation.AccordionControlElement products;
        public DevExpress.XtraBars.Navigation.AccordionControlElement addnewproducts;
        public DevExpress.XtraBars.Navigation.AccordionControlElement manageproducts;
        public DevExpress.XtraBars.Navigation.AccordionControlElement items;
        public DevExpress.XtraBars.Navigation.AccordionControlElement add_new_items;
        public DevExpress.XtraBars.Navigation.AccordionControlElement manage_items;
        public DevExpress.XtraBars.Navigation.AccordionControlElement customers;
        public DevExpress.XtraBars.Navigation.AccordionControlElement add_new_customer;
        public DevExpress.XtraBars.Navigation.AccordionControlElement manage_customers;
        public DevExpress.XtraBars.Navigation.AccordionControlElement sales;
        public DevExpress.XtraBars.Navigation.AccordionControlElement add_new_sales;
        public DevExpress.XtraBars.Navigation.AccordionControlElement manage_thesales;
        public DevExpress.XtraBars.Navigation.AccordionControlElement users;
        public DevExpress.XtraBars.Navigation.AccordionControlElement add_new_user;
        public DevExpress.XtraBars.Navigation.AccordionControlElement manage_users;
    }
}