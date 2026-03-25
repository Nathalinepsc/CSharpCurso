using System.IO.Compression;

Console.WriteLine("------------------------------------------------");
Console.WriteLine("Hello, World!");
Console.Write("Olá, Mundo!");
Console.WriteLine("");
Console.WriteLine("Estou aprendendo C# no VS Code.");
Console.WriteLine("------------------------------------------------");

string nome = "Nathaline";
int idade = 31;
Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos.");

void Saudacao(string apelido, int numero)
{
    Console.WriteLine($"Meu apelido: {apelido}, {numero}");
}
Saudacao("Nine", 9);

if (idade >= 18)
{
    Console.WriteLine($"Eu já sou Maior de idade");
}
else
{
    Console.WriteLine($"Eu ainda não sou Maior de idade");
}
bool possuiCnh = true;
Console.WriteLine($"Eu ainda não tenho CNH (false ou true): {possuiCnh}");

string cor = "vermelho";
switch (cor)
{
    case "azul":
        Console.WriteLine("Minha cor favorita: Azul");
        break;
    case "rosa":
        Console.WriteLine("Minha cor favorita: Rosa");
        break;
    case "vermelho":
         Console.WriteLine("Minha cor favorita: Vermelho");
        break;
    default:
        Console.WriteLine("Minha cor favorita: Outra cor");
        break;
}

Console.Write("Minhas frutas favoritas:");
string[] frutas = {"Melancia", "Banana", "Morango", "Melão"};
foreach (string fruta in frutas)
{
    Console.Write($" {fruta}");
}
Console.WriteLine(".");

Console.WriteLine("------------------------------------------------");

float float1 = 10.1f;
double double1 = 10.1;
decimal decimal1 = 10.1m;
Console.WriteLine($"float 4bts: {float1}");
Console.WriteLine($"double 8bts: {double1}");
Console.WriteLine($"decimal 16bts: {decimal1}");

char letra = 'A';
Console.WriteLine($"letra char: {letra}");

var variavel = 15;
Console.WriteLine($"variavel dinamica var: {variavel}");

int num1 = 10;
int num2 = 20;
Console.WriteLine($"soma: {num1 + num2}");
Console.WriteLine($"subtração: {num1 - num2}");
Console.WriteLine($"multiplicação: {num1 * num2}");
Console.WriteLine($"divisao: {num2 / num1}");
Console.WriteLine($"modulo resto de divisão: {num2 % num1}");

int num3 = 10;
int num4 = 10;

if (num3 == num4)
{
    Console.WriteLine($"comparação: É igual.");  
}

int num5 = 15;
int num6 = 10;

if (num5 != num6)
{
    Console.WriteLine($"comparação: É diferente.");  
}

if (num5 > num6)
{
    Console.WriteLine($"comparação: É maior.");  
}

if (num6 < num5)
{
    Console.WriteLine($"comparação: É menor.");  
}

if (num5 >= num6)
{
    Console.WriteLine($"comparação: É maior ou igual.");  
}

if (num6 <= num5)
{
    Console.WriteLine($"comparação: É menor ou igual.");  
}

bool booleana1 = true;
bool booleana2 = true;

if (booleana1 && booleana2)
{
    Console.WriteLine($"Operador E (&&)");  
}

bool booleana3 = true;
bool booleana4 = false;

if (booleana3 || booleana4)
{
    Console.WriteLine($"Operador OR (||)");  
}

bool booleana5 = false;

if (!booleana5)
{
    Console.WriteLine($"Operador de negação (!)");
}


for (int i = 0; i <= 5; i ++)
{
    Console.WriteLine($"Número (for 0 a 5): {i}");
}

int j = 0;
while (j <= 5)
{
    Console.WriteLine($"Número (while 0 a 5): {j}");
    j++;
}

int j2 = 0;
do
{
    Console.WriteLine($"Número (do e while 0 a 5): {j2}");
    j2++;
} while (j2 < 6);

int[] numeros = {0, 1, 2, 3, 4, 5};
foreach (int numero in numeros)
{
    Console.WriteLine($"Número (Foreach 0 a 5): {numero}");
}

