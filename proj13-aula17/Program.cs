// Aula 17 - Arrays

// Criando um array de inteiros e atribuindo valores
int[] arr1 = new int[5];
arr1[0] = 10;
arr1[1] = 20;
arr1[2] = 30;
arr1[3] = 40;
arr1[4] = 50;

for (int i = 0; i < arr1.Length; i++)
{
    Console.WriteLine("Primeiro Array: {0}", arr1[i]);
}

// Criando um segundo array e copiando os valores do primeiro array, depois invertendo a ordem dos elementos
int[] arr2 = new int[5];
Array.Copy(arr1, arr2, arr1.Length);
Array.Reverse(arr2);

foreach(int i in arr2)
{
    Console.WriteLine("Segundo Array: {0}", i);
}

// Criando um array de string e ordenando os nomes
string[] arr3 = new string[5] { "John", "James", "Sara", "Pam", "Henrique" };
Array.Sort(arr3);

foreach(string i in arr3)
{
    Console.WriteLine("Nomes no Array: {0}", i);
}

// Buscando um nome no array
Console.WriteLine("Digite um nome para buscar no array: ");
string nomeBuscar = Console.ReadLine();
int indexFind = Array.IndexOf(arr3, nomeBuscar);

if(indexFind == -1)
    Console.WriteLine("Nome não encontrado");
else
    Console.WriteLine("Nome procurado: {0} - Posição: {1}", nomeBuscar, indexFind);

// Criando um array com o tamanho definido pelo usuário
Console.WriteLine("Digite o tamanho do array: ");
int arrIndex = int.Parse(Console.ReadLine());
int[] arr4 = new int[arrIndex];

for (int i = 0; i < arrIndex; i++)
{
    Console.WriteLine("Digite um número para o array: ");
    arr4[i] = int.Parse(Console.ReadLine());
}

// Exibindo os valores do array criado pelo usuário
Console.WriteLine("Valores do array criado pelo usuário:");
foreach(int i in arr4)
{
    Console.WriteLine("Array: {0}", i);
}

