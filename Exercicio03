using System;

namespace listaExercicios02 {
    class Exercicio03 {
        static void Main(string[] args) {
            Console.WriteLine("Bom Dia!!");

            Console.WriteLine("Favor entrar com Preço do produto 1: ");
            string strPP1 = Console.ReadLine();

            Console.WriteLine("Favor com Preço do produto 2: ");
            string strPP2 = Console.ReadLine();

            Console.WriteLine("Favor com Preço do produto 3: ");
            string strPP3 = Console.ReadLine();

            decimal preço01 = Convert.ToDecimal(strPP1);
            decimal preço02 = Convert.ToDecimal(strPP2);
            decimal preço03 = Convert.ToDecimal(strPP3);

            if (preço01 < preço02 && preço01 < preço03) {
                Console.WriteLine("Entre os produtos com os preços R$" + preço01 + ", R$" + preço02 + ", R$" + preço03 +". Favor, compra o produto com o preço R$" + preço01);

            } else if (preço02 < preço01 && preço02 < preço03) {
                Console.WriteLine("Entre os produtos com preços R$" + preço01 + ", R$" + preço02 + ", R$" + preço03 +". Favor, compra o produto com o preço R$" + preço02);
            } else {
                Console.WriteLine("Entre os produtos com preços R$" + preço01 + ", R$" + preço02 + ", R$" + preço03 +". Favor, compra o produto com o preço R$" + preço03);
            }

        }
    }
}