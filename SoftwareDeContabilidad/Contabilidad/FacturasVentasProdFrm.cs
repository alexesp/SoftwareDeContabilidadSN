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
    public partial class FacturasVentasProdFrm : Form
    {
        public FacturasVentasProdFrm()
        {
            InitializeComponent();
        }

        Boolean is_del_butt = false;
        public int selected_invoice_id = 0;
        void new_edit_del_butts()
        {
            this.new_butt.Enabled = false;
            this.edit_butt.Enabled = false;
            this.del_butt.Enabled = false;
            //-----------
            this.save_butt.Enabled = true;
            this.cancel_butt.Enabled = true;
            //-----------
            //this.dataGridView1.Enabled = false;
            //-----------
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
            //-----------
            this.save_butt.Enabled = false;
            this.cancel_butt.Enabled = false;
            //-----------
            //this.dataGridView1.Enabled = true;
            this.groupBox1.Enabled = false;
        }
        private void new_butt_Click(object sender, EventArgs e)
        {
            is_del_butt = false;
            new_edit_del_butts();
            //----------
            this.bindingSource3.AddNew();
            //------------------
            this.invoice_id_textBox1.Text = selected_invoice_id.ToString();
            //------------------
            //this.reg_user_label11.Text = AccountigSoft.Properties.Settings.Default.login_user_name;
            this.reg_date_label12.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label14.Text = DateTime.Now.ToString("HH:mm:ss");
            //------------------
        }



        private void edit_butt_Click(object sender, EventArgs e)
        {
            is_del_butt = false;
            new_edit_del_butts();
            //------------------
            this.invoice_id_textBox1.Text = selected_invoice_id.ToString();
            //------------------
            //this.reg_user_label11.Text = AccountigSoft.Properties.Settings.Default.login_user_name;
            this.reg_date_label12.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label14.Text = DateTime.Now.ToString("HH:mm:ss");
            //------------------
        }

        private void del_butt_Click(object sender, EventArgs e)
        {
            is_del_butt = true;
            new_edit_del_butts();
            //-------------
            this.bindingSource3.RemoveCurrent();
        }

        private void save_butt_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.bindingSource1.EndEdit();
            //int rv = 0;
            //rv = this.salesInvoiceTableAdapter1.Update(this.accDataSet1.SalesInvoiceProducts);
            //---------------
            //    if (rv > 0)
            //    {
            //        save_cancel_butts();
            //        MessageBox.Show("It's saved! Count: " + rv.ToString());
            //    }
            //    else
            //    {
            //        MessageBox.Show("Not saved!");
            //    }
            //    //---------------
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void cancel_butt_Click(object sender, EventArgs e)
        {
            save_cancel_butts();
            //--------------
            this.bindingSource3.CancelEdit();
            this.accDataSet1.SalesInvoiceProducts.RejectChanges();
        }

        //private void product_search_Butt_Click(object sender, EventArgs e)
        //{
        // AccountigSoft.Accounting.ProductSearch frm = new ProductSearch();
        //frm.ShowDialog();
        //if (frm.DialogResult == DialogResult.OK)
        //{
        //    this.product_id_textBox7.Text = frm.id_label4.Text;
        //    //--------------
        //    this.product_name_textBox3.Text = frm.ProductName_label5.Text;
        //    //--------------unit-price-discount-------------------
        //    this.unit_textBox1.Text = frm.unit_lbl.Text;
        //    this.price_nud.Value = decimal.Parse(frm.price_lbl.Text);
        //    this.discount_nud.Value = decimal.Parse(frm.discount_lbl.Text);
        //    //----------------------------------------------------
        //    sum_calc();
        //-----------------------

        //}
        //}

        public void sum_calc()
        {
            //if (this.save_butt.Enabled == false)
            //{
            //    return;
            //}
            ////--------------------------------
            //try
            //{
            //    decimal amount, net_amount, tax_rate, tax_sum;
            //    // -----------------amount-----------------------------------
            //    amount = (this.Qty_nud.Value * this.price_nud.Value) - this.discount_nud.Value;
            //    this.amount_nud.Value = amount;
            //    // -----------------tax_sum-----------------------------------
            //    tax_rate = AccountigSoft.Properties.Settings.Default.stt_sale_tax;//percentage
            //    tax_sum = (amount * tax_rate) / 100;//
            //    //----------------------
            //    this.tax_rate_nud.Value = tax_rate;
            //    this.tax_sum_nud.Value = tax_sum;
            //    // ------------------total-------------------------------
            //    net_amount = amount + tax_sum;
            //    this.net_amount_nud.Value = net_amount;
            //}
            // ----------------------------------------------------------
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void FacturasVentasProdFrm_Load(object sender, EventArgs e)
        {
            save_cancel_butts();
            this.salesInvoiceProductsTableAdapter1.FillBy_InvoiceId(this.accDataSet1.SalesInvoiceProducts, selected_invoice_id);
            //----------------------
        }



        private void new_butt_Click_1(object sender, EventArgs e)
        {

        }

       

        private void cu_search_button1_Click(object sender, EventArgs e)
        {
            SoftwareDeContabilidad.Contabilidad.BuscarProductFrm frm = new BuscarProductFrm();
            frm.ShowDialog();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.products_id_textBox1.Text = frm.search_id_textBox1.Text;
                this.product_name_textBox3.Text = frm.search_Prodname_textBox2.Text;
            }
        }

        //private void Qty_nud_ValueChanged(object sender, EventArgs e)
        //{
        //    //sum_calc();
        //}

        //private void Qty_nud_KeyUp(object sender, KeyEventArgs e)
        //{
        //    //sum_calc();
        //}

        //private void price_nud_KeyUp(object sender, KeyEventArgs e)
        //{
        //    //sum_calc();
        //}

        //private void price_nud_ValueChanged(object sender, EventArgs e)
        //{
        //    sum_calc();
        //}

        //private void discount_nud_KeyUp(object sender, KeyEventArgs e)
        //{
        //    sum_calc();
        //}

        //private void discount_nud_ValueChanged(object sender, EventArgs e)
        //{
        //    sum_calc();
        //}

        //private void tax_rate_Button1_Click(object sender, EventArgs e)
        //{
        //    AccountigSoft.Accounting.SettingsFrm frm = new SettingsFrm();
        //    frm.ShowDialog();
        //    this.tax_rate_nud.Value = AccountigSoft.Properties.Settings.Default.stt_sale_tax;
        //}
    }
}
