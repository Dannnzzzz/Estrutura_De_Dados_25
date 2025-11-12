using System;

class Program
{
    static void Main()
    {
    
        string[] vetor = new string[10]
        {
            "carlos",
            "Bruno",
            "Daniel",
            "Gomig",
            "Piva",
            "Fernandinha",
            "Gabriel",
            "Helena",
            "Igor",
            "Juliana"
            "1"
            "2"
            "3"
            "4"
            "5"
            "6"
            "7"




        };

    
        Console.WriteLine("Digite um nome ou número para buscar:");
        string busca = Console.ReadLine();

        
        bool encontrado = false;

        
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i].Equals(busca, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Encontrado! '{busca}' está na posição {i} do vetor.");
                encontrado = true;
                break; 
            }
        }

    
        if (!encontrado)
        {
            Console.WriteLine("Não encontrado.");
        }

        
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
