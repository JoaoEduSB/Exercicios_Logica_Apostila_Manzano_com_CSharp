// Disciplina: Lógica de programação com C#
// Professor: Jailson
// Data: 04/06/2024
// g) Ler quatro números inteiros e apresentar o resultado da adição e multiplicação, baseando-se na utilização do conceito da propriedade distributiva. Ou seja, se forem lidas as variáveis A, B, C, e D, devem ser somadas e multiplicadas A com B, A com C e A com D. Depois B com C, B com D e por fim C com D. Perceba que será necessário efetuar seis operações de adição e seis operações de multiplicação e apresentar doze resultados de saída.

using System;

class Resultados {
    static void Main (string [] args) {
        Console.WriteLine("");

        Console.WriteLine("Vamos ler e apresentar o resultado da adição e multiplicação de diversos valores");

        Console.WriteLine("");
        
        Console.Write("Digite o valor de A: ");
        int valorA = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("");
        
        Console.Write("Digite o valor de B: ");
        int valorB = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("");

        Console.Write("Digite o valor de C: ");
        int valorC = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("");

        Console.Write("Digite o valor de D: ");
        int valorD = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("");

        int soma_AB = valorA + valorB;
        int soma_AC = valorA + valorC;
        int soma_AD = valorA + valorD;
        int soma_BC = valorB + valorC;
        int soma_BD = valorB + valorD;
        int soma_CD = valorC + valorD;


        double mult_AB = valorA * valorB;
        double mult_AC = valorA * valorC;
        double mult_AD = valorA * valorD;
        double mult_BC = valorB * valorC;
        double mult_BD = valorB * valorD;
        double mult_CD = valorC * valorD;

        Console.WriteLine("");

        Console.WriteLine("Resultados da soma:");

        Console.WriteLine("");

        Console.WriteLine("A + B = " + soma_AB);
        Console.WriteLine("A + C = " + soma_AC);
        Console.WriteLine("A + D = " + soma_AD);
        Console.WriteLine("B + C = " + soma_BC);
        Console.WriteLine("B + D = " + soma_BD);
        Console.WriteLine("C + D = " + soma_CD);

        Console.WriteLine("");

        Console.WriteLine("Resultados da multiplicação:");

        Console.WriteLine("");

        Console.WriteLine("A * C = " + mult_AB);
        Console.WriteLine("A * D = " + mult_AC);
        Console.WriteLine("A * B = " + mult_AD);
        Console.WriteLine("B * C = " + mult_BC);
        Console.WriteLine("B * D = " + mult_BD);
        Console.WriteLine("C * D = " + mult_CD);

        Console.WriteLine("");
    }
}