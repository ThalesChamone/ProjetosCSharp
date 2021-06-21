using System;

namespace Exercicio_Salario
{
    class Exercicio_Salario
    {
        static void Main(string[] args)
        {
            Salario funcionario;

            funcionario = new Salario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: " );
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Funcionario: " + funcionario);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            int aumento = int.Parse(Console.ReadLine());
            funcionario.AumentoSalario(aumento);

            Console.WriteLine();

            Console.Write("Dados atualizados: " + funcionario);

        }
    }
}
