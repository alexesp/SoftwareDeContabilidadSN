namespace SoftwareDeContabilidad.Contabilidad
{
    partial class BuscarProductFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProductFrm));
            search_panel2 = new Panel();
            search_lname_button2 = new Button();
            search_id_button1 = new Button();
            search_Prodname_textBox2 = new TextBox();
            search_id_textBox1 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            accDataSet1 = new SoftwareDeContabilidad.DataSet.AccDataSet();
            panel1 = new Panel();
            label1 = new Label();
            ProductName_label5 = new Label();
            id_label4 = new Label();
            label2 = new Label();
            ok_button = new Button();
            cancel_button2 = new Button();
            show_all_button1 = new Button();
            productsTableAdapter1 = new SoftwareDeContabilidad.DataSet.AccDataSetTableAdapters.ProductsTableAdapter();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            initialQtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            search_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDataSet1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // search_panel2
            // 
            search_panel2.Controls.Add(search_lname_button2);
            search_panel2.Controls.Add(search_id_button1);
            search_panel2.Controls.Add(search_Prodname_textBox2);
            search_panel2.Controls.Add(search_id_textBox1);
            search_panel2.Controls.Add(label11);
            search_panel2.Controls.Add(label10);
            search_panel2.Location = new Point(12, 12);
            search_panel2.Name = "search_panel2";
            search_panel2.Size = new Size(776, 95);
            search_panel2.TabIndex = 5;
            // 
            // search_lname_button2
            // 
            search_lname_button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_lname_button2.Location = new Point(640, 28);
            search_lname_button2.Name = "search_lname_button2";
            search_lname_button2.Size = new Size(65, 33);
            search_lname_button2.TabIndex = 11;
            search_lname_button2.Text = "Buscar";
            search_lname_button2.TextAlign = ContentAlignment.MiddleLeft;
            search_lname_button2.UseVisualStyleBackColor = true;
            search_lname_button2.Click += search_lname_button2_Click;
            // 
            // search_id_button1
            // 
            search_id_button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_id_button1.Location = new Point(203, 28);
            search_id_button1.Name = "search_id_button1";
            search_id_button1.Size = new Size(65, 33);
            search_id_button1.TabIndex = 10;
            search_id_button1.Text = "Buscar";
            search_id_button1.TextAlign = ContentAlignment.MiddleLeft;
            search_id_button1.UseVisualStyleBackColor = true;
            search_id_button1.Click += search_id_button1_Click;
            // 
            // search_Prodname_textBox2
            // 
            search_Prodname_textBox2.Location = new Point(553, 29);
            search_Prodname_textBox2.Name = "search_Prodname_textBox2";
            search_Prodname_textBox2.Size = new Size(81, 30);
            search_Prodname_textBox2.TabIndex = 9;
            // 
            // search_id_textBox1
            // 
            search_id_textBox1.Location = new Point(115, 28);
            search_id_textBox1.Name = "search_id_textBox1";
            search_id_textBox1.Size = new Size(81, 30);
            search_id_textBox1.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(371, 32);
            label11.Name = "label11";
            label11.Size = new Size(176, 23);
            label11.TabIndex = 7;
            label11.Text = "Nombre de Producto:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 31);
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
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, initialQtyDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(12, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 184);
            dataGridView1.TabIndex = 6;
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
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ProductName_label5);
            panel1.Controls.Add(id_label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 303);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 47);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 12);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 12;
            label1.Text = "Nombre de Producto:";
            // 
            // ProductName_label5
            // 
            ProductName_label5.DataBindings.Add(new Binding("Text", bindingSource1, "ProductName", true));
            ProductName_label5.Location = new Point(421, 12);
            ProductName_label5.Name = "ProductName_label5";
            ProductName_label5.Size = new Size(341, 23);
            ProductName_label5.TabIndex = 10;
            ProductName_label5.Text = "0";
            // 
            // id_label4
            // 
            id_label4.DataBindings.Add(new Binding("Text", bindingSource1, "ProductId", true));
            id_label4.Location = new Point(38, 12);
            id_label4.Name = "id_label4";
            id_label4.Size = new Size(158, 23);
            id_label4.TabIndex = 9;
            id_label4.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(29, 23);
            label2.TabIndex = 6;
            label2.Text = "Id:";
            // 
            // ok_button
            // 
            ok_button.Image = (Image)resources.GetObject("ok_button.Image");
            ok_button.Location = new Point(12, 357);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(108, 49);
            ok_button.TabIndex = 8;
            ok_button.Text = "OK";
            ok_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            ok_button.UseVisualStyleBackColor = true;
            ok_button.Click += ok_button_Click;
            // 
            // cancel_button2
            // 
            cancel_button2.Image = (Image)resources.GetObject("cancel_button2.Image");
            cancel_button2.Location = new Point(159, 357);
            cancel_button2.Name = "cancel_button2";
            cancel_button2.Size = new Size(108, 49);
            cancel_button2.TabIndex = 9;
            cancel_button2.Text = "Cancelar";
            cancel_button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            cancel_button2.UseVisualStyleBackColor = true;
            cancel_button2.Click += cancel_button2_Click;
            // 
            // show_all_button1
            // 
            show_all_button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            show_all_button1.Image = Properties.Resources.top_input_butt;
            show_all_button1.Location = new Point(675, 358);
            show_all_button1.Name = "show_all_button1";
            show_all_button1.Size = new Size(113, 49);
            show_all_button1.TabIndex = 12;
            show_all_button1.Text = "Mostrar todo";
            show_all_button1.TextAlign = ContentAlignment.MiddleLeft;
            show_all_button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            show_all_button1.UseVisualStyleBackColor = true;
            show_all_button1.Click += show_all_button1_Click;
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
            // BuscarProductFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(788, 410);
            ControlBox = false;
            Controls.Add(show_all_button1);
            Controls.Add(cancel_button2);
            Controls.Add(ok_button);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(search_panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BuscarProductFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Cliente";
            Load += BuscarClienteFrm_Load;
            search_panel2.ResumeLayout(false);
            search_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDataSet1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel search_panel2;
        private Button search_lname_button2;
        private Button search_id_button1;
        private Label label11;
        private Label label10;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label2;
        private Button ok_button;
        private Button cancel_button2;
        public Label id_label4;
        public Label ProductName_label5;
        private Button show_all_button1;
        private DataSet.AccDataSet accDataSet1;
        private BindingSource bindingSource1;
        private Label label1;
        private DataSet.AccDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        public TextBox search_id_textBox1;
        public TextBox search_Prodname_textBox2;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn initialQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}