using BubbleSort;

Console.WriteLine("Ordenação com BubbleSort");

int[] arrNumbers =
    new int[] { 99, 50, -24, 0, 1 };

string[] arrStrings = new string[] { "Alan", "Daniel", "Julia", "Zebra" };

foreach (var number in arrNumbers)
    Console.Write($"[{number}]");


var arrOrdered = BubbleSortOrder.Sort<int>(
    arrNumbers
);

var arrStringOrdered = BubbleSortOrder.Sort<string>(
    arrStrings
);

Console.WriteLine("");
Console.WriteLine("*****************");
Console.WriteLine("Vetor Ordenado: ");
Console.WriteLine("");
foreach (var number in arrOrdered) 
    Console.Write($"[{number}]");

foreach (var strings in arrStrings)
    Console.Write($" [{strings}]");

    