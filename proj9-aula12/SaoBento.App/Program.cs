﻿// Desafio: Sistema de cadastro de Funcionários para a empresa São Bento
// O sistema deve permitir cadastrar funcionários, listar todos os funcionários, consultar a folha de pagamento,
// buscar um funcionário por nome, remover um funcionário e editar o salário ou cargo de um funcionário.
// Criado por: Nathaline Pryscila dos Santos Conde
// Curso de C#

using SaoBento.Dominio;
using SaoBento.App;

var service = new FuncionarioService();
var controller = new RHController(service);
string opcao;

do
{
    Console.WriteLine("============== MENU ==============");
    Console.WriteLine("1 - Cadastrar Funcionário");
    Console.WriteLine("2 - Listar Funcionários");
    Console.WriteLine("3 - Consultar Folha de Pagamento");
    Console.WriteLine("4 - Buscar Funcionário");
    Console.WriteLine("5 - Remover Funcionário");
    Console.WriteLine("6 - Editar Salário");
    Console.WriteLine("7 - Editar Cargo");
    Console.WriteLine("X - Sair");
    Console.WriteLine("==================================");
    Console.Write("Escolha uma opção: ");
    opcao = Console.ReadLine()?.ToUpper() ?? "";
    Console.WriteLine();

    switch (opcao)
    {
        case "1":
            controller.CadastrarFuncionario();
            break;

        case "2":
            controller.ListarFuncionarios();
            break;

        case "3":
            controller.MostrarFolhaPagamento();
            break;

        case "4":
            controller.BuscarFuncionario();
            break;

        case "5":
            controller.RemoverFuncionario();
            break;

        case "6":
            controller.EditarSalario();
            break;

        case "7":
            controller.EditarCargo();
            break;

        case "X":
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

} while (opcao != "X");
