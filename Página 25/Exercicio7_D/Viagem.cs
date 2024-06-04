// Disciplina: Lógica de programação com C#
// Professor: Jailson
// Data: 04/06/2024
// d) Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz 12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto (TEMPO) e a velocidade média (VELOCIDADE) durante a viagem. Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA <- TEMPO * VELOCIDADE. Possuindo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a fórmula LITROS_USADOS <- DISTANCIA / 12. Ao final, o programa deve apresentar os valores da velocidade média (VELOCIDADE),tempo gasto na viagem (TEMPO), a distancia percorrida (DISTANCIA) e a quantidade de litros (LITROS_USADOS) utilizada na viagem.

using System;

class Viagem {
    static void Main (string [] args) {
        Console.WriteLine("");

        Console.WriteLine("Vamos calcular a quantidade de litros de combustível gastos na viagem");

        Console.WriteLine("");

        Console.Write("Digite o tempo da viagem em horas: ");
        int tempo_gasto = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a velocidade média em Km/h: ");
        int veloc_media = Convert.ToInt32(Console.ReadLine());

        int distancia = tempo_gasto * veloc_media;

        double litros_usados = distancia / 12;

        Console.WriteLine("");

        Console.WriteLine("A velocidade média do veículo foi: " + veloc_media + " Km/h");
        Console.WriteLine("O tempo gasto na viagem foi: " + tempo_gasto + " Horas");
        Console.WriteLine("A distância percorrida foi: " + distancia + " Km");
        Console.WriteLine("A quantidade de combustível usado foi: " + Math.Round(litros_usados, 1) + " Litros.");
        
        Console.WriteLine("");
    }
}