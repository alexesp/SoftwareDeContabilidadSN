using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDeContabilidad
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void min_button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_button1_Click(object sender, EventArgs e)
        {

            SoftwareDeContabilidad.Properties.Settings.Default.set_img_index = this.background_comboBox1.SelectedIndex;
            SoftwareDeContabilidad.Properties.Settings.Default.Save();


            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.date_time_label3.Text = DateTime.Now.Date.ToShortDateString() + " | " +
                DateTime.Now.ToLongTimeString();
        }

        private void background_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string fn;
                fn = Application.StartupPath + "Data\\Pics\\" + this.background_comboBox1.SelectedIndex.ToString() + ".jpg";
                this.BackgroundImage = Image.FromFile(fn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            int index;
            index = SoftwareDeContabilidad.Properties.Settings.Default.set_img_index;
            this.background_comboBox1.SelectedIndex = index;
        }
    }
}
