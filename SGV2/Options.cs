using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace SGV2
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Connection con = new Connection();

            con.saveOptions(txtName.Text, txtAddress.Text, txtCuit.Text, txtCbuAlias.Text);
            lblrestarMessage.Visible = true;
        }

        private void Options_Load(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            List<string> data = new List<string>();

            data.AddRange(principal.getStoreData());

            txtName.Text = data[0];
            txtAddress.Text = data[1];
            txtCuit.Text = data[2];
            txtCbuAlias.Text = data[3];
        }

        private void txtCbuAlias_TextChanged(object sender, EventArgs e)
        {
            if (txtCbuAlias.Text != "")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(txtCbuAlias.Text), 300, 300);
                pbgenerar.Image = bm;
            }
        }

        private void txtCuit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
