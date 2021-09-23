using System;

namespace listaExercicios02 {
    class Exercicio05 {
        static void Main(string[] args) {
            Console.WriteLine("Bom Dia!!");


            Console.WriteLine("Favor digite o salário bruto do colaborador: ");
            string strSalarioB = Console.ReadLine();

            decimal salarioBruto = Convert.ToDecimal(strSalarioB);
            decimal iNSS = (salarioBruto * 10) / 100;
            decimal fgts = (salarioBruto * 11) / 100;
            decimal iR = 0;
            if (salarioBruto <= 2000) {
                iR = 0;
            } else if (salarioBruto > 2000 && salarioBruto <= 5000) {
                iR = (salarioBruto * 5) / 100;
            } else if (salarioBruto > 5000 && salarioBruto <= 7500) {
                iR = (salarioBruto * 10) / 100;
            } else if (salarioBruto > 7500) {
                iR = (salarioBruto * 20) / 100;
            }

            decimal totalDesconto = iNSS + iR;
            decimal salarioLiquido = salarioBruto - totalDesconto;

            Console.WriteLine("Salário bruto: (5*220)             : R$" + salarioBruto);
            Console.WriteLine("(-) IR (--)                        : R$" + iR);
            Console.WriteLine("(-) INSS (10%)                     : R$" + iNSS);
            Console.WriteLine("FGTS (11%)                         : R$" + fgts);
            Console.WriteLine("Total desconto                     : R$" + totalDesconto);
            Console.WriteLine("Salário Liquido                    : R$" + salarioLiquido);

        }
    }
}