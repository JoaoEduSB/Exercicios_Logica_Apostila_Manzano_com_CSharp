// Disciplina: Lógica de programação com C#
// Professor: Jailson
// Data: 04/06/2024
// b) Ler uma temperatura em graus Fahrenheit e apresentá-la convertida em
// graus Celsius. A fórmula de conversão é: C <- (F - 32) * (5/9) , sendo F a
// temperatura em Fahrenheit e C a temperatura em Celsius.

using System;

class ConverterFahrenheit {
    static void Main (string [] args) {
        Console.WriteLine("");

        Console.WriteLine("Vamos converter uma temperatura de Fahrenheit para Celsius");
        
        Console.WriteLine("");

        Console.Write("Digite a temperatura em graus F°: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine(fahrenheit + "° Fahrenheit é equivalente á: " + celsius + "° Celsius.");
        Console.WriteLine("");
    }
}