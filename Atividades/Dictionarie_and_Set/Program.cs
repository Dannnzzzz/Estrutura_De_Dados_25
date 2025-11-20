using System;
using System.Collections;

// A tabela hash é baseada no conceito de par chave- valor 
// a chave é a forma de se acessar o respectivo valor e por ser chave deve ser única.
Hashtable ht = new Hashtable() { { "Mauricio", "123" }, { "Joao", "456" } };

// uma forma de adicionar um novo par
ht["Mauricio Mattar"] = "789";

ht.Add("Mauricio de Nassau", "666");

// Verificar se existem pares chave-valor na tabela hash
if (ht.Count > 0)
{
    // Percorrer os pares armazenados
    foreach (DictionaryEntry entry in ht)
    {
        Console.WriteLine($"Chave: {entry.Key}, valor: {entry.Value}");
    }
}
else
{
    Console.WriteLine("Tabela Hash vazia!");
}

// Vimos que ao adicionar uma chave repetida à Hashtable
// o programa crasha; para evitar isso, usamos try/catch
try
{
    // tentativa de adicionar chave duplicada
    ht.Add("Mauricio de Nassau", "666");
}
catch (ArgumentException ex2)
{
    Console.WriteLine("Chave já existente. Não é possível adicionar chaves duplicadas.");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}
finally
{
    Console.WriteLine("Agora acabou.");
}

// Agora o usuario vai informar
Console.WriteLine("informe a chave: ");
string key = Console.ReadLine();
Console.WriteLine("informa o valor: ");
string value = Console.ReadLine();

try{
    ht.Add(key, value);
    Console.WriteLine("Par chave-valor adicionado com sucesso.");
}
catch
{
    Console.WriteLine("Não foi possível adicionar o par chave-valor. A chave já existe.");  
}

// Agora faremos uma busca na tabela hash
Console.WriteLine("Informe a chave para busca: ");
string search = Console.ReadLine();

if (ht.Contains(search))
    Console.WriteLine($"Valor encontrado: {search}, {ht[search]}");

else
{
    Console.WriteLine("Chave não encontrada.");
}
