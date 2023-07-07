using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using ZXing;
using ZXing.QrCode;

namespace SGV2
{
    public partial class Principal : Form
    {

        int y = 20;
        int productCount = 0;
        float idTicket = 0;
        string totalTicket = string.Empty;
        string medioDePago = string.Empty;

        string storeName = string.Empty;
        string address = string.Empty;
        string cuit = string.Empty;
        string cbuAlias = string.Empty;


        public Principal()
        {

            InitializeComponent();
            storeDataLoader();
            cmbMedioDePago.SelectedIndex = 0;
        }

        private void storeDataLoader()
        {

            Connection con = new Connection();

            MySqlDataReader datos = con.storeDataLoader();

            if (datos.Read())
            {

                this.storeName = datos.GetString(0);
                this.address = datos.GetString(1);
                this.cuit = datos.GetString(2);
                this.cbuAlias = datos.GetString(3);
            }

        }

        public List<string> getStoreData()
        {

            List<string> data = new List<string>();
            data.Add(storeName);
            data.Add(address);
            data.Add(cuit);
            data.Add(cbuAlias);

            return data;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Connection connections = new Connection();

            //el uno nos indica que va a buscar por el nombre del producto
            MySqlDataReader reader = connections.buscadorID_Nombre_Precio(txtName.Text, 1);

            while (reader.Read())
            {
                txtId.Text = reader.GetString(0);
                txtPrice.Text = reader.GetString(1);

            }

            reader.Close();
        }

        AutoCompleteStringCollection autoCompletar(string dato)
        {


            AutoCompleteStringCollection listaProducto = new AutoCompleteStringCollection();

            Connection conexiones = new Connection();

            for (int i = 0; i < conexiones.CargarProductos().Rows.Count; i++)
            {
                string producto = conexiones.CargarProductos().Rows[i][$"{dato}"].ToString();

                listaProducto.Add($"{producto}");

            }


            return listaProducto;
            //txtBuscador.AutoCompleteCustomSource = listaProducto;
            //txtBuscarID.AutoCompleteCustomSource = listaProducto;

        }
        private void productsCount()
        {
            int productsCount = 0;
            decimal subTotalPrice = 0;

            foreach (DataGridViewRow row in dgvLProductlist.Rows)
            {
                if (row == null) { continue; }
                else
                {

                    productsCount += Convert.ToInt32(row.Cells[2].Value);

                    subTotalPrice += Convert.ToDecimal(row.Cells[4].Value);

                }

            }

            lblProductCount.Text = productsCount.ToString();
            lblTotalPesos.Text = subTotalPrice.ToString();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtName.Clear();
                txtId.Clear();
                txtPrice.Clear();

            }



            if (e.KeyCode == Keys.Enter)
            {

                string nombreProducto = txtName.Text;
                string PrecioProducto = txtPrice.Text;
                string idProducto = txtId.Text;


                foreach (DataGridViewRow row in dgvLProductlist.Rows)
                {
                    if (dgvLProductlist.RowCount == 0 || row.Cells[1].Value == null)
                    {
                        dgvLProductlist.Rows.Add(idProducto, nombreProducto, "1", PrecioProducto, PrecioProducto, "");
                        break;
                    }

                    if (row.Cells[1].Value.ToString() == nombreProducto)
                    {
                        if (Convert.ToDouble(row.Cells[4].Value) > 0)
                        {
                            row.Cells[2].Value = Convert.ToDecimal(row.Cells[2].Value) + 1;
                            row.Cells[4].Value = Convert.ToDecimal(row.Cells[3].Value) * Convert.ToDecimal(row.Cells[2].Value);

                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }


                productsCount();

            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.AutoCompleteCustomSource = autoCompletar("Nombre");
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Connection saveSale = new Connection();

            this.idTicket = saveSale.saveSale(lblTotalPesos.Text);

            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();

        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {

            totalTicket = lblTotalPesos.Text;

            medioDePago = char.ToUpper(cmbMedioDePago.SelectedItem.ToString()[0]) + cmbMedioDePago.SelectedItem.ToString().Substring(1).ToLower();



            Font fontTitles = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point, 0);
            Font fontProducts = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point, 0);
            Font fontTotalTicket = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point, 0);
            Font barras = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point, 0);

            float ticketWidthInMm = 80;
            float ticketWidthInPoints = ticketWidthInMm * 2.83465f;


            e.Graphics.DrawString($"{storeName}", fontTitles, Brushes.Black, new RectangleF(10, y, ticketWidthInPoints - 20, 25));
            y += 50;

            e.Graphics.DrawString($"CUIT    {cuit}", fontTotalTicket, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints, 20));
            y += 20;
            e.Graphics.DrawString($"Dirección   {address}", fontTotalTicket, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints, 20));
            y += 20;
            e.Graphics.DrawString($"Ticket Nº   {idTicket}", fontTotalTicket, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints, 20));
            y += 40;

            e.Graphics.DrawString(" ---------------------------------------------------------------", fontTotalTicket, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints, 20));
            y += 20;


            foreach (DataGridViewRow row in dgvLProductlist.Rows)
            {
                string cantidad = row.Cells[2].Value?.ToString() ?? string.Empty;
                string producto = row.Cells[1].Value?.ToString() ?? string.Empty;
                string precio = row.Cells[3].Value?.ToString() ?? string.Empty;
                string subTotal = row.Cells[4].Value?.ToString() ?? string.Empty;
                if (string.IsNullOrEmpty(cantidad))
                {
                    continue;
                }
                productCount++;
                e.Graphics.DrawString(" " + cantidad + "x", fontProducts, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints, 20));

                if (producto.Length > 20)
                {
                    string primeraParte = producto.Substring(0, 20);
                    string segundaParte = producto.Substring(20);

                    e.Graphics.DrawString(primeraParte, fontProducts, Brushes.Black, new RectangleF(30, y, ticketWidthInPoints - 30, 20));
                    y += 15;
                    e.Graphics.DrawString(segundaParte, fontProducts, Brushes.Black, new RectangleF(30, y, ticketWidthInPoints - 30, 20));
                }
                else
                {
                    e.Graphics.DrawString(producto, fontProducts, Brushes.Black, new RectangleF(30, y, ticketWidthInPoints - 30, 20));
                }

                e.Graphics.DrawString(subTotal, fontProducts, Brushes.Black, new RectangleF(ticketWidthInPoints - 40, y, 80, 20));

                y += 20;
            }

     
            e.Graphics.DrawString(" ---------------------------------------------------------------", fontTotalTicket, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints, 20));
            y += 30;

            e.Graphics.DrawString(" IVA RESPONSABLE INSCRIPTO", fontTotalTicket, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints, 20));
            y += 20;
            e.Graphics.DrawString(" A CONSUMIDOR FINAL", fontTotalTicket, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints, 20));
            y += 20;
            e.Graphics.DrawString(" Pago:   " + medioDePago, fontTotalTicket, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints, 20));
            y += 20;
            e.Graphics.DrawString(" Hora:   " + DateAndTime.TimeString, fontTotalTicket, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints, 20));
            y += 20;
            e.Graphics.DrawString(" Fecha:  " + DateAndTime.DateString, fontTotalTicket, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints, 20));
            y += 30;
            e.Graphics.DrawString(" =====================================", barras, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints, 20));
            y += 20;
            e.Graphics.DrawString(" Total articulos: ", fontTotalTicket, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints - 100, 20));
            e.Graphics.DrawString(productCount.ToString(), fontTotalTicket, Brushes.Black, new RectangleF(ticketWidthInPoints - 40, y, 80, 20));
            y += 20;
            e.Graphics.DrawString(" TOTAL: ", fontTotalTicket, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints - 100, 20));
            e.Graphics.DrawString(totalTicket, fontTotalTicket, Brushes.Black, new RectangleF(ticketWidthInPoints - 40, y, 80, 20));
            y += 20;
            e.Graphics.DrawString(" =====================================", barras, Brushes.Black, new RectangleF(0, y, ticketWidthInPoints, 20));

            if (cbuAlias != "")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(cbuAlias), 150, 150);
                e.Graphics.DrawImage(bm, new RectangleF(38, y + 15, 150, 150));

            }

            y += 130;

            e.Graphics.DrawString("¡GRACIAS POR SU COMPRA!", fontTitles, Brushes.Black, new RectangleF(20, y + 50, ticketWidthInPoints - 60, 30));



        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateAndTime.Now.ToShortTimeString();
        }

        private void dgvLProductlist_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Confirma cancelación de la compra?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dgvLProductlist.Rows.Clear();

                MessageBox.Show("¡Compra cancelada!");
            }

        }

        private void lblOptions_Click(object sender, EventArgs e)
        {
            Options ops = new Options();

            ops.Show();
        }

        private void panelSearchBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
