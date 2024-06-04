// Disciplina: Lógica de programação com C#
// Professor: Jailson
// Data: 04/06/2024
// e) Efetuar o cálculo e a apresentação do valor de uma prestação em atraso,
// utilizando a fórmula PRESTACAO <- VALOR + (VALOR * TAXA/100) * TEMPO).

using System;

class Prestacao {

    static void Main (string [] args) {
        Console.WriteLine("");

        Console.WriteLine("Vamos calcular o valor da sua prestação em atraso");

        Console.Write("Digite o valor da prestação: ");
        double prestacao = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor da taxa: ");
        int taxa = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o tempo de atraso em dias: ");
        int atraso = Convert.ToInt32(Console.ReadLine());

        prestacao = prestacao + (prestacao * taxa / 100) * atraso; 
        
        // O valor da prestação será o próprio valor +  (a taxa é calculada baseada na multiplicação da prestação pela taxa, por exemplo, se a taxa for 10%, e a prestação R$1000, então a prestação passará a custar R$1100, mas ela também é multiplicada pelos dias atrasados, e a taxa será multiplicada pelos dias de atraso, EXEMPLO: R$1000, uma taxa de 10%, com 5 dias de atraso, dará R$1500, porque 1000 + R$100 * 5, dará R$1500.

        Console.WriteLine("");

        Console.WriteLine("O valor final da prestação é: R$" + prestacao);

        Console.WriteLine("");
    }
}