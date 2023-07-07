namespace SGV2
{
    partial class Options
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
            txtCbuAlias = new TextBox();
            lblCbuAlias = new Label();
            txtCuit = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            lblrestarMessage = new Label();
            pbgenerar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbgenerar).BeginInit();
            SuspendLayout();
            // 
            // txtCbuAlias
            // 
            txtCbuAlias.CharacterCasing = CharacterCasing.Upper;
            txtCbuAlias.Location = new Point(338, 63);
            txtCbuAlias.Name = "txtCbuAlias";
            txtCbuAlias.Size = new Size(250, 23);
            txtCbuAlias.TabIndex = 0;
            txtCbuAlias.TextChanged += txtCbuAlias_TextChanged;
            // 
            // lblCbuAlias
            // 
            lblCbuAlias.AutoSize = true;
            lblCbuAlias.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCbuAlias.Location = new Point(469, 40);
            lblCbuAlias.Name = "lblCbuAlias";
            lblCbuAlias.Size = new Size(31, 18);
            lblCbuAlias.TabIndex = 1;
            lblCbuAlias.Text = "QR";
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(27, 220);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(250, 23);
            txtCuit.TabIndex = 2;
            txtCuit.TextChanged += txtCuit_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(27, 145);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 23);
            txtAddress.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(27, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 23);
            txtName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(130, 190);
            label1.Name = "label1";
            label1.Size = new Size(43, 18);
            label1.TabIndex = 5;
            label1.Text = "CUIT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(121, 114);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 6;
            label2.Text = "Dirección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(88, 40);
            label3.Name = "label3";
            label3.Size = new Size(133, 18);
            label3.TabIndex = 7;
            label3.Text = "Nombre comercio";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(120, 288);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "GUARDAR";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblrestarMessage
            // 
            lblrestarMessage.AutoSize = true;
            lblrestarMessage.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblrestarMessage.ForeColor = Color.Red;
            lblrestarMessage.Location = new Point(88, 326);
            lblrestarMessage.Name = "lblrestarMessage";
            lblrestarMessage.Size = new Size(158, 16);
            lblrestarMessage.TabIndex = 9;
            lblrestarMessage.Text = "Debe reiniciar el programa";
            lblrestarMessage.Visible = false;
            // 
            // pbgenerar
            // 
            pbgenerar.Location = new Point(338, 92);
            pbgenerar.Name = "pbgenerar";
            pbgenerar.Size = new Size(250, 250);
            pbgenerar.SizeMode = PictureBoxSizeMode.CenterImage;
            pbgenerar.TabIndex = 10;
            pbgenerar.TabStop = false;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 389);
            Controls.Add(pbgenerar);
            Controls.Add(lblrestarMessage);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtAddress);
            Controls.Add(txtCuit);
            Controls.Add(lblCbuAlias);
            Controls.Add(txtCbuAlias);
            Name = "Options";
            Text = "Options";
            Load += Options_Load;
            ((System.ComponentModel.ISupportInitialize)pbgenerar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCbuAlias;
        private Label lblCbuAlias;
        private TextBox txtCuit;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private Label lblrestarMessage;
        private PictureBox pbgenerar;
    }
}