namespace SoftwareDeContabilidad.Contabilidad
{
    partial class BuscarClienteFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarClienteFrm));
            search_panel2 = new Panel();
            search_lname_button2 = new Button();
            search_id_button1 = new Button();
            search_lname_textBox2 = new TextBox();
            search_id_textBox1 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            customersTableAdapter1 = new SoftwareDeContabilidad.DataSet.AccDataSetTableAdapters.CustomersTableAdapter();
            accDataSet1 = new SoftwareDeContabilidad.DataSet.AccDataSet();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            landLineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cellNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            lname_label6 = new Label();
            fname_label5 = new Label();
            id_label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            ok_button = new Button();
            cancel_button2 = new Button();
            show_all_button1 = new Button();
            search_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accDataSet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // search_panel2
            // 
            search_panel2.Controls.Add(search_lname_button2);
            search_panel2.Controls.Add(search_id_button1);
            search_panel2.Controls.Add(search_lname_textBox2);
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
            // search_lname_textBox2
            // 
            search_lname_textBox2.Location = new Point(553, 29);
            search_lname_textBox2.Name = "search_lname_textBox2";
            search_lname_textBox2.Size = new Size(81, 30);
            search_lname_textBox2.TabIndex = 9;
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
            label11.Location = new Point(480, 31);
            label11.Name = "label11";
            label11.Size = new Size(76, 23);
            label11.TabIndex = 7;
            label11.Text = "Apellido:";
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
            // customersTableAdapter1
            // 
            customersTableAdapter1.ClearBeforeFill = true;
            // 
            // accDataSet1
            // 
            accDataSet1.DataSetName = "AccDataSet";
            accDataSet1.Namespace = "http://tempuri.org/AccDataSet.xsd";
            accDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "Customers";
            bindingSource1.DataSource = accDataSet1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, landLineDataGridViewTextBoxColumn, cellNumDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn });
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
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // landLineDataGridViewTextBoxColumn
            // 
            landLineDataGridViewTextBoxColumn.DataPropertyName = "LandLine";
            landLineDataGridViewTextBoxColumn.HeaderText = "LandLine";
            landLineDataGridViewTextBoxColumn.MinimumWidth = 6;
            landLineDataGridViewTextBoxColumn.Name = "landLineDataGridViewTextBoxColumn";
            landLineDataGridViewTextBoxColumn.ReadOnly = true;
            landLineDataGridViewTextBoxColumn.Width = 125;
            // 
            // cellNumDataGridViewTextBoxColumn
            // 
            cellNumDataGridViewTextBoxColumn.DataPropertyName = "CellNum";
            cellNumDataGridViewTextBoxColumn.HeaderText = "CellNum";
            cellNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            cellNumDataGridViewTextBoxColumn.Name = "cellNumDataGridViewTextBoxColumn";
            cellNumDataGridViewTextBoxColumn.ReadOnly = true;
            cellNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Width = 125;
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
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lname_label6);
            panel1.Controls.Add(fname_label5);
            panel1.Controls.Add(id_label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 303);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 47);
            panel1.TabIndex = 7;
            // 
            // lname_label6
            // 
            lname_label6.DataBindings.Add(new Binding("Text", bindingSource1, "LastName", true));
            lname_label6.Location = new Point(480, 12);
            lname_label6.Name = "lname_label6";
            lname_label6.Size = new Size(184, 23);
            lname_label6.TabIndex = 11;
            lname_label6.Text = "0";
            // 
            // fname_label5
            // 
            fname_label5.DataBindings.Add(new Binding("Text", bindingSource1, "FirstName", true));
            fname_label5.Location = new Point(260, 12);
            fname_label5.Name = "fname_label5";
            fname_label5.Size = new Size(150, 23);
            fname_label5.TabIndex = 10;
            fname_label5.Text = "0";
            // 
            // id_label4
            // 
            id_label4.DataBindings.Add(new Binding("Text", bindingSource1, "ID", true));
            id_label4.Location = new Point(54, 12);
            id_label4.Name = "id_label4";
            id_label4.Size = new Size(117, 23);
            id_label4.TabIndex = 9;
            id_label4.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 12);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 8;
            label3.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 12);
            label2.Name = "label2";
            label2.Size = new Size(29, 23);
            label2.TabIndex = 6;
            label2.Text = "Id:";
            // 
            // ok_button
            // 
            ok_button.Image = (Image)resources.GetObject("ok_button.Image");
            ok_button.Location = new Point(18, 356);
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
            // BuscarClienteFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 418);
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
            Name = "BuscarClienteFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Cliente";
            Load += BuscarClienteFrm_Load;
            search_panel2.ResumeLayout(false);
            search_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accDataSet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel search_panel2;
        private Button search_lname_button2;
        private Button search_id_button1;
        private TextBox search_lname_textBox2;
        private TextBox search_id_textBox1;
        private Label label11;
        private Label label10;
        private DataSet.AccDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private DataSet.AccDataSet accDataSet1;
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn landLineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cellNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ok_button;
        private Button cancel_button2;
        public Label id_label4;
        public Label lname_label6;
        public Label fname_label5;
        private Button show_all_button1;
    }
}