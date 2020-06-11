using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ahora_sisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVerPedido_Click(object sender, EventArgs e)
        {
            Consultar_Pedidos form = new Consultar_Pedidos();
            form.Show();
        }

        private void btnCrearCarta_Click(object sender, EventArgs e)
        {
            Tamaño_2 form = new Tamaño_2();
            form.Show();
        }
    }
}
