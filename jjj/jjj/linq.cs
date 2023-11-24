using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jjj
{
    public partial class linq : Form
    {
        private List<estadisticas> estadas = null;
        private List<estadisticas> estadadisticas = null;
        public linq()
        {
            InitializeComponent();
            mostrardtg();
            mostrardtgFiltrada();
        }

        private void mostrardtgFiltrada()
        {
            listas lis = new listas();
            estadadisticas = lis.filtros();

            dtgListaFilttrada.DataSource = null;
            dtgListaFilttrada.DataSource = estadadisticas;
        }

        private void mostrardtg()
        {
            listas lista = new listas();
            estadas = lista.Obtener();

            dtgPlayers.DataSource = null;
            dtgPlayers.DataSource = estadas;
        }
    }
}
