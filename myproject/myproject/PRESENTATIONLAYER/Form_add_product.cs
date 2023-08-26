using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace myproject.PRESENTATIONLAYER
{
    
    public partial class Form_add_product : Form
    {
        SqlConnection con = new SqlConnection("server= DESKTOP-4SE332T;database = pos_full DB; integrated security =true");
        SqlDataAdapter da;
        SqlCommand com;
        DataTable dt;
      
        public Form_add_product()
        {
            InitializeComponent();
         
           // con.Open();
            //SqlCommand com = new SqlCommand("select description from category", con);
            //da = new SqlDataAdapter(com);
            //dt = new DataTable();
            //da.Fill(dt);
            

            


        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_add_product_Load(object sender, EventArgs e)
        {
            
        }

        private void addproduct_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com = new SqlCommand("insert into products(id_product,name_product,qty,price,id_cat)values ('" + this.txt_number_product.Text + "','" + this.txt_name_product.Text + "','" + this.txt_qty_prouct.Text + "','" + this.txt_price_product.Text + "')", con);
                com.ExecuteNonQuery();
                MessageBox.Show("done");

            }
            catch (Exception e){
                MessageBox.Show(e.Message);
            }
        }
    }
}
