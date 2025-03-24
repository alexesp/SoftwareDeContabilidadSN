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
    public partial class FacturasVentasFrm : Form
    {
        public FacturasVentasFrm()
        {
            InitializeComponent();
        }

        Boolean is_del_butt = false;

        void new_edit_del_butts()
        {
            this.new_butt.Enabled = false;
            this.edit_butt.Enabled = false;
            this.del_butt.Enabled = false;
            //-------------------------------

            this.save_butt.Enabled = true;
            this.cancel_butt.Enabled = true;

            //----------------------------------
            //this.dataGridView1.Enabled = false;
            if (is_del_butt == false)
            {
                this.groupBox1.Enabled = true;
            }
            else
            {
                this.groupBox1.Enabled = false;
            }

        }
        void save_cancel_butts()
        {
            this.new_butt.Enabled = true;
            this.edit_butt.Enabled = true;
            this.del_butt.Enabled = true;
            //-------------------------------

            this.save_butt.Enabled = false;
            this.cancel_butt.Enabled = false;

            //----------------------------------

            // this.dataGridView1.Enabled = true;
            this.groupBox1.Enabled = false;
        }

        private void new_butt_Click(object sender, EventArgs e)
        {
            is_del_butt = false;
            new_edit_del_butts();

            //---------------------------

            this.bindingSource3.AddNew();

            //-----------------------------
            this.reg_user_label11.Text = "Login User";
            this.reg_date_label12.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label14.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FacturasVentasFrm_Load(object sender, EventArgs e)
        {
            save_cancel_butts();
            //---------------------------------
            this.salesInvoiceTableAdapter2.Fill_All(this.accDataSet3.SalesInvoice);
        }

        private void edit_butt_Click(object sender, EventArgs e)
        {
            is_del_butt = false;
            new_edit_del_butts();
            //-----------------------------
            this.reg_user_label11.Text = "Login User";
            this.reg_date_label12.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label14.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void del_butt_Click(object sender, EventArgs e)
        {
            is_del_butt = true;
            new_edit_del_butts();
            //-------------------------

            this.bindingSource3.RemoveCurrent();
        }

        private void save_butt_Click(object sender, EventArgs e)
        {
            try
            {
                this.bindingSource3.EndEdit();
                int rv;
                rv = this.salesInvoiceTableAdapter2.Update(this.accDataSet2.SalesInvoice);
                //-----------------------------------------------------------------------
                if (rv > 0)
                {
                    save_cancel_butts();
                    MessageBox.Show("Registro " + rv.ToString() + " guardado con exito.");
                }
                else
                {
                    MessageBox.Show("No se guardo el registro.");
                }
                //-------------------------------------------------------------------------
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cancel_butt_Click(object sender, EventArgs e)
        {
            save_cancel_butts();
            //-----------------------

            this.bindingSource3.CancelEdit();
            this.accDataSet2.Products.RejectChanges();
        }

        private void cu_search_button1_Click(object sender, EventArgs e)
        {
            SoftwareDeContabilidad.Contabilidad.BuscarProductFrm frm = new BuscarProductFrm();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.cu_id_textBox1.Text = frm.id_label4.Text;
                string a;
                //a = frm.ProductName_label5.Text + "  " + frm.lname_label6.Text;
                //this.cu_name_textBox3.Text = a;





            }
        }

        private void pro_list_button1_Click(object sender, EventArgs e)
        {
            SoftwareDeContabilidad.Contabilidad.FacturasVentasProdFrm frm = new FacturasVentasProdFrm();
            frm.selected_invoice_id = int.Parse(this.cu_id_textBox1.Text);
            frm.ShowDialog();
        }
    }
}
