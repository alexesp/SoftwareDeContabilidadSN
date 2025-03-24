using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDeContabilidad.Contabilidad
{
    public partial class BuscarProductFrm : Form
    {
        public BuscarProductFrm()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancel_button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BuscarClienteFrm_Load(object sender, EventArgs e)
        {

            //---------------------------------
            this.productsTableAdapter1.Fill_All(this.accDataSet1.Products);
        }

        private void search_id_button1_Click(object sender, EventArgs e)
        {
            Int32 id;
            Int32.TryParse(this.search_id_textBox1.Text, out id);
             this.productsTableAdapter1.FillBy_Id(this.accDataSet1.Products, id);

        }

        private void search_lname_button2_Click(object sender, EventArgs e)
        {
            string search_by;
            search_by = "%" + this.search_Prodname_textBox2.Text + "%";
            this.productsTableAdapter1.FillBy_product_name(this.accDataSet1.Products, search_by);
        }

        private void show_all_button1_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill_All(this.accDataSet1.Products);
        }

       
    }
}
