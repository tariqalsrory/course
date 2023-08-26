using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myproject.PRESENTATIONLAYER
{
    public partial class MAIN : Form
    {
        private static MAIN frm;
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static MAIN myform
        {
            get
            {
                if (frm == null)
                {
                    frm = new MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
               
                    return frm;
               
            }
            
            
        }
        public MAIN()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.sales.Enabled = false;
            this.customers.Enabled = false;
            this.items.Enabled = false;
            this.users.Enabled = false;
            this.products.Enabled = false;
        }

        private void MAIN_Load(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            form_login f = new form_login();
            f.ShowDialog();
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void users_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.sales.Enabled = false;
            this.customers.Enabled = false;
            this.items.Enabled = false;
            this.users.Enabled = false;
            this.products.Enabled = false;
        }
    }
}
