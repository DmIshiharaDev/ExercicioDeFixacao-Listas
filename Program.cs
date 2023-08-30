using ExercicioDeFixacao_Listas;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Empresa Focus S/A");
        Console.WriteLine("--------------------------------------");

        Console.WriteLine();
        Console.Write("Quantos funcionários você quer cadastrar?");
        int num = int.Parse(Console.ReadLine());

        List<Funcionario> list = new List<Funcionario>();

        for (int i = 1; i < num; i++)
        {
            Console.WriteLine("Funcionário #" + i + ":");
            Console.Write("Código: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            list.Add(new Funcionario(cod, nome, salario));
            Console.WriteLine();
        }

        Console.Write("Entre com o código do funcionário que quer aumentar o salário: ");
        int BuscaCod = int.Parse(Console.ReadLine());

        Funcionario busca = list.Find(x => x.Cod == BuscaCod);
        if ( busca != null ) 
        {
            Console.Write("Entre com o percentual do aumento: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        }

    }
}