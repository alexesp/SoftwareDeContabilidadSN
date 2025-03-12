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
    public partial class BuscarClienteFrm : Form
    {
        public BuscarClienteFrm()
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
            this.customersTableAdapter1.Fill_All(this.accDataSet1.Customers);
        }

        private void search_id_button1_Click(object sender, EventArgs e)
        {
            Int32 id;
            Int32.TryParse(this.search_id_textBox1.Text, out id);
            this.customersTableAdapter1.FillBy_id(this.accDataSet1.Customers, id);

        }

        private void search_lname_button2_Click(object sender, EventArgs e)
        {
            string search_by;
            search_by = "%" + this.search_lname_textBox2.Text + "%";
            this.customersTableAdapter1.FillBy_last_name(this.accDataSet1.Customers, search_by);
        }

        private void show_all_button1_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter1.Fill_All(this.accDataSet1.Customers);
        }
    }
}
