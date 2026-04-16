// int c = 0;
// while (c <= 3)
// {
//     Console.WriteLine($"Dentro do while: c={c}");
//     c++;
// }

// int d = 0;
// do
// {
//     Console.WriteLine($"Dentro do do-while: d={d}");
//     d++;
// } while (d <= 3);

// int soma = 0;
// for (int i = 0; i < 3; i++)
// {
//     soma = soma + i;
// }
// Console.WriteLine($"Soma de 0 a 3: {soma}");

// int e;
// int f = 3;
// for (e = 0, Console.WriteLine($"Inicio: e={e}, f={f}"); e < f; e++, f--, Console.WriteLine($"Passo: e={e}, f={f}"))
// {
// }

// ------------------x-------------------
// Desafio: Criar um Menu com opção:
// 1 - Novo Funcionário (N)
// 2 - Listar Funcionários (L)
// 3 - Consultar Folha de Pagamento (C)
// 4 - Sair (X)


using System;
using System.Collections.Generic;

// Classe que representa o funcionário
class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        string opcao;

        do
        {
            Console.WriteLine("\n==============  MENU  =============");
            Console.WriteLine("N - Novo Funcionário");
            Console.WriteLine("L - Listar Funcionários");
            Console.WriteLine("C - Consultar Folha de Pagamento");
            Console.WriteLine("X - Sair");
            Console.WriteLine("===================================");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine().ToUpper();
            Console.WriteLine();

            switch (opcao)
            {
                case "N": // Lógica para cadastrar novo funcionário
                    CadastrarFuncionario(funcionarios);
                    break;

                case "L": // Lógica para listar funcionários
                    ListarFuncionarios(funcionarios);
                    break;

                case "C": // Lógica para consultar folha de pagamento
                    MostrarFolhaPagamento(funcionarios);
                    break;

                case "X":
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (opcao != "X");
    }


    // Método para cadastrar funcionário
    static void CadastrarFuncionario(List<Funcionario> funcionarios)
    {
        Console.Write("Digite o nome do funcionário: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o cargo do funcionário: ");
        string cargo = Console.ReadLine();

        Console.Write("Digite o salário do funcionário: ");
        double salario;
        while (!double.TryParse(Console.ReadLine(), out salario))
        {
            Console.Write("Digite um salário válido: ");
        }

        Funcionario novoFuncionario = new Funcionario
        {
            Nome = nome,
            Cargo = cargo,
            Salario = salario
        };

        funcionarios.Add(novoFuncionario);

        Console.WriteLine("Funcionário cadastrado com sucesso!");
    }


    // Método para listar funcionários
    static void ListarFuncionarios(List<Funcionario> funcionarios)
    {
        Console.WriteLine("===== LISTA DE FUNCIONÁRIOS =====");

        if (funcionarios.Count == 0)
        {
            Console.WriteLine("Nenhum funcionário cadastrado.");
            return;
        }

        foreach (Funcionario f in funcionarios)
        {
            Console.WriteLine($"Nome: {f.Nome} | Cargo: {f.Cargo} | Salário: {f.Salario:C}");
        }
    }


    // Método para calcular folha de pagamento
    static void MostrarFolhaPagamento(List<Funcionario> funcionarios)
    {
        Console.WriteLine("===== FOLHA DE PAGAMENTO =====");

        if (funcionarios.Count == 0)
        {
            Console.WriteLine("Nenhum funcionário cadastrado.");
            return;
        }

        double total = 0;

        foreach (Funcionario f in funcionarios)
        {
            total += f.Salario;
        }

        Console.WriteLine($"Total da folha de pagamento: {total:C}");
    }
}

