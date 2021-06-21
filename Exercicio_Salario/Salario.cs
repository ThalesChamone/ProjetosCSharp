using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Salario
{
    class Salario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentoSalario(int porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome + ", $" + SalarioLiquido().ToString("F2");
        }
    }
   }
