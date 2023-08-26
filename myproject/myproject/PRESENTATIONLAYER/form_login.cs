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
    public partial class form_login : Form
    {
        BUSSINESSLAYER.cls_login log = new BUSSINESSLAYER.cls_login();
        public form_login()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void cencel_buton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login_buton_Click(object sender, EventArgs e)
        {
            DataTable dt = log.login(txt_username.Text, txt_pass.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("login succes");
                MAIN.myform.products.Enabled = true;
                MAIN.myform.sales.Enabled = true;
                MAIN.myform.users.Enabled = true;
                MAIN.myform.items.Enabled = true;
                MAIN.myform.customers.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("login failed");
            }
        }

        private void form_login_Load(object sender, EventArgs e)
        {

        }
    }
}
