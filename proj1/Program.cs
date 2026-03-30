Console.WriteLine("Hello, World!");

Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();
Console.WriteLine($"Olá, {nome}, seja bem-vindo(a)!");
Console.WriteLine("Qual sua idade?");
string idadeInput = Console.ReadLine();
int idade;
if (int.TryParse(idadeInput, out idade))
    {
        Console.WriteLine($"{nome}, você tem {idade} anos.");
    }
else
    {
        Console.WriteLine("Idade inválida. Por favor, insira um número.");
    }
if (idade >= 18)
    {
        Console.WriteLine("E é maior de idade.");
    }
else
    {
        Console.WriteLine("E é menor de idade.");
    }


