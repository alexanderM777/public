using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePublicaciones
{
    public partial class frmEditorial : Form
    {
        private List<Revistas> revistas = null;
        private List<Libros> libtos = null;
        public frmEditorial()
        {
          //  mostrarRevistas();
            mostrarLibros();
            InitializeComponent();
        }

        private void mostrarLibros()
        {
            Autor librosss = new Autor();
            libtos = librosss.obtenerLista();

            dtgLibros.DataSource = null;
            dtgLibros.DataSource = libtos;
        }

        private void mostrarRevistas()
        {
            Autor revistass = new Autor();
            revistas = revistass.obtenerLista2();

            dtgRevistas.DataSource = null;
            dtgRevistas.DataSource = revistas;
        }
    }
}
