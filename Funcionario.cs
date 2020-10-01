using System;
using System.Globalization;

namespace SalarioFuncionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double Liquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome
            + ", R$ "
            + Liquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
