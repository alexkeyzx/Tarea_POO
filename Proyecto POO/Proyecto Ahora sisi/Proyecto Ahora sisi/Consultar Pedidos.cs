using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Ahora_sisi
{
    public partial class Consultar_Pedidos : Form
    {
        int Id;
        public Consultar_Pedidos()
        {

            InitializeComponent();
            // No permitir agregar ni eliminar renglones
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            // Autoajustar el ancho de las columnas
            dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            // Seleccionar un renglón completo al hacer click
            dataGridView1.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
        }

        private void Consultar_Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            i++;
            string a;
            if (chbEntregado.Checked == true)
            {
                a = "si";

            }
            else
            {
                a = "no";
            }
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pedidos;";
            
            string query = "UPDATE `pedidos` SET `Id_Pedido`=Null,`Nombre`='" + txtNombre.Text+ "',`Contacto`=" +txtContacto.Text+ ",`Cantidad de cartas`=" + txtCantidad.Text+ ",`Completo`='" + a+"' WHERE Id_Pedido = " + i + ""; 

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Se a actualizado con exito");
                // Actualizado satisfactoriamente

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, quizás el ID no existe
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pedidos";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand("SELECT * FROM pedidos", databaseConnection);
            commandDatabase.CommandTimeout = 60;
            
           
           
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                // Si se encontraron datos
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                               
                        dataGridView1.Rows.Add(reader.GetString(1),reader.GetString(2),reader.GetString(3),reader.GetString(4));
                        
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro nada");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
           
            
            string a;
            if (chbEntregado.Checked == true)
            {
                a = "si";

            }
            else
            {
                a = "no";
            }
            dataGridView1.Rows.Add(txtNombre.Text, txtContacto.Text, txtCantidad.Text, a);

            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pedidos;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString); 

            MySqlCommand commandDatebase = new MySqlCommand("Insert Into pedidos(`Id_Pedido`,`Nombre`,`Contacto`,`Cantidad de cartas`, `Completo`) VALUES ('Null','" + txtNombre.Text + "'," + txtContacto.Text + ", " + txtCantidad.Text +", '"+a+"')", databaseConnection);
            commandDatebase.CommandTimeout = 60;
            

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatebase.ExecuteReader();

                MessageBox.Show("Pedido Agregado");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show(ex.Message);
            }
        
    }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            i++;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pedidos;";
            // Borrar la fila con ID 1
            string query = "DELETE FROM `pedidos` WHERE Id_Pedido = " + i+"";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("Eliminado satisfactoriamente");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, quizás el id no existe
                MessageBox.Show(ex.Message);
            }
            
        }
        
    }

}
