﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumeracoes
{
    public partial class Form1 : Form
    {
        teste jogador;
        public Form1()
        {
            InitializeComponent();
            jogador= new teste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               //s.ApresentarDia(teste.DiasDaSemana.sábado);
               jogador.Mover(teste.Movimentos.Cima);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jogador.Mover(teste.Movimentos.Baixo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jogador.Mover(teste.Movimentos.Direita);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            jogador.Mover(teste.Movimentos.Esquerda);
        }
    }
}
