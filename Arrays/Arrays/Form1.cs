using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exec_Click(object sender, EventArgs e)
        {
            //ARRAYS
            //int[] valores;
            //valores = new int[5];

            //alternativa
            //int[] valores = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 0) { lista.Items.Add(valores[i] = 10); }
            //    else { lista.Items.Add(valores[i] = 10 * (i + 1)); }
            //}

            //ou
            int[] valores = new int[] { 10, 20, 30, 40, 50 };
            //foreach (int valor in valores) { lista.Items.Add(valor); }
            for (int i = 0; i < valores.Length; i++)
            {
                lista.Items.Add(valores[i]);
            }
        }
    }
}
