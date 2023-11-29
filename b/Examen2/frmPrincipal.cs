namespace Examen2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        List<string> libro = new List<string>();
        List<string> revista = new List<string>();
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            inabilitar();

        }

        private void inabilitar()
        {
            label2.Enabled = false;
            label3.Enabled = false;
            label7.Enabled = false;
            label2.Visible = false;
            label3.Visible = false;
            label7.Visible = false;

            txtautor.Visible = false;
            dtpkfecha.Visible = false;
            cboperiodicidad.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (cboTipoPubli.Text != null)
            {
                Application.Exit();
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string tipo = cboTipoPubli.Text;
            if (tipo == "Revista")
            {
                label7.Enabled = true;
                label7.Visible = true;
                cboperiodicidad.Enabled = true;
                cboperiodicidad.Visible = true;
            }
            else if (tipo == "Libro") 
            {
                label2.Enabled = true;
                label3.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                txtautor.Enabled = true;
                dtpkfecha.Enabled = true;
                txtautor.Visible = true;
                dtpkfecha.Visible = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = txttitulo.Text;
            string autor = txtautor.Text;
            string tipo = cboTipoPubli.Text;
            decimal costo = Convert.ToDecimal(txtcosto.Text);
            DateTime fecha = Convert.ToDateTime(dtpkfecha.Text);
            if (tipo == "Libro")
            {
                Libros objlibro = new(titulo, costo, autor, fecha);
                libro.Add(objlibro.cosas());
            }else if (tipo == "Revista")
            {
                Revista objrevista = new(txttitulo.Text, costo, cboperiodicidad.Text);
                revista.Add(objrevista.cosas());
            }
        }

        private void cboTipoPubli_SelectedIndexChanged(object sender, EventArgs e)
        {
            inabilitar();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            string tipo = cboTipoPubli.Text;
            if (tipo == "Revista")
            {
                dtgvrevista.DataSource = null;
                dtgvrevista.DataSource = libro;
            }
            else if (tipo == "Libro")
            {
                dtgvlibros.DataSource = null;
                dtgvlibros.DataSource = revista;
            }
        }
    }
}