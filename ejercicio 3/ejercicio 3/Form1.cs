namespace ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string password = textBox1.Text;

            string mensaje = " ";
            if (password.Length < 8)
            {
                mensaje += "La contraseña debe tener al menos 8 caracteres.\n";

            }
            if (!password.Any(char.IsUpper))
            {
                mensaje += "La contraseña debe contener al menos una letra mayúscula.\n";
            }

            if (!password.Any(char.IsDigit))
            {
                mensaje += "La contraseña debe contener al menos un número.\n";
            }

            if (string.IsNullOrEmpty(mensaje))
            {
                mensaje = "La contraseña es válida.";
            }

            labelResultado.Text = mensaje;
        }
    }
}
