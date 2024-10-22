namespace ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] numeros = { 5, 10, 15, 20, 25 };

            
            int suma = 0;

            
            foreach (int numero in numeros)
            {
                suma += numero; 
            }

            
            labelResultado.Text = $"La suma de los elementos es:" + suma ;

        }
    }
}
