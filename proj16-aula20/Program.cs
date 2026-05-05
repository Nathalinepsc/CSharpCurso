// Curso de C# - Aula 20: Polimorfismo

Empregado gerente = new Gerente("João", "Silva", "123.456.789-00", 1000.30m, 0.5m);
Empregado atendente = new Atendente("Henrique", "Souza", "123.456.789-00", 800.30m);

List<Empregado> empregados = new List<Empregado>();
empregados.Add(gerente);
empregados.Add(atendente);


foreach (Empregado emp in empregados)
{
    Console.WriteLine(new string('-', 80));

    ExibirEmpregado(emp);

    if (emp is Gerente g)
    {
        Console.WriteLine("\n>> Aplicando aumento de salário para gerente...\n");
        g.AumentarSalario();
        Console.WriteLine("Salário atualizado:");
        ExibirEmpregado(g);
    }

    if (emp is Atendente a)
    {
        Console.WriteLine("\n>> Atendente não recebe aumento de salário, apenas bonificação.");
    }

}

decimal totalBonificacao = 0;

foreach (Empregado emp in empregados)
{
    totalBonificacao += emp.GetBonificacao();
}

Console.WriteLine(new string('-', 80));
Console.WriteLine($"Total de Bonificações: {totalBonificacao:F2}");
Console.WriteLine(new string('-', 80));
Console.WriteLine("Fim do processamento!");

static void ExibirEmpregado(Empregado emp)
{
    Console.WriteLine(emp);
}
