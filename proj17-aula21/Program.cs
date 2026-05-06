using System;
using System.IO;

string pasta = "dados";
string arquivo = "alunos.txt";

// Path
string pathCompleto = Path.Combine(pasta, arquivo);
Console.WriteLine(pathCompleto);
Console.WriteLine($"Caminho: {pathCompleto}");
Console.WriteLine($"Nome do arquivo: {Path.GetFileName(pathCompleto)}");
Console.WriteLine($"Extensão do arquivo: {Path.GetExtension(pathCompleto)}");
Console.WriteLine($"Diretório: {Path.GetDirectoryName(pathCompleto)}");
Console.WriteLine($"Nome sem extensão: {Path.GetFileNameWithoutExtension(pathCompleto)}");


// Diretorios
if(!Directory.Exists(pasta))
{
   Directory.CreateDirectory(pasta);
   Console.WriteLine($"Diretório {pasta} criado com sucesso!");
}
else
{
   Console.WriteLine($"Diretório {pasta} já existe.");
}


// Listar arquivos do diretório
string[] arquivos = Directory.GetFiles(pasta);
Console.WriteLine($"Arquivos encontrados em {pasta}:");
foreach (string arquivoPasta in arquivos)
{
   Console.WriteLine(Path.GetFileName(arquivoPasta));
}

if(!File.Exists(pathCompleto))
{
   File.WriteAllText(pathCompleto, "Olá alunos! Estamos aprendendo System.IO em C#.");
   Console.WriteLine($"Arquivo {arquivo} criado com sucesso em {pasta}.");
}
else
{
   File.AppendAllText(pathCompleto, Environment.NewLine + "Nova linha adicionada ao arquivo.");
   Console.WriteLine($"Arquivo {arquivo} já existe. Nova linha adicionada.");
}

using StreamWriter Writer = new StreamWriter(pathCompleto, append: true);
{
    Writer.WriteLine("Lista de alunos:");
    Writer.WriteLine("--------------------");
    Writer.WriteLine("1. João");
    Writer.WriteLine("2. Maria");
    Writer.WriteLine("3. Pedro");
    Writer.WriteLine("4. Ana");
    Writer.WriteLine("--------------------");
    Writer.WriteLine("Fim da lista de alunos.");
    Writer.Close();
}


if(File.Exists(pathCompleto))
{
    using StreamReader reader = new StreamReader(pathCompleto);
    string? linha;

    while ((linha = reader.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }
}