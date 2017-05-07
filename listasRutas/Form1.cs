using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listasRutas
{
    public partial class Form1 : Form
    {
        Base nuevaBase;
        Ruta RutaNew = new Ruta();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

                
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            nuevaBase = new Base(textBoxBase.Text, Convert.ToDouble(textBoxMinutos.Text));
            RutaNew.agregar(nuevaBase);


        }

        private void buttonAgregarInicio_Click(object sender, EventArgs e)
        {
            nuevaBase = new Base(textBoxBase.Text, Convert.ToDouble(textBoxMinutos.Text));
            RutaNew.agregarInicio(nuevaBase);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            textBoxMuestra.Text =""+RutaNew.buscar(textBoxBuscar.Text);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            RutaNew.eliminarProducto(textBoxEliminar.Text);
        }

        private void buttonoInsertarDespuesD_Click(object sender, EventArgs e)
        {
            nuevaBase = new Base(textBoxBase.Text, Convert.ToDouble(textBoxMinutos.Text));
            RutaNew.insertarBase(nuevaBase, textBoxInsertar.Text);
        }

        private void buttonRecorrido_Click(object sender, EventArgs e)
        {
            textBoxMuestra.Text = "" + RutaNew.recorrido(textBoxRecorrido.Text,Convert.ToInt32(textBoxHoraI.Text),Convert.ToInt32(textBoxHoraF.Text));
        }

        private void textBoxHoraI_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            textBoxMuestra.Text = "" + RutaNew.ToString();
        }
    }
}
