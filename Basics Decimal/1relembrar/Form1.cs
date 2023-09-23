namespace _1relembrar
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
            int valor = 1;
            label1.Text = "Olá Sou o Carlos!"+ valor.ToString();
            //criar blocos de código apenas para organizar
            #region teste1

            #endregion

            //label1.Text = "Olá Sou o Carlos!";
            //label1.Text = "Olá Sou o Carlos!";
            //label1.Text = "Olá Sou o Carlos!";
            //label1.Text = "Olá Sou o Carlos!";

            //COM CASAS DECIMAIS
            //float valor1 = 1.5f;
            //double valor1 = 1.5d;
            //decimal valor1 = 1.5m;
            float resultado1 = 200 / (float)1.5; //8 algarismos
            double resultado2 = 200 / (double)1.5; // ~16
            decimal resultado3 = 200 / (decimal)1.5;// ~29

            label2.Text = resultado1.ToString();
            label3.Text = resultado2.ToString();
            label4.Text = resultado3.ToString();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
            Application.Exit();
        }
    }
}