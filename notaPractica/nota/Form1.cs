namespace nota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota_1, nota_2, nota_3, promedio;


            nota_1 = double.Parse(txtnota1.Text);

            nota_2 = double.Parse(txtnota2.Text);
            nota_3 = double.Parse(txtnota3.Text);

            promedio = (nota_1 + nota_2 + nota_3) / 3;

            txtPromedio.Text = promedio.ToString("N2");

            if (promedio <= 90 && promedio >= 100)
            {
                TEXTestado.Text = "excelente";
            }
            else if (promedio <= 80 && promedio >= 90)
            {
                TEXTestado.Text = "muy bueno";
            }
            else if (promedio <= 70 && promedio >= 80)
            {
                TEXTestado.Text = "bueno";
            }
            else if (promedio <= 60 && promedio >= 70)
            {
                TEXTestado.Text = "regular";
            }
            else if (promedio <= 60)
            {
                TEXTestado.Text = "reprobado";
            }
            
        } 


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            TEXTestado.Clear();
            txtPromedio.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿ seguro que quiere salir?","notas del estudiante",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (r == DialogResult.Yes) 
            {
            this.Close();
            }
        }
    }
}