namespace SoftwareDeContabilidad.Contabilidad
{
    partial class FacturasVentasProdFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasVentasProdFrm));
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
            label19 = new Label();
            net_amount_numericUpDown1 = new NumericUpDown();
            bindingSource1 = new BindingSource(components);
            accDataSet1 = new SoftwareDeContabilidad.DataSet.AccDataSet();
            label20 = new Label();
            label17 = new Label();
            tax_sum_numericUpDown1 = new NumericUpDown();
            label18 = new Label();
            label15 = new Label();
            tax_rate_numericUpDown1 = new NumericUpDown();
            label16 = new Label();
            label13 = new Label();
            amount_numericUpDown1 = new NumericUpDown();
            label14 = new Label();
            label11 = new Label();
            discount_numericUpDown1 = new NumericUpDown();
            label12 = new Label();
            unit_textBox1 = new TextBox();
            label10 = new Label();
            invoice_id_textBox1 = new TextBox();
            label2 = new Label();
            label9 = new Label();
            label8 = new Label();
            price_numericUpDown2 = new NumericUpDown();
            qty_numericUpDown1 = new NumericUpDown();
            cu_search_button1 = new Button();
            comment_textBox6 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            product_name_textBox3 = new TextBox();
            label3 = new Label();
            id_textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            reg_time_label14 = new Label();
            reg_time_label15 = new Label();
            reg_date_label12 = new Label();
            reg_date_label13 = new Label();
            reg_user_label11 = new Label();
            reg_user_label10 = new Label();
            dataGridView1 = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            invoiceIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxSumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            netAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            products_id_textBox1 = new TextBox();
            label7 = new Label();
            salesInvoiceProductsTableAdapter1 = new SoftwareDeContabilidad.DataSet.AccDataSetTableAdapters.SalesInvoiceProductsTableAdapter();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)net_amount_numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDataSet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tax_sum_numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tax_rate_numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amount_numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discount_numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price_numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)qty_numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { new_butt, toolStripSeparator1, edit_butt, toolStripSeparator2, del_butt, toolStripSeparator3, save_butt, toolStripSeparator4, cancel_butt, toolStripSeparator5, search_butt, toolStripSeparator6 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 54);
            toolStrip1.TabIndex = 3;
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
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 54);
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
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(net_amount_numericUpDown1);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(tax_sum_numericUpDown1);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(tax_rate_numericUpDown1);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(amount_numericUpDown1);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(discount_numericUpDown1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(unit_textBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(invoice_id_textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(price_numericUpDown2);
            groupBox1.Controls.Add(qty_numericUpDown1);
            groupBox1.Controls.Add(cu_search_button1);
            groupBox1.Controls.Add(comment_textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(product_name_textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(id_textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 486);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(176, 399);
            label19.Name = "label19";
            label19.Size = new Size(19, 23);
            label19.TabIndex = 43;
            label19.Text = "€";
            // 
            // net_amount_numericUpDown1
            // 
            net_amount_numericUpDown1.DataBindings.Add(new Binding("Value", bindingSource1, "NetAmount", true));
            net_amount_numericUpDown1.DecimalPlaces = 2;
            net_amount_numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            net_amount_numericUpDown1.Location = new Point(201, 397);
            net_amount_numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            net_amount_numericUpDown1.Name = "net_amount_numericUpDown1";
            net_amount_numericUpDown1.Size = new Size(316, 30);
            net_amount_numericUpDown1.TabIndex = 42;
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "SalesInvoiceProducts";
            bindingSource1.DataSource = accDataSet1;
            // 
            // accDataSet1
            // 
            accDataSet1.DataSetName = "AccDataSet";
            accDataSet1.Namespace = "http://tempuri.org/AccDataSet.xsd";
            accDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(13, 399);
            label20.Name = "label20";
            label20.Size = new Size(115, 23);
            label20.TabIndex = 41;
            label20.Text = "Importe neto:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(176, 363);
            label17.Name = "label17";
            label17.Size = new Size(19, 23);
            label17.TabIndex = 40;
            label17.Text = "€";
            // 
            // tax_sum_numericUpDown1
            // 
            tax_sum_numericUpDown1.DataBindings.Add(new Binding("Value", bindingSource1, "TaxSum", true));
            tax_sum_numericUpDown1.DecimalPlaces = 2;
            tax_sum_numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            tax_sum_numericUpDown1.Location = new Point(201, 361);
            tax_sum_numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            tax_sum_numericUpDown1.Name = "tax_sum_numericUpDown1";
            tax_sum_numericUpDown1.Size = new Size(316, 30);
            tax_sum_numericUpDown1.TabIndex = 39;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(13, 363);
            label18.Name = "label18";
            label18.Size = new Size(150, 23);
            label18.TabIndex = 38;
            label18.Text = "Total de impuesto:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(176, 328);
            label15.Name = "label15";
            label15.Size = new Size(24, 23);
            label15.TabIndex = 37;
            label15.Text = "%";
            // 
            // tax_rate_numericUpDown1
            // 
            tax_rate_numericUpDown1.DataBindings.Add(new Binding("Value", bindingSource1, "TaxRate", true));
            tax_rate_numericUpDown1.DecimalPlaces = 2;
            tax_rate_numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            tax_rate_numericUpDown1.Location = new Point(201, 326);
            tax_rate_numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            tax_rate_numericUpDown1.Name = "tax_rate_numericUpDown1";
            tax_rate_numericUpDown1.Size = new Size(316, 30);
            tax_rate_numericUpDown1.TabIndex = 36;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(13, 328);
            label16.Name = "label16";
            label16.Size = new Size(146, 23);
            label16.TabIndex = 35;
            label16.Text = "Tasa de impuesto:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(176, 292);
            label13.Name = "label13";
            label13.Size = new Size(19, 23);
            label13.TabIndex = 34;
            label13.Text = "€";
            // 
            // amount_numericUpDown1
            // 
            amount_numericUpDown1.DataBindings.Add(new Binding("Value", bindingSource1, "Amount", true));
            amount_numericUpDown1.DecimalPlaces = 2;
            amount_numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            amount_numericUpDown1.Location = new Point(201, 290);
            amount_numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            amount_numericUpDown1.Name = "amount_numericUpDown1";
            amount_numericUpDown1.Size = new Size(316, 30);
            amount_numericUpDown1.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 292);
            label14.Name = "label14";
            label14.Size = new Size(119, 23);
            label14.TabIndex = 32;
            label14.Text = "Cantdad total:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(176, 256);
            label11.Name = "label11";
            label11.Size = new Size(19, 23);
            label11.TabIndex = 31;
            label11.Text = "€";
            // 
            // discount_numericUpDown1
            // 
            discount_numericUpDown1.DataBindings.Add(new Binding("Value", bindingSource1, "Discount", true));
            discount_numericUpDown1.DecimalPlaces = 2;
            discount_numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            discount_numericUpDown1.Location = new Point(201, 254);
            discount_numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            discount_numericUpDown1.Name = "discount_numericUpDown1";
            discount_numericUpDown1.Size = new Size(316, 30);
            discount_numericUpDown1.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 256);
            label12.Name = "label12";
            label12.Size = new Size(95, 23);
            label12.TabIndex = 29;
            label12.Text = "Descuento:";
            // 
            // unit_textBox1
            // 
            unit_textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Unit", true));
            unit_textBox1.Location = new Point(201, 182);
            unit_textBox1.Name = "unit_textBox1";
            unit_textBox1.Size = new Size(316, 30);
            unit_textBox1.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 185);
            label10.Name = "label10";
            label10.Size = new Size(69, 23);
            label10.TabIndex = 27;
            label10.Text = "Unidad:";
            // 
            // invoice_id_textBox1
            // 
            invoice_id_textBox1.BorderStyle = BorderStyle.FixedSingle;
            invoice_id_textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "InvoiceId", true));
            invoice_id_textBox1.Location = new Point(201, 74);
            invoice_id_textBox1.Name = "invoice_id_textBox1";
            invoice_id_textBox1.ReadOnly = true;
            invoice_id_textBox1.Size = new Size(316, 30);
            invoice_id_textBox1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 78);
            label2.Name = "label2";
            label2.Size = new Size(177, 23);
            label2.TabIndex = 25;
            label2.Text = "Numero de la factura:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(176, 220);
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
            // price_numericUpDown2
            // 
            price_numericUpDown2.DataBindings.Add(new Binding("Value", bindingSource1, "UnitPrice", true));
            price_numericUpDown2.DecimalPlaces = 2;
            price_numericUpDown2.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            price_numericUpDown2.Location = new Point(201, 218);
            price_numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            price_numericUpDown2.Name = "price_numericUpDown2";
            price_numericUpDown2.Size = new Size(316, 30);
            price_numericUpDown2.TabIndex = 22;
            // 
            // qty_numericUpDown1
            // 
            qty_numericUpDown1.DataBindings.Add(new Binding("Value", bindingSource1, "Qty", true));
            qty_numericUpDown1.DecimalPlaces = 2;
            qty_numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            qty_numericUpDown1.Location = new Point(201, 146);
            qty_numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            qty_numericUpDown1.Name = "qty_numericUpDown1";
            qty_numericUpDown1.Size = new Size(316, 30);
            qty_numericUpDown1.TabIndex = 21;
            // 
            // cu_search_button1
            // 
            cu_search_button1.Font = new Font("Segoe UI", 9.2F);
            cu_search_button1.Location = new Point(15, 112);
            cu_search_button1.Name = "cu_search_button1";
            cu_search_button1.Size = new Size(175, 29);
            cu_search_button1.TabIndex = 20;
            cu_search_button1.Text = "Nombre del Producto:";
            cu_search_button1.UseVisualStyleBackColor = true;
            // 
            // comment_textBox6
            // 
            comment_textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "Comment", true));
            comment_textBox6.Location = new Point(201, 434);
            comment_textBox6.Name = "comment_textBox6";
            comment_textBox6.Size = new Size(316, 30);
            comment_textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 436);
            label6.Name = "label6";
            label6.Size = new Size(104, 23);
            label6.TabIndex = 10;
            label6.Text = "Comentario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 221);
            label5.Name = "label5";
            label5.Size = new Size(125, 23);
            label5.TabIndex = 8;
            label5.Text = "Precio unitario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 148);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 6;
            label4.Text = "Cantidad:";
            // 
            // product_name_textBox3
            // 
            product_name_textBox3.BorderStyle = BorderStyle.FixedSingle;
            product_name_textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "ProductName", true));
            product_name_textBox3.Location = new Point(201, 110);
            product_name_textBox3.Name = "product_name_textBox3";
            product_name_textBox3.ReadOnly = true;
            product_name_textBox3.Size = new Size(316, 30);
            product_name_textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 117);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 4;
            // 
            // id_textBox1
            // 
            id_textBox1.BorderStyle = BorderStyle.FixedSingle;
            id_textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "ID", true));
            id_textBox1.Location = new Point(201, 38);
            id_textBox1.Name = "id_textBox1";
            id_textBox1.ReadOnly = true;
            id_textBox1.Size = new Size(316, 30);
            id_textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 42);
            label1.Name = "label1";
            label1.Size = new Size(31, 23);
            label1.TabIndex = 0;
            label1.Text = "ID:";
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
            panel1.Location = new Point(0, 732);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 41);
            panel1.TabIndex = 9;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, invoiceIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, productIdDataGridViewTextBoxColumn, qtyDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, taxRateDataGridViewTextBoxColumn, taxSumDataGridViewTextBoxColumn, netAmountDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(12, 549);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 177);
            dataGridView1.TabIndex = 10;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            invoiceIdDataGridViewTextBoxColumn.HeaderText = "Numero de la factura";
            invoiceIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            invoiceIdDataGridViewTextBoxColumn.ReadOnly = true;
            invoiceIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Nombre del Producto";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "Id del Producto";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            qtyDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            qtyDataGridViewTextBoxColumn.ReadOnly = true;
            qtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unidad";
            unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.ReadOnly = true;
            unitDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "Precio unitario";
            unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            discountDataGridViewTextBoxColumn.HeaderText = "Descuento";
            discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            discountDataGridViewTextBoxColumn.ReadOnly = true;
            discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Cantidad total";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // taxRateDataGridViewTextBoxColumn
            // 
            taxRateDataGridViewTextBoxColumn.DataPropertyName = "TaxRate";
            taxRateDataGridViewTextBoxColumn.HeaderText = "Tasa de impuesto";
            taxRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            taxRateDataGridViewTextBoxColumn.Name = "taxRateDataGridViewTextBoxColumn";
            taxRateDataGridViewTextBoxColumn.ReadOnly = true;
            taxRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // taxSumDataGridViewTextBoxColumn
            // 
            taxSumDataGridViewTextBoxColumn.DataPropertyName = "TaxSum";
            taxSumDataGridViewTextBoxColumn.HeaderText = "Total de impuesto";
            taxSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            taxSumDataGridViewTextBoxColumn.Name = "taxSumDataGridViewTextBoxColumn";
            taxSumDataGridViewTextBoxColumn.ReadOnly = true;
            taxSumDataGridViewTextBoxColumn.Width = 125;
            // 
            // netAmountDataGridViewTextBoxColumn
            // 
            netAmountDataGridViewTextBoxColumn.DataPropertyName = "NetAmount";
            netAmountDataGridViewTextBoxColumn.HeaderText = "Importe neto";
            netAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            netAmountDataGridViewTextBoxColumn.Name = "netAmountDataGridViewTextBoxColumn";
            netAmountDataGridViewTextBoxColumn.ReadOnly = true;
            netAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            commentDataGridViewTextBoxColumn.HeaderText = "Comentario";
            commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            commentDataGridViewTextBoxColumn.ReadOnly = true;
            commentDataGridViewTextBoxColumn.Width = 125;
            // 
            // products_id_textBox1
            // 
            products_id_textBox1.BorderStyle = BorderStyle.FixedSingle;
            products_id_textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "ProductId", true));
            products_id_textBox1.Location = new Point(684, 170);
            products_id_textBox1.Name = "products_id_textBox1";
            products_id_textBox1.ReadOnly = true;
            products_id_textBox1.Size = new Size(105, 30);
            products_id_textBox1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(555, 172);
            label7.Name = "label7";
            label7.Size = new Size(132, 23);
            label7.TabIndex = 11;
            label7.Text = "Id del Producto:";
            // 
            // salesInvoiceProductsTableAdapter1
            // 
            salesInvoiceProductsTableAdapter1.ClearBeforeFill = true;
            // 
            // FacturasVentasProdFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 773);
            Controls.Add(products_id_textBox1);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FacturasVentasProdFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Productos";
            Load += FacturasVentasProdFrm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)net_amount_numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDataSet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tax_sum_numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tax_rate_numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)amount_numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)discount_numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)price_numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)qty_numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label9;
        private Label label8;
        private NumericUpDown price_numericUpDown2;
        private NumericUpDown qty_numericUpDown1;
        private Button cu_search_button1;
        private TextBox comment_textBox6;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox product_name_textBox3;
        private Label label3;
        private TextBox id_textBox1;
        private Label label1;
        private Panel panel1;
        private Label reg_time_label14;
        private Label reg_time_label15;
        private Label reg_date_label12;
        private Label reg_date_label13;
        private Label reg_user_label11;
        private Label reg_user_label10;
        private DataGridView dataGridView1;
        private TextBox invoice_id_textBox1;
        private Label label2;
        private TextBox products_id_textBox1;
        private Label label7;
        private TextBox unit_textBox1;
        private Label label10;
        private Label label11;
        private NumericUpDown discount_numericUpDown1;
        private Label label12;
        private Label label13;
        private NumericUpDown amount_numericUpDown1;
        private Label label14;
        private Label label15;
        private NumericUpDown tax_rate_numericUpDown1;
        private Label label16;
        private Label label17;
        private NumericUpDown tax_sum_numericUpDown1;
        private Label label18;
        private Label label19;
        private NumericUpDown net_amount_numericUpDown1;
        private Label label20;
        private DataSet.AccDataSet accDataSet1;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxSumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn netAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataSet.AccDataSetTableAdapters.SalesInvoiceProductsTableAdapter salesInvoiceProductsTableAdapter1;
    }
}