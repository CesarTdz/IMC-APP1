namespace IMC_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Asignar el evento KeyPress para permitir solo n�meros
            txtPeso.KeyPress += SoloNumeros;
            txtAltura.KeyPress += SoloNumeros;
            txtZancada.KeyPress += SoloNumeros;
            txtPasos.KeyPress += SoloNumeros;
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            // Permitir solo n�meros, la tecla de retroceso y el punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea la entrada de caracteres no permitidos
            }

            // Evitar m�ltiples puntos decimales
            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variables para almacenar valores num�ricos
            double peso, altura, sancada, pasos;

            // Validar entrada de texto antes de convertir a n�mero
            if (!double.TryParse(txtPeso.Text, out peso) || peso <= 0)
            {
                MessageBox.Show("Ingrese un peso que sea valido v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtAltura.Text, out altura) || altura <= 0)
            {
                MessageBox.Show("Ingrese una altura v�lida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtZancada.Text, out sancada) || sancada <= 0)
            {
                MessageBox.Show("Ingrese una longitud de zancada v�lida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtPasos.Text, out pasos) || pasos <= 0)
            {
                MessageBox.Show("Ingrese un n�mero de pasos v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Instancia de la clase l�gica
            Calculo calculadoraIMC = new Calculo();

            // Calcular el IMC
            double imc = calculadoraIMC.CalcularIMC(peso, altura);
            string clasificacion = calculadoraIMC.ClasificarIMC(imc);

            // Calcular la distancia recorrida
            double kmRecorridos = calculadoraIMC.CalcularKm(sancada, pasos);
            string mensajePasos = calculadoraIMC.VerificarPasos(pasos, imc);

            // Mostrar resultados
            MessageBox.Show($"IMC: {imc}\nClasificaci�n: {clasificacion}\nKil�metros recorridos: {kmRecorridos} km\n{mensajePasos}","Resultados", MessageBoxButtons.OK);

            // Limpiar campos de entrada
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtPasos.Text = "";
            txtZancada.Text = "";
        }

    }
}



