// Aula 19 - Propriedades
// Propriedades são membros de uma classe que fornecem uma maneira flexível de ler, gravar ou calcular os valores de campos privados. 
// Elas são usadas para proteger os dados e garantir que as regras de negócios sejam aplicadas corretamente.

Funcionarios funcionario = new Funcionarios("João Carlos", 1000, 1234, new DateTime(1981, 1, 1));

Console.WriteLine($"Nome: {funcionario.Nome}");
Console.WriteLine($"Idade: {funcionario.Idade}");
Console.WriteLine($"Salário: {funcionario.Salario:C}");

