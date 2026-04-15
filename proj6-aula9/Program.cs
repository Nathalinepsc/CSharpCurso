float f = 3.14f;

switch (f)
{
    case 1.0f:
        Console.WriteLine("O Valor é 1.0f");
        break;
    case 2.0f:
        Console.WriteLine("O Valor é 2.0f");
        break;
    case float.NaN:
        Console.WriteLine("O Valor é NaN");
        break;
    default:
        Console.WriteLine("O Valor não é reconhecido Default");
        break;
}


Console.WriteLine(RetornarEstacaoDoAno(DateTime.Now)); // Output: "Outono", "Primavera", "Inverno" ou "Verão" dependendo do mês atual
Console.WriteLine(RetornarEstacaoDoAno(new DateTime(2026, 8, 1))); // Output: "Inverno"
Console.WriteLine(RetornarEstacaoDoAno(new DateTime(2026, 11, 1))); // Output: "Primavera"
Console.WriteLine(RetornarEstacaoDoAno(new DateTime(2027, 1, 1))); // Output: "Verão"


static string RetornarEstacaoDoAno(DateTime data) => data.Month switch
{
    >= 3 and < 6 => "Outono",
    >= 6 and < 9 => "Inverno",
    >= 9 and < 12 => "Primavera",
    12 or (>= 1 and < 3) => "Verão",
    _ => "Erro"
};



