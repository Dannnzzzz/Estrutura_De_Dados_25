string[,] tab = { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
string jogador = "X";
bool fim = false;

while (!fim)
{
    Console.Clear();
    Console.WriteLine(tab[0, 0] + "|" + tab[0, 1] + "|" + tab[0, 2]);
    Console.WriteLine("-+-+-");
    Console.WriteLine(tab[1, 0] + "|" + tab[1, 1] + "|" + tab[1, 2]);
    Console.WriteLine("-+-+-");
    Console.WriteLine(tab[2, 0] + "|" + tab[2, 1] + "|" + tab[2, 2]);

    Console.Write("Linha (0-2): ");
    int l = int.Parse(Console.ReadLine());
    Console.Write("Coluna (0-2): ");
    int c = int.Parse(Console.ReadLine());

    if (tab[l, c] == " ")
        tab[l, c] = jogador;
    else
    {
        Console.WriteLine("Posição ocupada! ENTER...");
        Console.ReadLine();
        continue;
    }

    if ((tab[0,0]==jogador && tab[0,1]==jogador && tab[0,2]==jogador) ||
        (tab[1,0]==jogador && tab[1,1]==jogador && tab[1,2]==jogador) ||
        (tab[2,0]==jogador && tab[2,1]==jogador && tab[2,2]==jogador) ||
        (tab[0,0]==jogador && tab[1,0]==jogador && tab[2,0]==jogador) ||
        (tab[0,1]==jogador && tab[1,1]==jogador && tab[2,1]==jogador) ||
        (tab[0,2]==jogador && tab[1,2]==jogador && tab[2,2]==jogador) ||
        (tab[0,0]==jogador && tab[1,1]==jogador && tab[2,2]==jogador) ||
        (tab[0,2]==jogador && tab[1,1]==jogador && tab[2,0]==jogador))
    {
        Console.Clear();
        Console.WriteLine(tab[0, 0] + "|" + tab[0, 1] + "|" + tab[0, 2]);
        Console.WriteLine("-+-+-");
        Console.WriteLine(tab[1, 0] + "|" + tab[1, 1] + "|" + tab[1, 2]);
        Console.WriteLine("-+-+-");
        Console.WriteLine(tab[2, 0] + "|" + tab[2, 1] + "|" + tab[2, 2]);
        Console.WriteLine("Jogador " + jogador + " venceu!");
        fim = true;
    }
    else
    {
        jogador = (jogador == "X") ? "O" : "X";
    }
}
