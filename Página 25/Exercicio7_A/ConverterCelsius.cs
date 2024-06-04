// Disciplina: Lógica de programação com C#
// Professor: Jailson
// Data: 04/06/2024
// a) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus
// Fahrenheit. A fórmula de conversão F° = (9 * C + 160) / 5, sendo F a
// temperatura em Fahrenheit e C a temperatura em Celsius.

using System;

class ConverterCelsius {
    static void Main (string [] args) {
        Console.WriteLine("");

        Console.WriteLine("Vamos converter uma temperatura de Celsius para Fahrenheit");
        
        Console.WriteLine("");

        Console.Write("Digite a temperatura em graus C°: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (9 * celsius + 160) / 5;

        Console.WriteLine(celsius + "° Celsius é equivalente á: " + fahrenheit + "° Fahrenheit.");
        Console.WriteLine("");
    }
}