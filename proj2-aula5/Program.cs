//Exercício, tirar o último caractere da frase
// string message = "Hello World!";
// string resultado = message.Substring(0, message.Length - 1);
// Console.WriteLine(resultado);

OperadoresAritimeticos();

static void OperadoresAritimeticos()
{
    int a = 5, b = 10, c = 15, d = 20;
    Console.WriteLine($"{a} + {b} = " + (a + b)); // Operação de Adição
    Console.WriteLine($"{a} - {b} = " + (a - b)); // Operação de subtração
    Console.WriteLine($"{a} * {b} = " + (a * b)); // Operação de multiplicação
    Console.WriteLine($"{a} / {b} = " + (a / b)); // Operação de divisão
    Console.WriteLine($"{a} % {b} = " + (a % b)); // Operação de modulo

    Console.WriteLine($"{a} + {b} * {c} = " + (a + b * c));
    Console.WriteLine($"({a} + {b}) * {c} = " + ((a + b) * c));
    Console.WriteLine($"{a} + {b} / {d} = " + (a + b / d));
    Console.WriteLine($"({a} + {b}) / {d} = " + ((a + b) / d));
}


OperadoresAtribuicaoAtribuicaoReduzida();

static void OperadoresAtribuicaoAtribuicaoReduzida()
{
  int mes = 5;
  mes += 1; // mes = mes + 1
    Console.WriteLine($"Mês: {mes}");
    mes++;
    Console.WriteLine($"Mês: {mes}");
    ++mes;
    Console.WriteLine($"Mês: {mes}");
    //-=. *=, /=, %=
    Console.WriteLine("Mês: " + ++mes);
}
