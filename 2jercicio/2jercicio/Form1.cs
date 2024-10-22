namespace _2jercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string resultado = "";
            int i = 1;
            while (i <= 100)
            {
                
                if (i % 2 == 0)
                {
                    
                    resultado += i + " ";
                }

                
                i++;
            }

            textBox2.Text = resultado;
        }  
    }
}
