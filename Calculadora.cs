namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txt1.Text);
            double numero2 = Convert.ToDouble(txt2.Text);


            // Realizar a soma dos números e exibir o resultado
            lblresultado.Text = (numero1 + numero2).ToString();

        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txt1.Text);
            double numero2 = Convert.ToDouble(txt2.Text);

            lblresultado.Text = (numero1 - numero2).ToString();


        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txt1.Text);
            double numero2 = Convert.ToDouble(txt1.Text);

            lblresultado.Text = (numero1 * numero2).ToString();


        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txt1.Text);
            double numero2 = Convert.ToDouble(txt2.Text);

            lblresultado.Text =(numero1 / numero2).ToString();
        }
    }
}
