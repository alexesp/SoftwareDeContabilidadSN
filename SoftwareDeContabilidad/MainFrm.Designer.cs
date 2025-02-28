namespace SoftwareDeContabilidad
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            TreeNode treeNode10 = new TreeNode("Clientes");
            TreeNode treeNode11 = new TreeNode("Facturas de ventas");
            TreeNode treeNode12 = new TreeNode("Facturas de compras");
            TreeNode treeNode13 = new TreeNode("Facturas", new TreeNode[] { treeNode11, treeNode12 });
            TreeNode treeNode14 = new TreeNode("Gastos");
            TreeNode treeNode15 = new TreeNode("Ingresos");
            TreeNode treeNode16 = new TreeNode("Pagos", new TreeNode[] { treeNode14, treeNode15 });
            TreeNode treeNode17 = new TreeNode("Resumen de gastos");
            TreeNode treeNode18 = new TreeNode("Todas las herramientas", new TreeNode[] { treeNode10, treeNode13, treeNode16, treeNode17 });
            top_panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            info_button2 = new Button();
            cont_button1 = new Button();
            close_button1 = new Button();
            min_button1 = new Button();
            bott_panel2 = new Panel();
            date_time_label3 = new Label();
            label2 = new Label();
            user_label2 = new Label();
            user_pictureBox1 = new PictureBox();
            background_comboBox1 = new ComboBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            top_panel1.SuspendLayout();
            bott_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // top_panel1
            // 
            top_panel1.BackgroundImage = Properties.Resources.butt_background;
            top_panel1.BackgroundImageLayout = ImageLayout.Stretch;
            top_panel1.Controls.Add(button2);
            top_panel1.Controls.Add(button1);
            top_panel1.Controls.Add(info_button2);
            top_panel1.Controls.Add(cont_button1);
            top_panel1.Controls.Add(close_button1);
            top_panel1.Controls.Add(min_button1);
            top_panel1.Dock = DockStyle.Top;
            top_panel1.Location = new Point(0, 0);
            top_panel1.Name = "top_panel1";
            top_panel1.Size = new Size(893, 87);
            top_panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.butt_background;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.top_Help_butt;
            button2.Location = new Point(504, 8);
            button2.Name = "button2";
            button2.Size = new Size(162, 70);
            button2.TabIndex = 5;
            button2.Text = "Ayuda F5";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.butt_background;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.top_Tools_butt;
            button1.Location = new Point(336, 8);
            button1.Name = "button1";
            button1.Size = new Size(162, 70);
            button1.TabIndex = 4;
            button1.Text = "Herramientas F4";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // info_button2
            // 
            info_button2.BackgroundImage = Properties.Resources.butt_background;
            info_button2.BackgroundImageLayout = ImageLayout.Stretch;
            info_button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            info_button2.Image = Properties.Resources.top_report_butt;
            info_button2.Location = new Point(174, 8);
            info_button2.Name = "info_button2";
            info_button2.Size = new Size(156, 70);
            info_button2.TabIndex = 3;
            info_button2.Text = "Informes F3";
            info_button2.TextImageRelation = TextImageRelation.ImageAboveText;
            info_button2.UseVisualStyleBackColor = true;
            // 
            // cont_button1
            // 
            cont_button1.BackgroundImage = Properties.Resources.butt_background;
            cont_button1.BackgroundImageLayout = ImageLayout.Stretch;
            cont_button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cont_button1.Image = Properties.Resources.top_input_butt;
            cont_button1.Location = new Point(12, 8);
            cont_button1.Name = "cont_button1";
            cont_button1.Size = new Size(156, 70);
            cont_button1.TabIndex = 2;
            cont_button1.Text = "Contabilidad F2";
            cont_button1.TextImageRelation = TextImageRelation.ImageAboveText;
            cont_button1.UseVisualStyleBackColor = true;
            // 
            // close_button1
            // 
            close_button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_button1.Image = (Image)resources.GetObject("close_button1.Image");
            close_button1.Location = new Point(857, 12);
            close_button1.Name = "close_button1";
            close_button1.Size = new Size(28, 28);
            close_button1.TabIndex = 0;
            close_button1.UseVisualStyleBackColor = true;
            close_button1.Click += close_button1_Click;
            // 
            // min_button1
            // 
            min_button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            min_button1.Image = Properties.Resources.min_butt;
            min_button1.Location = new Point(827, 12);
            min_button1.Name = "min_button1";
            min_button1.Size = new Size(28, 28);
            min_button1.TabIndex = 0;
            min_button1.UseVisualStyleBackColor = true;
            min_button1.Click += min_button1_Click;
            // 
            // bott_panel2
            // 
            bott_panel2.Controls.Add(date_time_label3);
            bott_panel2.Controls.Add(label2);
            bott_panel2.Controls.Add(user_label2);
            bott_panel2.Controls.Add(user_pictureBox1);
            bott_panel2.Controls.Add(background_comboBox1);
            bott_panel2.Controls.Add(label1);
            bott_panel2.Dock = DockStyle.Bottom;
            bott_panel2.Location = new Point(0, 645);
            bott_panel2.Name = "bott_panel2";
            bott_panel2.Size = new Size(893, 69);
            bott_panel2.TabIndex = 1;
            // 
            // date_time_label3
            // 
            date_time_label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_time_label3.Location = new Point(561, 6);
            date_time_label3.Name = "date_time_label3";
            date_time_label3.Size = new Size(324, 40);
            date_time_label3.TabIndex = 5;
            date_time_label3.Text = "-";
            date_time_label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(525, 6);
            label2.Name = "label2";
            label2.Size = new Size(30, 40);
            label2.TabIndex = 4;
            label2.Text = "-";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // user_label2
            // 
            user_label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_label2.Location = new Point(401, 6);
            user_label2.Name = "user_label2";
            user_label2.Size = new Size(108, 40);
            user_label2.TabIndex = 3;
            user_label2.Text = "-";
            user_label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // user_pictureBox1
            // 
            user_pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            user_pictureBox1.Location = new Point(336, 0);
            user_pictureBox1.Name = "user_pictureBox1";
            user_pictureBox1.Size = new Size(59, 46);
            user_pictureBox1.TabIndex = 2;
            user_pictureBox1.TabStop = false;
            // 
            // background_comboBox1
            // 
            background_comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            background_comboBox1.FormattingEnabled = true;
            background_comboBox1.Items.AddRange(new object[] { "Imagen 1", "Imagen 2", "Imagen 3", "Imagen 4", "Imagen 5", "Imagen 6" });
            background_comboBox1.Location = new Point(150, 11);
            background_comboBox1.Name = "background_comboBox1";
            background_comboBox1.Size = new Size(180, 31);
            background_comboBox1.TabIndex = 1;
            background_comboBox1.SelectedIndexChanged += background_comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 0;
            label1.Text = "Color del fondo:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(treeView1);
            panel1.Location = new Point(12, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 456);
            panel1.TabIndex = 2;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Indent = 40;
            treeView1.ItemHeight = 40;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode10.Name = "Clientes";
            treeNode10.Text = "Clientes";
            treeNode11.Name = "Facturas_de_ventas";
            treeNode11.Text = "Facturas de ventas";
            treeNode12.Name = "Facturas_de_compras";
            treeNode12.Text = "Facturas de compras";
            treeNode13.Name = "Facturas";
            treeNode13.Text = "Facturas";
            treeNode14.Name = "Gastos";
            treeNode14.Text = "Gastos";
            treeNode15.Name = "Ingresos";
            treeNode15.Text = "Ingresos";
            treeNode16.Name = "Pagos";
            treeNode16.Text = "Pagos";
            treeNode17.Name = "Resumen_de_gastos";
            treeNode17.Text = "Resumen de gastos";
            treeNode18.Name = "Root";
            treeNode18.Text = "Todas las herramientas";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode18 });
            treeView1.RightToLeft = RightToLeft.Yes;
            treeView1.Size = new Size(338, 454);
            treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "expand.png");
            imageList1.Images.SetKeyName(1, "products.png");
            imageList1.Images.SetKeyName(2, "tree_customers.png");
            imageList1.Images.SetKeyName(3, "tree_expense.png");
            imageList1.Images.SetKeyName(4, "tree_invoice.png");
            imageList1.Images.SetKeyName(5, "tree_payment.png");
            imageList1.Images.SetKeyName(6, "tree_purchase_bill.png");
            imageList1.Images.SetKeyName(7, "tree_receive.png");
            imageList1.Images.SetKeyName(8, "tree_reports.png");
            imageList1.Images.SetKeyName(9, "tree_root.png");
            imageList1.Images.SetKeyName(10, "tree_sale_invoice.png");
            imageList1.Images.SetKeyName(11, "tree_spend.png");
            imageList1.Images.SetKeyName(12, "collapse.png");
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(893, 714);
            Controls.Add(panel1);
            Controls.Add(bott_panel2);
            Controls.Add(top_panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contabilidad";
            WindowState = FormWindowState.Maximized;
            Load += MainFrm_Load;
            top_panel1.ResumeLayout(false);
            bott_panel2.ResumeLayout(false);
            bott_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)user_pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel top_panel1;
        private Panel bott_panel2;
        private Button min_button1;
        private Button close_button1;
        private Button cont_button1;
        private Button info_button2;
        private Button button1;
        private Button button2;
        private ComboBox background_comboBox1;
        private Label label1;
        private Label user_label2;
        private PictureBox user_pictureBox1;
        private Label label2;
        private Label date_time_label3;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private TreeView treeView1;
        private ImageList imageList1;
    }
}