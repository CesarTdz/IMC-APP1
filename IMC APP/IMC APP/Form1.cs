namespace IMC_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Asignar el evento KeyPress para permitir solo números
            txtPeso.KeyPress += SoloNumeros;
            txtAltura.KeyPress += SoloNumeros;
            txtZancada.KeyPress += SoloNumeros;
            txtPasos.KeyPress += SoloNumeros;
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, la tecla de retroceso y el punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea la entrada de caracteres no permitidos
            }

            // Evitar múltiples puntos decimales
            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variables para almacenar valores numéricos
            double peso, altura, sancada, pasos;

            // Validar entrada de texto antes de convertir a número
            if (!double.TryParse(txtPeso.Text, out peso) || peso <= 0)
            {
                MessageBox.Show("Ingrese un peso que sea valido válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtAltura.Text, out altura) || altura <= 0)
            {
                MessageBox.Show("Ingrese una altura válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtZancada.Text, out sancada) || sancada <= 0)
            {
                MessageBox.Show("Ingrese una longitud de zancada válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtPasos.Text, out pasos) || pasos <= 0)
            {
                MessageBox.Show("Ingrese un número de pasos válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Instancia de la clase lógica
            Calculo calculadoraIMC = new Calculo();

            // Calcular el IMC
            double imc = calculadoraIMC.CalcularIMC(peso, altura);
            string clasificacion = calculadoraIMC.ClasificarIMC(imc);

            // Calcular la distancia recorrida
            double kmRecorridos = calculadoraIMC.CalcularKm(sancada, pasos);
            string mensajePasos = calculadoraIMC.VerificarPasos(pasos, imc);

            // Mostrar resultados
            MessageBox.Show($"IMC: {imc}\nClasificación: {clasificacion}\nKilómetros recorridos: {kmRecorridos} km\n{mensajePasos}","Resultados", MessageBoxButtons.OK);

            // Limpiar campos de entrada
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtPasos.Text = "";
            txtZancada.Text = "";
        }

    }
}



