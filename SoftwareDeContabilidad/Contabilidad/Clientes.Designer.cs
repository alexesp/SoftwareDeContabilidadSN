namespace SoftwareDeContabilidad.Contabilidad
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
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
            comboBox1 = new ComboBox();
            bindingSource1 = new BindingSource(components);
            accDataSet1 = new SoftwareDeContabilidad.DataSet.AccDataSet();
            comment_textBox9 = new TextBox();
            label9 = new Label();
            direc_textBox8 = new TextBox();
            label8 = new Label();
            email_textBox7 = new TextBox();
            label7 = new Label();
            mobil_textBox6 = new TextBox();
            label6 = new Label();
            telefono_textBox5 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            second_name_textBox3 = new TextBox();
            label3 = new Label();
            first_name_textBox2 = new TextBox();
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
            reg_time_label14 = new Label();
            reg_time_label15 = new Label();
            reg_date_label12 = new Label();
            reg_date_label13 = new Label();
            reg_user_label11 = new Label();
            reg_user_label10 = new Label();
            customersTableAdapter1 = new SoftwareDeContabilidad.DataSet.AccDataSetTableAdapters.CustomersTableAdapter();
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
            toolStrip1.TabIndex = 0;
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
            del_butt.Click += del_butt_Click;
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
            search_butt.Click += search_butt_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 54);
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comment_textBox9);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(direc_textBox8);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(email_textBox7);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(mobil_textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(telefono_textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(second_name_textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(first_name_textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(id_textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 404);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion";
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Gender", true));
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Hombre", "Mujer" });
            comboBox1.Location = new Point(194, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(316, 31);
            comboBox1.TabIndex = 18;
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "Customers";
            bindingSource1.DataSource = accDataSet1;
            // 
            // accDataSet1
            // 
            accDataSet1.DataSetName = "AccDataSet";
            accDataSet1.Namespace = "http://tempuri.org/AccDataSet.xsd";
            accDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comment_textBox9
            // 
            comment_textBox9.DataBindings.Add(new Binding("Text", bindingSource1, "Comment", true));
            comment_textBox9.Location = new Point(194, 323);
            comment_textBox9.Name = "comment_textBox9";
            comment_textBox9.Size = new Size(557, 30);
            comment_textBox9.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(90, 330);
            label9.Name = "label9";
            label9.Size = new Size(104, 23);
            label9.TabIndex = 16;
            label9.Text = "Comentario:";
            // 
            // direc_textBox8
            // 
            direc_textBox8.DataBindings.Add(new Binding("Text", bindingSource1, "Address", true));
            direc_textBox8.Location = new Point(194, 287);
            direc_textBox8.Name = "direc_textBox8";
            direc_textBox8.Size = new Size(557, 30);
            direc_textBox8.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 294);
            label8.Name = "label8";
            label8.Size = new Size(85, 23);
            label8.TabIndex = 14;
            label8.Text = "Direccion:";
            // 
            // email_textBox7
            // 
            email_textBox7.DataBindings.Add(new Binding("Text", bindingSource1, "Email", true));
            email_textBox7.Location = new Point(194, 251);
            email_textBox7.Name = "email_textBox7";
            email_textBox7.Size = new Size(316, 30);
            email_textBox7.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 258);
            label7.Name = "label7";
            label7.Size = new Size(55, 23);
            label7.TabIndex = 12;
            label7.Text = "Email:";
            // 
            // mobil_textBox6
            // 
            mobil_textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "CellNum", true));
            mobil_textBox6.Location = new Point(194, 215);
            mobil_textBox6.Name = "mobil_textBox6";
            mobil_textBox6.Size = new Size(316, 30);
            mobil_textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 222);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 10;
            label6.Text = "Telefono:";
            // 
            // telefono_textBox5
            // 
            telefono_textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "LandLine", true));
            telefono_textBox5.Location = new Point(194, 182);
            telefono_textBox5.Name = "telefono_textBox5";
            telefono_textBox5.Size = new Size(316, 30);
            telefono_textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 189);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 8;
            label5.Text = "Telefono fijo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 153);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 6;
            label4.Text = "Genero:";
            // 
            // second_name_textBox3
            // 
            second_name_textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "LastName", true));
            second_name_textBox3.Location = new Point(194, 110);
            second_name_textBox3.Name = "second_name_textBox3";
            second_name_textBox3.Size = new Size(316, 30);
            second_name_textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 117);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 4;
            label3.Text = "Apellido:";
            // 
            // first_name_textBox2
            // 
            first_name_textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "FirstName", true));
            first_name_textBox2.Location = new Point(194, 74);
            first_name_textBox2.Name = "first_name_textBox2";
            first_name_textBox2.Size = new Size(316, 30);
            first_name_textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 81);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // id_textBox1
            // 
            id_textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "ID", true));
            id_textBox1.Location = new Point(194, 38);
            id_textBox1.Name = "id_textBox1";
            id_textBox1.ReadOnly = true;
            id_textBox1.Size = new Size(316, 30);
            id_textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 45);
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
            search_panel2.Location = new Point(537, 61);
            search_panel2.Name = "search_panel2";
            search_panel2.Size = new Size(250, 125);
            search_panel2.TabIndex = 4;
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
            search_lname_button2.Click += search_lname_button2_Click;
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
            search_id_button1.Click += search_id_button1_Click_1;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, landLineDataGridViewTextBoxColumn, cellNumDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(12, 479);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 144);
            dataGridView1.TabIndex = 2;
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
            panel1.TabIndex = 3;
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
            // customersTableAdapter1
            // 
            customersTableAdapter1.ClearBeforeFill = true;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 670);
            Controls.Add(search_panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += Clientes_Load;
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
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
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
        private TextBox id_textBox1;
        private Label label1;
        private TextBox first_name_textBox2;
        private Label label2;
        private Label label4;
        private TextBox second_name_textBox3;
        private Label label3;
        private TextBox telefono_textBox5;
        private Label label5;
        private TextBox mobil_textBox6;
        private Label label6;
        private TextBox email_textBox7;
        private Label label7;
        private TextBox comment_textBox9;
        private Label label9;
        private TextBox direc_textBox8;
        private Label label8;
        private Label reg_user_label10;
        private Label reg_user_label11;
        private Label reg_date_label12;
        private Label reg_date_label13;
        private Label reg_time_label14;
        private Label reg_time_label15;
        private DataSet.AccDataSet accDataSet1;
        private BindingSource bindingSource1;
        private ComboBox comboBox1;
        private DataSet.AccDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private ToolStripButton search_butt;
        private ToolStripSeparator toolStripSeparator6;
        private Panel search_panel2;
        private Button search_lname_button2;
        private Button search_id_button1;
        private TextBox search_lname_textBox2;
        private TextBox search_id_textBox1;
        private Label label11;
        private Label label10;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn landLineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cellNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}