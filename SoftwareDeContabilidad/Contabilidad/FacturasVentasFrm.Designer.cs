namespace SoftwareDeContabilidad.Contabilidad
{
    partial class FacturasVentasFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasVentasFrm));
            toolStrip1 = new ToolStrip();
            new_butt = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            edit_butt = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            del_butt = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            save_butt = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            cancel_butt = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            search_butt = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            other_numericUpDown2 = new NumericUpDown();
            bindingSource1 = new BindingSource(components);
            accDataSet1 = new SoftwareDeContabilidad.DataSet.AccDataSet();
            shipping_numericUpDown1 = new NumericUpDown();
            cu_search_button1 = new Button();
            invoice_date_dtp = new DateTimePicker();
            comment_textBox6 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cu_name_textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            id_textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            reg_time_label14 = new Label();
            reg_time_label15 = new Label();
            reg_date_label12 = new Label();
            reg_date_label13 = new Label();
            reg_user_label11 = new Label();
            reg_user_label10 = new Label();
            cu_id_textBox1 = new TextBox();
            label7 = new Label();
            salesInvoiceTableAdapter1 = new SoftwareDeContabilidad.DataSet.AccDataSetTableAdapters.SalesInvoiceTableAdapter();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)other_numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDataSet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shipping_numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { new_butt, toolStripSeparator1, edit_butt, toolStripSeparator2, del_butt, toolStripSeparator3, save_butt, toolStripSeparator4, cancel_butt, toolStripSeparator5, search_butt, toolStripSeparator6 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 54);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // new_butt
            // 
            new_butt.AutoSize = false;
            new_butt.Image = (Image)resources.GetObject("new_butt.Image");
            new_butt.ImageScaling = ToolStripItemImageScaling.None;
            new_butt.ImageTransparentColor = Color.Magenta;
            new_butt.Name = "new_butt";
            new_butt.Size = new Size(120, 51);
            new_butt.Text = "Nueva factura";
            new_butt.TextImageRelation = TextImageRelation.ImageAboveText;
            new_butt.Click += new_butt_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // edit_butt
            // 
            edit_butt.AutoSize = false;
            edit_butt.Image = (Image)resources.GetObject("edit_butt.Image");
            edit_butt.ImageScaling = ToolStripItemImageScaling.None;
            edit_butt.ImageTransparentColor = Color.Magenta;
            edit_butt.Name = "edit_butt";
            edit_butt.Size = new Size(90, 51);
            edit_butt.Text = "Editar";
            edit_butt.TextImageRelation = TextImageRelation.ImageAboveText;
            edit_butt.Click += edit_butt_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 54);
            // 
            // del_butt
            // 
            del_butt.AutoSize = false;
            del_butt.Image = (Image)resources.GetObject("del_butt.Image");
            del_butt.ImageScaling = ToolStripItemImageScaling.None;
            del_butt.ImageTransparentColor = Color.Magenta;
            del_butt.Name = "del_butt";
            del_butt.Size = new Size(90, 51);
            del_butt.Text = "Eliminar";
            del_butt.TextImageRelation = TextImageRelation.ImageAboveText;
            del_butt.Visible = false;
            del_butt.Click += del_butt_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 54);
            toolStripSeparator3.Visible = false;
            // 
            // save_butt
            // 
            save_butt.AutoSize = false;
            save_butt.Enabled = false;
            save_butt.Image = (Image)resources.GetObject("save_butt.Image");
            save_butt.ImageScaling = ToolStripItemImageScaling.None;
            save_butt.ImageTransparentColor = Color.Magenta;
            save_butt.Name = "save_butt";
            save_butt.Size = new Size(90, 51);
            save_butt.Text = "Guardar";
            save_butt.TextImageRelation = TextImageRelation.ImageAboveText;
            save_butt.Click += save_butt_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 54);
            // 
            // cancel_butt
            // 
            cancel_butt.AutoSize = false;
            cancel_butt.Enabled = false;
            cancel_butt.Image = (Image)resources.GetObject("cancel_butt.Image");
            cancel_butt.ImageScaling = ToolStripItemImageScaling.None;
            cancel_butt.ImageTransparentColor = Color.Magenta;
            cancel_butt.Name = "cancel_butt";
            cancel_butt.Size = new Size(90, 51);
            cancel_butt.Text = "Cancelar";
            cancel_butt.TextImageRelation = TextImageRelation.ImageAboveText;
            cancel_butt.Click += cancel_butt_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 54);
            // 
            // search_butt
            // 
            search_butt.Alignment = ToolStripItemAlignment.Right;
            search_butt.AutoSize = false;
            search_butt.Image = (Image)resources.GetObject("search_butt.Image");
            search_butt.ImageScaling = ToolStripItemImageScaling.None;
            search_butt.ImageTransparentColor = Color.Magenta;
            search_butt.Name = "search_butt";
            search_butt.Size = new Size(90, 51);
            search_butt.Text = "Buscar";
            search_butt.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 54);
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(other_numericUpDown2);
            groupBox1.Controls.Add(shipping_numericUpDown1);
            groupBox1.Controls.Add(cu_search_button1);
            groupBox1.Controls.Add(invoice_date_dtp);
            groupBox1.Controls.Add(comment_textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cu_name_textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(id_textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 404);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(176, 181);
            label9.Name = "label9";
            label9.Size = new Size(19, 23);
            label9.TabIndex = 24;
            label9.Text = "€";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(176, 148);
            label8.Name = "label8";
            label8.Size = new Size(19, 23);
            label8.TabIndex = 23;
            label8.Text = "€";
            // 
            // other_numericUpDown2
            // 
            other_numericUpDown2.DataBindings.Add(new Binding("Value", bindingSource1, "Other", true));
            other_numericUpDown2.DecimalPlaces = 2;
            other_numericUpDown2.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            other_numericUpDown2.Location = new Point(194, 179);
            other_numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            other_numericUpDown2.Name = "other_numericUpDown2";
            other_numericUpDown2.Size = new Size(316, 30);
            other_numericUpDown2.TabIndex = 22;
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "SalesInvoice";
            bindingSource1.DataSource = accDataSet1;
            // 
            // accDataSet1
            // 
            accDataSet1.DataSetName = "AccDataSet";
            accDataSet1.Namespace = "http://tempuri.org/AccDataSet.xsd";
            accDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shipping_numericUpDown1
            // 
            shipping_numericUpDown1.DataBindings.Add(new Binding("Value", bindingSource1, "Shipping", true));
            shipping_numericUpDown1.DecimalPlaces = 2;
            shipping_numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            shipping_numericUpDown1.Location = new Point(194, 146);
            shipping_numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            shipping_numericUpDown1.Name = "shipping_numericUpDown1";
            shipping_numericUpDown1.Size = new Size(316, 30);
            shipping_numericUpDown1.TabIndex = 21;
            // 
            // cu_search_button1
            // 
            cu_search_button1.Location = new Point(18, 112);
            cu_search_button1.Name = "cu_search_button1";
            cu_search_button1.Size = new Size(170, 29);
            cu_search_button1.TabIndex = 20;
            cu_search_button1.Text = "Nombre del cliente:";
            cu_search_button1.UseVisualStyleBackColor = true;
            cu_search_button1.Click += cu_search_button1_Click;
            // 
            // invoice_date_dtp
            // 
            invoice_date_dtp.DataBindings.Add(new Binding("Value", bindingSource1, "InvoiceDate", true));
            invoice_date_dtp.Format = DateTimePickerFormat.Short;
            invoice_date_dtp.Location = new Point(194, 74);
            invoice_date_dtp.Name = "invoice_date_dtp";
            invoice_date_dtp.Size = new Size(316, 30);
            invoice_date_dtp.TabIndex = 19;
            // 
            // comment_textBox6
            // 
            comment_textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "Comment", true));
            comment_textBox6.Location = new Point(194, 215);
            comment_textBox6.Name = "comment_textBox6";
            comment_textBox6.Size = new Size(316, 30);
            comment_textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 222);
            label6.Name = "label6";
            label6.Size = new Size(104, 23);
            label6.TabIndex = 10;
            label6.Text = "Comentario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 189);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 8;
            label5.Text = "Otros:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 153);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 6;
            label4.Text = "Envio:";
            // 
            // cu_name_textBox3
            // 
            cu_name_textBox3.BorderStyle = BorderStyle.FixedSingle;
            cu_name_textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "CustomerName", true));
            cu_name_textBox3.Location = new Point(194, 110);
            cu_name_textBox3.Name = "cu_name_textBox3";
            cu_name_textBox3.ReadOnly = true;
            cu_name_textBox3.Size = new Size(316, 30);
            cu_name_textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 117);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 81);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 2;
            label2.Text = "Fecha de factura:";
            // 
            // id_textBox1
            // 
            id_textBox1.BorderStyle = BorderStyle.FixedSingle;
            id_textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "InvoiceId", true));
            id_textBox1.Location = new Point(194, 38);
            id_textBox1.Name = "id_textBox1";
            id_textBox1.ReadOnly = true;
            id_textBox1.Size = new Size(316, 30);
            id_textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 45);
            label1.Name = "label1";
            label1.Size = new Size(159, 23);
            label1.TabIndex = 0;
            label1.Text = "Numero de factura:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(reg_time_label14);
            panel1.Controls.Add(reg_time_label15);
            panel1.Controls.Add(reg_date_label12);
            panel1.Controls.Add(reg_date_label13);
            panel1.Controls.Add(reg_user_label11);
            panel1.Controls.Add(reg_user_label10);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 629);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 41);
            panel1.TabIndex = 8;
            // 
            // reg_time_label14
            // 
            reg_time_label14.DataBindings.Add(new Binding("Text", bindingSource1, "RegTime", true));
            reg_time_label14.Location = new Point(697, 8);
            reg_time_label14.Name = "reg_time_label14";
            reg_time_label14.Size = new Size(91, 23);
            reg_time_label14.TabIndex = 6;
            reg_time_label14.Text = "-";
            // 
            // reg_time_label15
            // 
            reg_time_label15.AutoSize = true;
            reg_time_label15.Location = new Point(562, 8);
            reg_time_label15.Name = "reg_time_label15";
            reg_time_label15.Size = new Size(138, 23);
            reg_time_label15.TabIndex = 5;
            reg_time_label15.Text = "Hora de registro:";
            // 
            // reg_date_label12
            // 
            reg_date_label12.DataBindings.Add(new Binding("Text", bindingSource1, "RegDate", true));
            reg_date_label12.Location = new Point(445, 8);
            reg_date_label12.Name = "reg_date_label12";
            reg_date_label12.Size = new Size(102, 23);
            reg_date_label12.TabIndex = 4;
            reg_date_label12.Text = "-";
            // 
            // reg_date_label13
            // 
            reg_date_label13.AutoSize = true;
            reg_date_label13.Location = new Point(300, 8);
            reg_date_label13.Name = "reg_date_label13";
            reg_date_label13.Size = new Size(145, 23);
            reg_date_label13.TabIndex = 3;
            reg_date_label13.Text = "Fecha de registro:";
            // 
            // reg_user_label11
            // 
            reg_user_label11.DataBindings.Add(new Binding("Text", bindingSource1, "RegUser", true));
            reg_user_label11.Location = new Point(175, 8);
            reg_user_label11.Name = "reg_user_label11";
            reg_user_label11.Size = new Size(127, 23);
            reg_user_label11.TabIndex = 2;
            reg_user_label11.Text = "-";
            // 
            // reg_user_label10
            // 
            reg_user_label10.AutoSize = true;
            reg_user_label10.Location = new Point(11, 8);
            reg_user_label10.Name = "reg_user_label10";
            reg_user_label10.Size = new Size(158, 23);
            reg_user_label10.TabIndex = 1;
            reg_user_label10.Text = "Usuario Registrado:";
            // 
            // cu_id_textBox1
            // 
            cu_id_textBox1.BorderStyle = BorderStyle.FixedSingle;
            cu_id_textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "CustomerId", true));
            cu_id_textBox1.Location = new Point(684, 180);
            cu_id_textBox1.Name = "cu_id_textBox1";
            cu_id_textBox1.ReadOnly = true;
            cu_id_textBox1.Size = new Size(105, 30);
            cu_id_textBox1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(563, 182);
            label7.Name = "label7";
            label7.Size = new Size(115, 23);
            label7.TabIndex = 9;
            label7.Text = "Id del Cliente:";
            // 
            // salesInvoiceTableAdapter1
            // 
            salesInvoiceTableAdapter1.ClearBeforeFill = true;
            // 
            // FacturasVentasFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 670);
            Controls.Add(cu_id_textBox1);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FacturasVentasFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturas de Ventas";
            Load += FacturasVentasFrm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)other_numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDataSet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)shipping_numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton new_butt;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton edit_butt;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton del_butt;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton save_butt;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton cancel_butt;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton search_butt;
        private ToolStripSeparator toolStripSeparator6;
        private GroupBox groupBox1;
        private TextBox comment_textBox6;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox cu_name_textBox3;
        private Label label3;
        private Label label2;
        private TextBox id_textBox1;
        private Label label1;
        private Panel panel1;
        private Label reg_time_label14;
        private Label reg_time_label15;
        private Label reg_date_label12;
        private Label reg_date_label13;
        private Label reg_user_label11;
        private Label reg_user_label10;
        private DateTimePicker invoice_date_dtp;
        private Button cu_search_button1;
        private NumericUpDown shipping_numericUpDown1;
        private NumericUpDown other_numericUpDown2;
        private TextBox cu_id_textBox1;
        private Label label7;
        private BindingSource bindingSource1;
        private DataSet.AccDataSet accDataSet1;
        private DataSet.AccDataSetTableAdapters.SalesInvoiceTableAdapter salesInvoiceTableAdapter1;
        private Label label8;
        private Label label9;
    }
}