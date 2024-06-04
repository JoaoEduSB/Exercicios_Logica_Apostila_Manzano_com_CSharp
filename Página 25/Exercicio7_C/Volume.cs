// Disciplina: Lógica de programação com C#
// Professor: Jailson
// Data: 04/06/2024
// c) Calcular e apresentar o valor do volume de uma lata de óleo, utilizando
// a formula: Volume <- pi * Raio ^ 2 * Altura

using System;


class Volume {
    static void Main (string [] args) {

        const double pi = (3.14);
        Console.WriteLine("");

        Console.WriteLine("Vamos calcular o volume de uma lata de óleo");

        Console.Write("Digite o raio da lata: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura da lata: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double volume = (pi * Math.Pow(raio, 2)) * altura;

        double volume_litros = volume / 1000;   

        Console.WriteLine("O volume da lata é: " + Math.Round(volume, 2) + " cm³ e " + Math.Round(volume_litros, 2) + " litros.");
    }
}