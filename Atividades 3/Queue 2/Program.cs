using System.Collections.Generic;

Console.WriteLine(
    "Invertendo palavras com pilhas (Stacks)"
);

Stack<char> chars = new Stack<char>();
foreach (var c in "MEU NOME")
    chars.Push(c);

while(chars.Count > 0)
    Console.WriteLine(chars.Pop());

Console.WriteLine("")