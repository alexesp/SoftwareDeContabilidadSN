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
    public partial class Productos : Form
    {
        public Productos()
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
            this.dataGridView1.Enabled = false;
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

            this.dataGridView1.Enabled = true;
            this.groupBox1.Enabled = false;
        }

        private void new_butt_Click(object sender, EventArgs e)
        {
            is_del_butt = false;
            new_edit_del_butts();

            //---------------------------

            this.bindingSource1.AddNew();

            //-----------------------------
            this.reg_user_label11.Text = "Login User";
            this.reg_date_label12.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label14.Text = DateTime.Now.ToString("HH:mm:ss");
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

            this.bindingSource1.RemoveCurrent();
        }

        private void save_butt_Click(object sender, EventArgs e)
        {
            try
            {
                this.bindingSource1.EndEdit();
                int rv;
                rv = this.productsTableAdapter1.Update(this.accDataSet1.Products);
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

            this.bindingSource1.CancelEdit();
            this.accDataSet1.Products.RejectChanges();
        }

        private void search_butt_Click(object sender, EventArgs e)
        {
            if (this.search_panel2.Visible == true)
            {
                this.search_panel2.Visible = false;
            }
            else
            {
                this.search_panel2.Visible = true;
            }
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
            search_by = "%" + this.search_product_name_textBox2.Text + "%";
            this.productsTableAdapter1.FillBy_product_name(this.accDataSet1.Products, search_by);
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            save_cancel_butts();
            //---------------------------------
            this.productsTableAdapter1.Fill_All(this.accDataSet1.Products);
        }
    }
}
