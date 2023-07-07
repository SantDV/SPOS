using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

using System.Data;



namespace SGV2
{
    internal class Connection
    {

        public static MySqlConnection Connect()
        {
            string server = "localhost", db = "sgv", user = "root", pass = "1528";

            string connectionString = "Database=" + db + "; Data Source=" + server +
                "; User Id= " + user + "; Password=" + pass + ";";

            try
            {
                MySqlConnection connectionDB = new MySqlConnection(connectionString);


                return connectionDB;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:" + ex);
                return null;
            }
        }

        public DataTable CargarProductos(string producto = "", string id = "")
        {
            MySqlConnection conexionDB = Connection.Connect();
            DataTable datable = new DataTable();
            MySqlDataReader resultado;

            string consulta = "SELECT productos.id_producto AS `ID`, productos.nombre AS `Nombre`, productos.precio as `Precio`, productos.stock as `Stock` FROM productos JOIN categorias ON productos.categoria = categorias.id_categoria;";


            if (producto.Length > 1)
            {
                consulta = "SELECT productos.id_producto AS `ID`, productos.nombre AS `Nombre`, productos.precio as `Precio`, productos.stock as `Stock`, categorias.categoria FROM productos JOIN categorias ON productos.categoria = categorias.id_categoria where productos.nombre like '%" + producto + "%';";
            }
            if (id.Length > 1)
            {
                consulta = "SELECT productos.id_producto AS `ID`, productos.nombre AS `Nombre`, productos.precio as `Precio`, productos.stock as `Stock`, categorias.categoria FROM productos JOIN categorias ON productos.categoria = categorias.id_categoria where productos.id_producto like '%" + id + "%';";
            }


            try
            {

                MySqlCommand actTableProdcutos = new MySqlCommand(consulta, conexionDB)
                {
                    CommandType = CommandType.Text
                };

                conexionDB.Open();

                resultado = actTableProdcutos.ExecuteReader();

                datable.Load(resultado);


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            conexionDB.Close();

            return datable;

        }


        public MySqlDataReader buscadorID_Nombre_Precio(string producto, int tipo)
        {
            MySqlConnection connectionDB = Connect();

            string consulta = string.Empty;

            if (tipo == 0)
            {
                consulta = "SELECT productos.id_producto AS `ID`, productos.nombre AS `Nombre`, productos.precio as `Precio`, productos.stock as `Stock` FROM productos where productos.id_productos = '" + producto + "';";
            }
            else
            {
                consulta = "SELECT productos.id_producto AS `ID`, productos.precio as `Precio`, productos.stock as `Stock` FROM productos where productos.nombre = '" + producto + "';";
            }


            try
            {

                MySqlCommand actTableProdcutos = new MySqlCommand(consulta, connectionDB)
                {
                    CommandType = CommandType.Text
                };

                connectionDB.Open();

                return actTableProdcutos.ExecuteReader();


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            connectionDB.Close();


            return null;

        }

        public float saveSale(string total)
        {

            MySqlConnection connectionDB = Connect();
            MySqlDataReader reader = null;

            string saveSale = $"INSERT INTO ventas (fecha, hora, total) VALUES ('{DateAndTime.DateString}', '{DateAndTime.TimeString}', '{total}');";
            string selectLastId = "SELECT MAX(id_venta) AS id FROM ventas;";

            try
            {

                MySqlCommand insertCommand = new MySqlCommand(saveSale, connectionDB);
                MySqlCommand selectCommand = new MySqlCommand(selectLastId, connectionDB);

                connectionDB.Open();

                insertCommand.ExecuteNonQuery(); // Ejecutar la instrucción INSERT

                reader = selectCommand.ExecuteReader(); // Ejecutar la instrucción SELECT

                if (reader.HasRows && reader.Read())
                {
                    float saleId = Convert.ToSingle(reader["id"]);

                    SaveSaleDetails(saleId);
                    return saleId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                connectionDB.Close();
            }
            return 0;
            
        }

        public void SaveSaleDetails(float saleId)
        {
            MySqlConnection conn = Connect();

            string insertDetails = "INSERT INTO detalles_venta(venta_id, producto_id, cantidad, precio_unitario) values();";
        }

        public void saveOptions(string name, string address, string cuit, string cbuAlias)
        {
            MySqlConnection connectionDB = Connect();

            string saveSale = $"update datos_negocio set name = '{name}', address = '{address}', cuit = '{cuit}', cbu_alias = '{cbuAlias}' where id = 1;";


            try
            {

                MySqlCommand insertCommand = new MySqlCommand(saveSale, connectionDB);
               

                connectionDB.Open();

                insertCommand.ExecuteNonQuery(); // Ejecutar la instrucción INSERT
         

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Datos actualizados!");
                connectionDB.Close();
            }
        }


        public MySqlDataReader storeDataLoader()
        {

            MySqlConnection conexionDB = Connect();
            MySqlDataReader resultado;

            string select = "SELECT name, address, cuit, cbu_alias from datos_negocio where id = 1;";


            try
            {

                MySqlCommand actTableProdcutos = new MySqlCommand(select, conexionDB)
                {
                    CommandType = CommandType.Text
                };

                conexionDB.Open();

                resultado = actTableProdcutos.ExecuteReader();

                return resultado;


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            conexionDB.Close();

            return null;

        }


    }
}
