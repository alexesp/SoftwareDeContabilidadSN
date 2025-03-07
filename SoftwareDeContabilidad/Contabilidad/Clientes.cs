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
    public partial class Clientes : Form
    {
        public Clientes()
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
            if(is_del_butt == false)
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

        private void Clientes_Load(object sender, EventArgs e)
        {
            save_cancel_butts();
            //---------------------------------
            this.customersTableAdapter1.Fill_All(this.accDataSet1.Customers);
        }

        private void new_butt_Click(object sender, EventArgs e)
        {
            is_del_butt = false;
            new_edit_del_butts();
        }

        private void edit_butt_Click(object sender, EventArgs e)
        {
            is_del_butt = false;
            new_edit_del_butts();
        }

        private void del_butt_Click(object sender, EventArgs e)
        {
            is_del_butt = true;
            new_edit_del_butts();
        }

        private void save_butt_Click(object sender, EventArgs e)
        {
            save_cancel_butts();
        }

        private void cancel_butt_Click(object sender, EventArgs e)
        {
            save_cancel_butts();
        }
    }
}
