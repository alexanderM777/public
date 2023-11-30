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
        private List<Libros> libtos = null;
        private List<Libros> libros = null;
        Autor tor = new Autor();
        public frmEditorial()
        {

            InitializeComponent();
       mostrarRevistas();
            mostrarLibros();
        }

        private void mostrarLibros()
        {
            Autor librosss = new Autor();
            libtos = librosss.obtenerdatos();

            dtgLibros.DataSource = null;
            dtgLibros.DataSource = libtos;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          //  agregarLibro();
           // agregarRrevistas();
            // borrar();
        }
        private void agregarLibro()
        {
            tor.pAutor = txtAutor.Text; tor.Publicado = txtPublicacion.Text; tor.titulo = txtTituloLibro.Text;
            tor.Costo = Convert.ToDouble(txtPrecioLibro.Text);
            //dtgLibros.Rows.Add(tor.pAutor, tor.Publicado, tor.titulo, tor.Costo.ToString("N2"));
            dtgLibros.DataSource = new Libros() { pAutor = tor.pAutor, Publicado = tor.Publicado, Costo = tor.Costo};
             
          
        }

        private void agregarRrevistas()
        {
            tor.titulo = txtTitulorevista.Text;
            tor.Costo = Convert.ToDouble(txtPrecioevista.Text);
            tor.Publicado = cboPeirodo.Text;
            //dtgLibros.Rows.Add(0, tor.Publicado, tor.titulo, tor.Costo.ToString("N2"));
            dtgLibros.DataSource = new Libros() { pAutor = "", Publicado = tor.Publicado, Costo = tor.Costo};

        }
        
        private void borrar()
        {
            txtAutor.Clear(); txtPublicacion.Clear() ; txtTitulorevista.Clear() ;
            txtPrecioLibro.Clear(); txtPrecioevista.Clear() ; txtTituloLibro.Clear() ; 
        }


        private void mostrarRevistas()
        {
            Autor revistass = new Autor();
            libros = revistass.obtener();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = libros;
        }
    }
}
