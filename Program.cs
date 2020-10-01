using System;
using System.Globalization;

namespace SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func=new Funcionario();

            Console.WriteLine("Informe o nome do funcionário: ");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Qual o salário bruto? ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qual o valor do imposto? ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(); 
            Console.WriteLine("Funcionário: " + func);

            Console.WriteLine("Em quantos % deseja aumentar o salário? "); 
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            func.AumSalario(porcent);

            Console.WriteLine(); 
            Console.WriteLine("Dados atualizados: " + func);

        }
    }
}
