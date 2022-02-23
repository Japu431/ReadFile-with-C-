const string filePath = @"C:\Estudando-Estagio\Csharp\LerArquivos\test-file.txt";

// ReadAllText

var data = File.ReadAllText(filePath);
Console.WriteLine(data);

//ReadAllLines

var data2 = File.ReadAllLines(filePath);
var count = 0;
foreach (var line in data2)
{
    count++;
    System.Console.WriteLine($"Linha: {count} - {line}");
}

// StreamReader

using var file = new StreamReader(filePath);

string? line2;

while ((line2 = file.ReadLine()) != null)
{
    System.Console.WriteLine(line2);
}

file.Close();