// Passando valores para métodos por valor
int numero1 = 10;
int numero2 = 20;

SomarNumeros(numero1, numero2); // O valor de numero1 e numero2 é copiado para o método, e qualquer alteração dentro do método não afetará as variáveis originais

static void SomarNumeros(int numero1, int numero2)
{
    int resultado = numero1 + numero2; 
    Console.WriteLine($"Resultado da soma ({numero1} + {numero2}): {resultado}");
}



// Passando valores para métodos por referencia 
int numero1Ref = 10;
int numero2Ref = 20;

Console.WriteLine($"Resultado metódo Ref ({numero1Ref} + {numero2Ref}): {SomarNumeroComRef(numero1Ref, ref numero2Ref)}");
Console.WriteLine($"Valor atribuido a variavel de Ref: {numero2Ref}");

static int SomarNumeroComRef(int numero1, ref int numero2)
{
    int resultado = numero1 + numero2;
    numero2 = 10000;
    return resultado; // O valor de numero2 é atribuído dentro do método e pode ser usado fora do método
}



// Passando valores para métodos por output
int numero1Out = 10;
int numero2Out = 20;

Console.WriteLine($"Resultado metodo Out ({numero1Out} * 10): {SomarNumeroComOut(numero1Out, out numero2Out)}");
Console.WriteLine($"Valor atribuido a variavel de output: {numero2Out}");

static int SomarNumeroComOut(int numero1, out int numero2)
{
    int resultado = numero1 * 10;
    numero2 = 30;
    return resultado; // O valor de numero2 é atribuído dentro do método e pode ser usado fora do método
}



// Passando valores para métodos por in
int numero1In = 10;
int numero2In = 20;

ParametroComIn(numero1In, numero2In); // O valor de numero1In e numero2In é copiado para o método, mas o parametro numero2 é somente leitura, ou seja, não pode ser modificado dentro do método

static void ParametroComIn(int numero1, in int numero2)
{
    // numero2 = 30; // Isso causaria um erro de compilação, pois o metodo In é um parametro somente leitura
    int resultado = numero1 + numero2;
    Console.WriteLine($"Resultado do calculo do metodo In ({numero1} + {numero2}): {resultado}");
}



