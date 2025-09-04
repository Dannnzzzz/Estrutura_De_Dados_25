using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que digite uma palavra
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        Stack<char> chars = new Stack<char>();
        foreach (var c in palavra)
            chars.Push(c);

        string palavra_invertida = string.Empty;
        while (chars.Count > 0)
        {
            char c = chars.Pop();
            palavra_invertida += c;
        }    
        if(palavra == palavra_invertida)
            Console.WriteLine("É um palindromo!");
        else
            Console.WriteLine("Não é um palindromo!");
    }
}
