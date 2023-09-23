using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exec_Click(object sender, EventArgs e)
        {
            //STRINGS

            //string frase = "Variavel de texto alfanumerico    ";
            //CONTAGEM DE LETRAS
            //int nletras = frase.Length;
            //cx_txt.Text = frase + nletras;
            //cx_txt.Text = frase + " (contem " + frase.Length + " Letras!)";

            //cx_txt.Text = frase.ToUpper();

            //cx_txt.Text = frase.Substring(12, 5);//apartir de onde, e quantas letras)

            //bool res = frase.Contains("alfa");
            //cx_txt.Text = res.ToString();

            //bool res = frase.StartsWith("Vari");
            //cx_txt.Text = res.ToString();

            //cx_txt.Text = frase.Trim(); //retira espaço do inicio e do fim de uma string

            //Indice de caracter
            //int x = frase.IndexOf("o");
            //int z = frase.LastIndexOf("o");
            //cx_txt.Text = x.ToString() + " e " + z.ToString();

            //JUNTAR, neste teste adicionei apelino no meio dos 2 nomes, adicionando espaço
            //antes do apelido, daí o 2º .insert
            string nome = "Carlos Dias";
            string apelido = "Vicente Salgueiro";
            string[] pronome = nome.Split(' ');
            string nome_completo = nome.Insert(pronome[0].Length, apelido.Insert(0, " "));
            cx_txt.Text = nome_completo;

            //TROCAR LETRA
            //string nome = "Carlos Dias";
            //string final = nome.Replace('i', '_');
            //cx_txt.Text = final;

            //SEPARAR STRING
            //string items = "Carlos, João, Paulo, Manuel, Jorge";
            //string[] nomes = items.Split(',');
            //cx_txt.Text = nomes[0];
        }
    }
}
