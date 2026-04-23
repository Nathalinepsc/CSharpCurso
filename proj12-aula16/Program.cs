using System.Text;

string nome = "Nathaline";
string sobrenome = "Santos";
nome += " Pryscila";
nome += "dos";
nome += " " + sobrenome;
sobrenome = "Conde";
nome += " " + sobrenome;
Console.WriteLine($"Usando Strings: {nome}");

StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("Nathaline"); 
stringBuilder.Append(" "); 
stringBuilder.Append("Pryscila");
stringBuilder.Append(" ");
stringBuilder.Append("dos");
stringBuilder.Append(" ");
stringBuilder.Append("Santos");
stringBuilder.Append(" ");
stringBuilder.Append("Conde");
Console.WriteLine($"Usando StringBuilder: {stringBuilder.ToString()}");


// Comparando o desempenho
int iterations = 10000;
var watch = System.Diagnostics.Stopwatch.StartNew();
string result = "";

for (int i = 0; i < iterations; i++)
{    
    result += "Nathaline Pryscila dos Santos Conde";
}
watch.Stop();
Console.WriteLine($"Tempo usando Strings: {watch.ElapsedMilliseconds} ms");

watch.Restart();

StringBuilder sb = new StringBuilder();
for (int i = 0; i < iterations; i++)
{    
    sb.Append("Nathaline Pryscila dos Santos Conde"); 
}
watch.Stop();
Console.WriteLine($"Tempo usando StringBuilder: {watch.ElapsedMilliseconds} ms");
// O resultado pode variar dependendo do ambiente, mas geralmente o StringBuilder deve ser significativamente mais rápido do que a concatenação de strings usando o operador +, especialmente à medida que o número de iterações aumenta.


// Comparando ocupação na memoria
long stringMemory = System.Text.Encoding.Unicode.GetByteCount(result);
long stringBuilderMemory = System.Text.Encoding.Unicode.GetByteCount(sb.ToString());
Console.WriteLine($"Memória ocupada por Strings: {stringMemory} bytes");
Console.WriteLine($"Memória ocupada por StringBuilder: {stringBuilderMemory} bytes");
// O resultado pode variar dependendo do ambiente, mas geralmente o StringBuilder deve ocupar menos memória do que a concatenação de strings usando o operador +, especialmente à medida que o número de iterações aumenta.

// Em resumo, o StringBuilder é mais eficiente em termos de desempenho e uso de memória quando se trata de manipulação de strings, especialmente em cenários onde muitas concatenações são necessárias. O uso do operador + para concatenar strings pode levar a um aumento significativo no tempo de execução e no consumo de memória, enquanto o StringBuilder é projetado para lidar com essas operações de forma mais eficiente.
