// Disciplina: Lógica de programação com C#
// Professor: Jailson
// Data: 04/06/2024
// Ler dois valores (inteiros, reais ou caracteres) para as variáveis A e B, e efetuar a troca dos valores de forma que a variável A passe a possuir o valor da variável B e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.

using System;

class Troca {
    static void Main ( string [] args) {
        Console.WriteLine("");

        Console.WriteLine("Vamos alterar a posição de dois textos digitados");

        Console.Write("Digite um texto: ");
        string textoA = Console.ReadLine(); 

        Console.Write("Digite outro texto: ");
        string textoB = Console.ReadLine(); 

        string troca = textoA;
        
        textoA = textoB;
        textoB = troca;

        Console.WriteLine("O segundo texto digitado agora virou o primeiro: " + textoA);
        Console.WriteLine("O primeiro texto digitado agora virou o segundo: " + textoB);
    }
}