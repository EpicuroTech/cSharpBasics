using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes
{
    internal class teste
    {
        //Exemplos de enumeracoes
        public enum DiasDaSemana
        {
            domingo, segunda, terça, quarta, quinta, sexta, sábado
        }
        public void ApresentarDia(DiasDaSemana dia)
        {
            Console.WriteLine("O dia escolhido foi " + dia);
        }
        //============

        //exemplo com 4 botoes!
        public enum Movimentos { Cima, Baixo, Esquerda, Direita}

        public void Mover (Movimentos direcao)
        {
            Console.WriteLine("O jogador moveu -se para "+ direcao);
        }
    }
}
