using System;

namespace listaExercicios10 {
    class Exercicio01 {
        static void Main(string[] args) {

            int numero, resultado;

            Console.WriteLine("Digite um número:");
            numero = Convert.ToInt32(Console.ReadLine());
            resultado = numero % 2;

            if (resultado == 0) {
                Console.WriteLine("O número digitado é par!");
            } else {
                Console.WriteLine("O número digitado é ímpar!");
            }
        }
    }
}