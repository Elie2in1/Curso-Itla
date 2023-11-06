using Capturaempleadowforms.Clases;
using System.Diagnostics.Contracts;

namespace Capturaempleadowforms
{
    public partial class Form1 : Form
    {
        AccesoDao AccesoDao;
        public Form1()
        {
            this.AccesoDao = new AccesoDao();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            negocio newnegocio = new negocio()
            {
                codigo = txbcodigo.Text,
                nombres = txbnombres.Text,
                apellidos = txbapellidos.Text,
                correo = txbcorreo.Text,
                telefono = txbtelefono.Text,
                direccion = txbdireccion.Text,
                posicion = txbposicion.Text,
                departamento = txbdepartamento.Text,
                fechacontratacion = dtpfecha.Value,
            };

            this.AccesoDao.Guadar(newnegocio);

            var contacs = this.AccesoDao.ObtenerContactos();

            empleado emplado = new empleado();

            this.dgvempleado.DataSource = contacs.ToArray();
            this.dgvempleado.Refresh();

            LimpiarCampos();

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            LimpiarCampos();

        }
        void LimpiarCampos()
        {
            txbcodigo.Text = string.Empty;
            txbnombres.Text = string.Empty;
            txbapellidos.Text = string.Empty;
            txbcorreo.Text = string.Empty;
            txbtelefono.Text = string.Empty;
            txbdireccion.Text = string.Empty;
            txbposicion.Text = string.Empty;
            txbdepartamento.Text = string.Empty;
            dtpfecha.Value = DateTime.Now;
            txbcodigo.Focus();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}