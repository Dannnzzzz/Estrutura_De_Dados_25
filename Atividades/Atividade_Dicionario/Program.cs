using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var dados = new Dictionary<string,string>();

        while (true)
        {
            Console.Write("\n1-Adicionar  2-Buscar  3-Sair: ");
            var op = Console.ReadLine();

            if (op == "1")
            {
                Console.Write("Código de rastreio: ");
                var r = Console.ReadLine();
                Console.Write("Código de barras: ");
                var b = Console.ReadLine();

                if (dados.ContainsKey(r) || dados.ContainsValue(b))
                    Console.WriteLine("❗ Código já registrado.");
                else
                {
                    dados[r] = b;
                    Console.WriteLine("✔ Registro salvo.");
                }
            }
            else if (op == "2")
            {
                Console.Write("Buscar por rastreio ou barras: ");
                var busca = Console.ReadLine();

                if (dados.ContainsKey(busca))
                    Console.WriteLine($"✔ Rastreio encontrado → Barras: {dados[busca]}");
                else if (dados.ContainsValue(busca))
                    foreach (var x in dados)
                        if (x.Value == busca)
                            Console.WriteLine($"✔ Barras encontrado → Rastreio: {x.Key}");
                else
                    Console.WriteLine("❗ Nada encontrado.");
            }
            else if (op == "3") break;
        }
    }
}
