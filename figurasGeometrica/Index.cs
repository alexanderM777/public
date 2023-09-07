using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figurasGeometrica
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btnDi_Click(object sender, EventArgs e)
        {
            FigurasBidimensionales bi = new FigurasBidimensionales();
           bi.ShowDialog();
        }

        private void btnTri_Click(object sender, EventArgs e)
        {
            figurasTridimensionales tri = new figurasTridimensionales();
            tri.ShowDialog();
        }
    }
}
