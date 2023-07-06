using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
