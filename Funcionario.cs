using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeFixacao_Listas
{
    internal class Funcionario
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int cod, string nome, double salario) 
        { 
            Cod = cod;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario (double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }
    }
}
