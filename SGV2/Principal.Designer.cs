namespace SGV2
{
    partial class Principal
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
            panelProductList = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            dgvLProductlist = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoría = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            panelSearchBar = new Panel();
            lblOptions = new Button();
            lblPrice = new Label();
            lblName = new Label();
            lblID = new Label();
            txtPrice = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            btnExport = new Button();
            btnImport = new Button();
            button1 = new Button();
            btnContinue = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            lblTotal = new Label();
            lblhora = new Label();
            lblConsumidor = new Label();
            label7 = new Label();
            lblhora2 = new Label();
            hora = new System.Windows.Forms.Timer(components);
            lblTotalPesos = new Label();
            lblProductCount = new Label();
            lblTicketN = new Label();
            lblTicketNº = new Label();
            cmbMedioDePago = new ComboBox();
            lblMedioDePago = new Label();
            panelProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLProductlist).BeginInit();
            panelSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelProductList
            // 
            panelProductList.Anchor = AnchorStyles.None;
            panelProductList.BackColor = Color.FromArgb(18, 138, 255);
            panelProductList.Controls.Add(label4);
            panelProductList.Controls.Add(label5);
            panelProductList.Controls.Add(label6);
            panelProductList.Controls.Add(label1);
            panelProductList.Controls.Add(dgvLProductlist);
            panelProductList.Controls.Add(label2);
            panelProductList.Controls.Add(label3);
            panelProductList.Location = new Point(0, 91);
            panelProductList.Name = "panelProductList";
            panelProductList.Size = new Size(917, 638);
            panelProductList.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(760, 12);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 16;
            label4.Text = "Quitar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(621, 12);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 15;
            label5.Text = "SubTotal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(464, 12);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 14;
            label6.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(325, 12);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 13;
            label1.Text = "Cantidad";
            // 
            // dgvLProductlist
            // 
            dgvLProductlist.Anchor = AnchorStyles.None;
            dgvLProductlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLProductlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLProductlist.ColumnHeadersVisible = false;
            dgvLProductlist.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Categoría, Cantidad, Precio, Subtotal });
            dgvLProductlist.Location = new Point(-97, 36);
            dgvLProductlist.Name = "dgvLProductlist";
            dgvLProductlist.RowHeadersVisible = false;
            dgvLProductlist.RowTemplate.Height = 25;
            dgvLProductlist.ScrollBars = ScrollBars.Vertical;
            dgvLProductlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLProductlist.Size = new Size(1011, 599);
            dgvLProductlist.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Categoría
            // 
            Categoría.HeaderText = "Categoría";
            Categoría.Name = "Categoría";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio U.";
            Precio.Name = "Precio";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(188, 12);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 12;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(75, 12);
            label3.Name = "label3";
            label3.Size = new Size(25, 21);
            label3.TabIndex = 11;
            label3.Text = "ID";
            // 
            // panelSearchBar
            // 
            panelSearchBar.Anchor = AnchorStyles.None;
            panelSearchBar.Controls.Add(lblOptions);
            panelSearchBar.Controls.Add(lblPrice);
            panelSearchBar.Controls.Add(lblName);
            panelSearchBar.Controls.Add(lblID);
            panelSearchBar.Controls.Add(txtPrice);
            panelSearchBar.Controls.Add(txtName);
            panelSearchBar.Controls.Add(txtId);
            panelSearchBar.Controls.Add(btnExport);
            panelSearchBar.Controls.Add(btnImport);
            panelSearchBar.Location = new Point(0, 0);
            panelSearchBar.Name = "panelSearchBar";
            panelSearchBar.Size = new Size(1117, 100);
            panelSearchBar.TabIndex = 1;
            panelSearchBar.Paint += panelSearchBar_Paint;
            // 
            // lblOptions
            // 
            lblOptions.Location = new Point(978, 24);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(56, 56);
            lblOptions.TabIndex = 11;
            lblOptions.UseVisualStyleBackColor = true;
            lblOptions.Click += lblOptions_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(791, 32);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 15);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Precio";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(508, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 9;
            lblName.Text = "Nombre";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(303, 32);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 8;
            lblID.Text = "ID";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(760, 57);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 4;
            txtPrice.TextAlign = HorizontalAlignment.Right;
    
            // 
            // txtName
            // 
            txtName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtName.Location = new Point(370, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(384, 23);
            txtName.TabIndex = 3;
            txtName.TextAlign = HorizontalAlignment.Center;
            txtName.Click += txtName_Click;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // txtId
            // 
            txtId.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtId.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtId.Location = new Point(264, 57);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            // 
            // btnExport
            // 
            btnExport.BackgroundImage = Properties.Resources.export_csv;
            btnExport.BackgroundImageLayout = ImageLayout.Center;
            btnExport.Location = new Point(125, 15);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(48, 65);
            btnExport.TabIndex = 1;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.BackgroundImage = Properties.Resources.import_csv;
            btnImport.BackgroundImageLayout = ImageLayout.Center;
            btnImport.Location = new Point(38, 15);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(50, 65);
            btnImport.TabIndex = 0;
            btnImport.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(181, 41, 41);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(930, 669);
            button1.Name = "button1";
            button1.Size = new Size(48, 48);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.FromArgb(72, 149, 77);
            btnContinue.BackgroundImageLayout = ImageLayout.Center;
            btnContinue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(984, 669);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(121, 48);
            btnContinue.TabIndex = 6;
            btnContinue.Text = "CONTINUAR";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(989, 406);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 21);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "TOTAL";
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Location = new Point(991, 108);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(40, 15);
            lblhora.TabIndex = 9;
            lblhora.Text = "HORA";
            // 
            // lblConsumidor
            // 
            lblConsumidor.AutoSize = true;
            lblConsumidor.Location = new Point(955, 292);
            lblConsumidor.Name = "lblConsumidor";
            lblConsumidor.Size = new Size(131, 15);
            lblConsumidor.TabIndex = 10;
            lblConsumidor.Text = "A CONSUMIDOR FINAL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(966, 320);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 11;
            label7.Text = "CANT. ARTICULOS";
            // 
            // lblhora2
            // 
            lblhora2.AutoSize = true;
            lblhora2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblhora2.Location = new Point(983, 127);
            lblhora2.Name = "lblhora2";
            lblhora2.Size = new Size(48, 25);
            lblhora2.TabIndex = 12;
            lblhora2.Text = "--:--";
            // 
            // hora
            // 
            hora.Enabled = true;
            hora.Tick += hora_Tick;
            // 
            // lblTotalPesos
            // 
            lblTotalPesos.AutoSize = true;
            lblTotalPesos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPesos.ForeColor = Color.FromArgb(64, 64, 64);
            lblTotalPesos.Location = new Point(998, 451);
            lblTotalPesos.Name = "lblTotalPesos";
            lblTotalPesos.Size = new Size(32, 21);
            lblTotalPesos.TabIndex = 13;
            lblTotalPesos.Text = "0.0";
            lblTotalPesos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProductCount
            // 
            lblProductCount.AutoSize = true;
            lblProductCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductCount.ForeColor = Color.FromArgb(64, 64, 64);
            lblProductCount.Location = new Point(1002, 348);
            lblProductCount.Name = "lblProductCount";
            lblProductCount.Size = new Size(19, 21);
            lblProductCount.TabIndex = 14;
            lblProductCount.Text = "0";
            // 
            // lblTicketN
            // 
            lblTicketN.AutoSize = true;
            lblTicketN.Location = new Point(987, 177);
            lblTicketN.Name = "lblTicketN";
            lblTicketN.Size = new Size(55, 15);
            lblTicketN.TabIndex = 15;
            lblTicketN.Text = "Ticket Nº";
            // 
            // lblTicketNº
            // 
            lblTicketNº.AutoSize = true;
            lblTicketNº.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTicketNº.ForeColor = Color.FromArgb(64, 64, 64);
            lblTicketNº.Location = new Point(1002, 218);
            lblTicketNº.Name = "lblTicketNº";
            lblTicketNº.Size = new Size(32, 21);
            lblTicketNº.TabIndex = 16;
            lblTicketNº.Text = "0.0";
            lblTicketNº.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbMedioDePago
            // 
            cmbMedioDePago.FormattingEnabled = true;
            cmbMedioDePago.Items.AddRange(new object[] { "EFECTIVO", "DÉBITO", "CRÉDITO", "TRANSFERENCIA" });
            cmbMedioDePago.Location = new Point(955, 566);
            cmbMedioDePago.Name = "cmbMedioDePago";
            cmbMedioDePago.Size = new Size(121, 23);
            cmbMedioDePago.TabIndex = 17;
            // 
            // lblMedioDePago
            // 
            lblMedioDePago.AutoSize = true;
            lblMedioDePago.Location = new Point(966, 526);
            lblMedioDePago.Name = "lblMedioDePago";
            lblMedioDePago.Size = new Size(95, 15);
            lblMedioDePago.TabIndex = 18;
            lblMedioDePago.Text = "MEDIO DE PAGO";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 729);
            Controls.Add(lblMedioDePago);
            Controls.Add(cmbMedioDePago);
            Controls.Add(lblTicketNº);
            Controls.Add(lblTicketN);
            Controls.Add(lblProductCount);
            Controls.Add(lblTotalPesos);
            Controls.Add(lblhora2);
            Controls.Add(label7);
            Controls.Add(lblConsumidor);
            Controls.Add(lblhora);
            Controls.Add(lblTotal);
            Controls.Add(panelSearchBar);
            Controls.Add(panelProductList);
            Controls.Add(btnContinue);
            Controls.Add(button1);
            Name = "Principal";
            Text = "s";
            panelProductList.ResumeLayout(false);
            panelProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLProductlist).EndInit();
            panelSearchBar.ResumeLayout(false);
            panelSearchBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelProductList;
        private DataGridView dgvLProductlist;
        private Panel panelSearchBar;
        private Button btnExport;
        private Button btnImport;
        private TextBox txtPrice;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnContinue;
        private Button button1;
        private Label lblPrice;
        private Label lblName;
        private Label lblID;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoría;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label lblTotal;
        private Label lblhora;
        private Label lblConsumidor;
        private Label label7;
        private Label lblhora2;
        private System.Windows.Forms.Timer hora;
        private Label lblTotalPesos;
        private Label lblProductCount;
        private Label lblTicketN;
        private Label lblTicketNº;
        private Button lblOptions;
        private ComboBox cmbMedioDePago;
        private Label lblMedioDePago;
    }
}