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
            //Valida��o de Campos

            if (!double.TryParse(txt1.Text, out double numero1) || !double.TryParse(txt2.Text, out double numero2))
            {
                MessageBox.Show("Digite apenas n�meros v�lidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(txt1.Text) || string.IsNullOrWhiteSpace(txt2.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de calcular.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do m�todo sem continuar
            }
           // double numero1 = Convert.ToDouble(txt1.Text);
           // double numero2 = Convert.ToDouble(txt2.Text);


            // Realizar a soma dos n�meros e exibir o resultado
            lblresultado.Text = (numero1 + numero2).ToString();

        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txt1.Text, out double numero1) || !double.TryParse(txt2.Text, out double numero2))
            {
                MessageBox.Show("Digite apenas n�meros v�lidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt1.Text) || string.IsNullOrWhiteSpace(txt2.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de calcular.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do m�todo sem continuar
            }
            //double numero1 = Convert.ToDouble(txt1.Text);
           // double numero2 = Convert.ToDouble(txt2.Text);

            lblresultado.Text = (numero1 - numero2).ToString();


        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txt1.Text, out double numero1) || !double.TryParse(txt2.Text, out double numero2))
            {
                MessageBox.Show("Digite apenas n�meros v�lidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt1.Text) || string.IsNullOrWhiteSpace(txt2.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de calcular.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do m�todo sem continuar
            }
           // double numero1 = Convert.ToDouble(txt1.Text);
           // double numero2 = Convert.ToDouble(txt1.Text);

            lblresultado.Text = (numero1 * numero2).ToString();


        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txt1.Text, out double numero1) || !double.TryParse(txt2.Text, out double numero2))
            {
                MessageBox.Show("Digite apenas n�meros v�lidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt1.Text) || string.IsNullOrWhiteSpace(txt2.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de calcular.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do m�todo sem continuar
            }
           // double numero1 = Convert.ToDouble(txt1.Text);
           // double numero2 = Convert.ToDouble(txt2.Text);

            lblresultado.Text =(numero1 / numero2).ToString();
        }
    }
}
