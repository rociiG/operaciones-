namespace OperacionesMatematicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Num1, Num2;

        private void btnRESTA_Click(object sender, EventArgs e)
        {
           
                double resta;

                Num1 = Convert.ToDouble(textNUM_1.Text);
                Num2 = Convert.ToDouble(textNUM_2.Text);

                resta = Num1 - Num2;

                MessageBox.Show("El Resultado de la Resta es: " + resta,"Operacion Realizada",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void btnMULT_Click(object sender, EventArgs e)
        {
            double MULTIPLICAR;

            Num1 = Convert.ToDouble(textNUM_1.Text);
            Num2 = Convert.ToDouble(textNUM_2.Text);

            MULTIPLICAR = Num1 * Num2;

            MessageBox.Show("El Resultado de la Multiplicacion es: " + MULTIPLICAR, "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDIV_Click(object sender, EventArgs e)
        {
            double div;

            Num1 = Convert.ToDouble(textNUM_1.Text);
            Num2 = Convert.ToDouble(textNUM_2.Text);

            div = Num1 / Num2;


            MessageBox.Show("El Resultado de la Division es: " + div, "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSUMA_Click(object sender, EventArgs e)
        {
            double suma;

            Num1 = Convert.ToDouble(textNUM_1.Text);
            Num2 = Convert.ToDouble(textNUM_2.Text);

            suma = Num1 + Num2;

            MessageBox.Show("El Resultado de la Suma es: " + suma, "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}