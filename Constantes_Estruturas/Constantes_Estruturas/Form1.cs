using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constantes_Estruturas
{
    public partial class Form1 : Form
    {
        //estrutura apenas engloba as propriedades do "objeto"
        //enquanto o objeto pode incluir procedimentos
        struct estrutura_pessoa
        {
            public string nome;
            public string apelido;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            normal ob1 = new normal();
            Console.WriteLine(ob1.Nome);

            Console.WriteLine(estatica.Nome);

            pessoa p1 = new pessoa();
            p1.Nome= "Vicente";
            p1.Apelido = "Salgueirio";

            estrutura_pessoa p2 = new estrutura_pessoa();
            p2.nome = "Claudia";
            p2.apelido = "Costa";
            //ou estrutura_pessoa p2 = new estrutura_pessoa() {nome= "Claudia", apelido = "Costa"};
            Console.WriteLine(p2.nome + " " + p2.apelido);

        }
    }
}
