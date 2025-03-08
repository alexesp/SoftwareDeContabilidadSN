namespace SoftwareDeContabilidad.Contabilidad
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
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
            unit_textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            accDataSet1 = new SoftwareDeContabilidad.DataSet.AccDataSet();
            comment_textBox7 = new TextBox();
            label7 = new Label();
            discount_textBox6 = new TextBox();
            label6 = new Label();
            price_textBox5 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            ini_qty_textBox3 = new TextBox();
            label3 = new Label();
            product_name_textBox2 = new TextBox();
            label2 = new Label();
            id_textBox1 = new TextBox();
            label1 = new Label();
            search_panel2 = new Panel();
            search_lname_button2 = new Button();
            search_id_button1 = new Button();
            search_lname_textBox2 = new TextBox();
            search_id_textBox1 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            reg_time_label14 = new Label();
            reg_time_label15 = new Label();
            reg_date_label12 = new Label();
            reg_date_label13 = new Label();
            reg_user_label11 = new Label();
            reg_user_label10 = new Label();
            productsTableAdapter1 = new SoftwareDeContabilidad.DataSet.AccDataSetTableAdapters.ProductsTableAdapter();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            initialQtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDataSet1).BeginInit();
            search_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // new_butt
            // 
            new_butt.AutoSize = false;
            new_butt.Image = (Image)resources.GetObject("new_butt.Image");
            new_butt.ImageScaling = ToolStripItemImageScaling.None;
            new_butt.ImageTransparentColor = Color.Magenta;
            new_butt.Name = "new_butt";
            new_butt.Size = new Size(90, 51);
            new_butt.Text = "Nuevo";
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
            groupBox1.Controls.Add(unit_textBox1);
            groupBox1.Controls.Add(comment_textBox7);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(discount_textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(price_textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ini_qty_textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(product_name_textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(id_textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 404);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion";
            // 
            // unit_textBox1
            // 
            unit_textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Unit", true));
            unit_textBox1.Location = new Point(194, 146);
            unit_textBox1.Name = "unit_textBox1";
            unit_textBox1.Size = new Size(316, 30);
            unit_textBox1.TabIndex = 18;
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "Products";
            bindingSource1.DataSource = accDataSet1;
            // 
            // accDataSet1
            // 
            accDataSet1.DataSetName = "AccDataSet";
            accDataSet1.Namespace = "http://tempuri.org/AccDataSet.xsd";
            accDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comment_textBox7
            // 
            comment_textBox7.DataBindings.Add(new Binding("Text", bindingSource1, "Comment", true));
            comment_textBox7.Location = new Point(194, 251);
            comment_textBox7.Name = "comment_textBox7";
            comment_textBox7.Size = new Size(316, 30);
            comment_textBox7.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 258);
            label7.Name = "label7";
            label7.Size = new Size(104, 23);
            label7.TabIndex = 12;
            label7.Text = "Comentario:";
            // 
            // discount_textBox6
            // 
            discount_textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "Discount", true));
            discount_textBox6.Location = new Point(194, 215);
            discount_textBox6.Name = "discount_textBox6";
            discount_textBox6.Size = new Size(316, 30);
            discount_textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 222);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 10;
            label6.Text = "Descuento:";
            // 
            // price_textBox5
            // 
            price_textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "Price", true));
            price_textBox5.Location = new Point(194, 182);
            price_textBox5.Name = "price_textBox5";
            price_textBox5.Size = new Size(316, 30);
            price_textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 189);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 8;
            label5.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 153);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 6;
            label4.Text = "Unidad:";
            // 
            // ini_qty_textBox3
            // 
            ini_qty_textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "InitialQty", true));
            ini_qty_textBox3.Location = new Point(194, 110);
            ini_qty_textBox3.Name = "ini_qty_textBox3";
            ini_qty_textBox3.Size = new Size(316, 30);
            ini_qty_textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 117);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 4;
            label3.Text = "Cantidad inicial:";
            // 
            // product_name_textBox2
            // 
            product_name_textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "ProductName", true));
            product_name_textBox2.Location = new Point(194, 74);
            product_name_textBox2.Name = "product_name_textBox2";
            product_name_textBox2.Size = new Size(316, 30);
            product_name_textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 81);
            label2.Name = "label2";
            label2.Size = new Size(180, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombre del producto:";
            // 
            // id_textBox1
            // 
            id_textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "ProductId", true));
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
            label1.Size = new Size(29, 23);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // search_panel2
            // 
            search_panel2.Controls.Add(search_lname_button2);
            search_panel2.Controls.Add(search_id_button1);
            search_panel2.Controls.Add(search_lname_textBox2);
            search_panel2.Controls.Add(search_id_textBox1);
            search_panel2.Controls.Add(label11);
            search_panel2.Controls.Add(label10);
            search_panel2.Location = new Point(538, 70);
            search_panel2.Name = "search_panel2";
            search_panel2.Size = new Size(250, 125);
            search_panel2.TabIndex = 5;
            search_panel2.Visible = false;
            // 
            // search_lname_button2
            // 
            search_lname_button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_lname_button2.Location = new Point(172, 69);
            search_lname_button2.Name = "search_lname_button2";
            search_lname_button2.Size = new Size(65, 33);
            search_lname_button2.TabIndex = 11;
            search_lname_button2.Text = "Buscar";
            search_lname_button2.TextAlign = ContentAlignment.MiddleLeft;
            search_lname_button2.UseVisualStyleBackColor = true;
            // 
            // search_id_button1
            // 
            search_id_button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_id_button1.Location = new Point(173, 21);
            search_id_button1.Name = "search_id_button1";
            search_id_button1.Size = new Size(65, 33);
            search_id_button1.TabIndex = 10;
            search_id_button1.Text = "Buscar";
            search_id_button1.TextAlign = ContentAlignment.MiddleLeft;
            search_id_button1.UseVisualStyleBackColor = true;
            // 
            // search_lname_textBox2
            // 
            search_lname_textBox2.Location = new Point(85, 73);
            search_lname_textBox2.Name = "search_lname_textBox2";
            search_lname_textBox2.Size = new Size(81, 30);
            search_lname_textBox2.TabIndex = 9;
            // 
            // search_id_textBox1
            // 
            search_id_textBox1.Location = new Point(85, 23);
            search_id_textBox1.Name = "search_id_textBox1";
            search_id_textBox1.Size = new Size(81, 30);
            search_id_textBox1.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 75);
            label11.Name = "label11";
            label11.Size = new Size(76, 23);
            label11.TabIndex = 7;
            label11.Text = "Apellido:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 26);
            label10.Name = "label10";
            label10.Size = new Size(29, 23);
            label10.TabIndex = 6;
            label10.Text = "Id:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, initialQtyDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(12, 378);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 250);
            dataGridView1.TabIndex = 6;
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
            panel1.TabIndex = 7;
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
            // productsTableAdapter1
            // 
            productsTableAdapter1.ClearBeforeFill = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // initialQtyDataGridViewTextBoxColumn
            // 
            initialQtyDataGridViewTextBoxColumn.DataPropertyName = "InitialQty";
            initialQtyDataGridViewTextBoxColumn.HeaderText = "InitialQty";
            initialQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            initialQtyDataGridViewTextBoxColumn.Name = "initialQtyDataGridViewTextBoxColumn";
            initialQtyDataGridViewTextBoxColumn.ReadOnly = true;
            initialQtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.ReadOnly = true;
            unitDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            discountDataGridViewTextBoxColumn.ReadOnly = true;
            discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            commentDataGridViewTextBoxColumn.ReadOnly = true;
            commentDataGridViewTextBoxColumn.Width = 125;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 670);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(search_panel2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Productos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDataSet1).EndInit();
            search_panel2.ResumeLayout(false);
            search_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox comment_textBox7;
        private Label label7;
        private TextBox discount_textBox6;
        private Label label6;
        private TextBox price_textBox5;
        private Label label5;
        private Label label4;
        private TextBox ini_qty_textBox3;
        private Label label3;
        private TextBox product_name_textBox2;
        private Label label2;
        private TextBox id_textBox1;
        private Label label1;
        private Panel search_panel2;
        private Button search_lname_button2;
        private Button search_id_button1;
        private TextBox search_lname_textBox2;
        private TextBox search_id_textBox1;
        private Label label11;
        private Label label10;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label reg_time_label14;
        private Label reg_time_label15;
        private Label reg_date_label12;
        private Label reg_date_label13;
        private Label reg_user_label11;
        private Label reg_user_label10;
        private DataSet.AccDataSet accDataSet1;
        private BindingSource bindingSource1;
        private DataSet.AccDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private TextBox unit_textBox1;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn initialQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}