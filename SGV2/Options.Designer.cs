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
            SuspendLayout();
            // 
            // txtCbuAlias
            // 
            txtCbuAlias.Location = new Point(26, 259);
            txtCbuAlias.Name = "txtCbuAlias";
            txtCbuAlias.Size = new Size(283, 23);
            txtCbuAlias.TabIndex = 0;
            // 
            // lblCbuAlias
            // 
            lblCbuAlias.AutoSize = true;
            lblCbuAlias.Location = new Point(136, 241);
            lblCbuAlias.Name = "lblCbuAlias";
            lblCbuAlias.Size = new Size(68, 15);
            lblCbuAlias.TabIndex = 1;
            lblCbuAlias.Text = "CBU o Alias";
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(26, 195);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(283, 23);
            txtCuit.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(26, 130);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(283, 23);
            txtAddress.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(26, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 23);
            txtName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 177);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 5;
            label1.Text = "CUIT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 112);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Dirección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 45);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombre comercio";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(136, 300);
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
            lblrestarMessage.ForeColor = Color.Red;
            lblrestarMessage.Location = new Point(104, 331);
            lblrestarMessage.Name = "lblrestarMessage";
            lblrestarMessage.Size = new Size(146, 15);
            lblrestarMessage.TabIndex = 9;
            lblrestarMessage.Text = "Debe reiniciar el programa";
            lblrestarMessage.Visible = false;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 353);
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
    }
}