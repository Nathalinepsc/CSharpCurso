using SaoBento.Dominio;

namespace SaoBento.App;

public class RHController
{
    private readonly FuncionarioService _service;

    public RHController(FuncionarioService service)
    {
        _service = service;
    }

    public void CadastrarFuncionario()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine() ?? "";

        if (_service.Existe(nome))
        {
            Console.WriteLine("Funcionário já cadastrado!");
            return;
        }

        Console.Write("Data de Nascimento (dd/mm/aaaa): ");
        DateTime dataNascimento;
        while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
        {
            Console.Write("Data inválida. Digite novamente: ");
        }

        Console.Write("Cargo: ");
        string cargo = Console.ReadLine() ?? "";

        Console.Write("Salário: ");
        decimal salario;
        while (!decimal.TryParse(Console.ReadLine(), out salario) || salario <= 0)
        {
            Console.Write("Digite um salário válido (maior que zero): ");
        }

        Console.Write("Departamento: ");
        string departamento = Console.ReadLine() ?? "";

        var funcionario = new Funcionario(
            nome, 
            dataNascimento, 
            cargo, 
            salario, 
            departamento);

        _service.Adicionar(funcionario);

        Console.WriteLine("Funcionário cadastrado!");
    }

    private Funcionario? SelecionarFuncionario()
    {
        Console.Write("Digite parte do nome: ");
        var nome = Console.ReadLine() ?? "";

        var lista = _service.BuscarTodosPorNome(nome);

        if (lista.Count == 0)
        {
            Console.WriteLine("Nenhum funcionário encontrado.");
            return null;
        }

        Console.WriteLine("\nResultados:");

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {lista[i].Id.ToString()[..8]} | {lista[i].Nome} | {lista[i].Cargo}");
        }

        Console.Write("\nEscolha o número: ");
        int escolha;

        while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > lista.Count)
        {
            Console.Write("Opção inválida, tente novamente: ");
        }

        return lista[escolha - 1];
    }

    public void ListarFuncionarios()
    {
        Console.WriteLine("===== Como deseja ordenar? =====");
        Console.WriteLine("1 - Organizar de A → Z");
        Console.WriteLine("2 - Organizar de Z → A");
        Console.WriteLine("3 - Organizar por ID");

        string opcao;

        while (true)
        {
            Console.Write("Escolha: ");
            opcao = Console.ReadLine() ?? "";

            if (opcao == "1" || opcao == "2" || opcao == "3")
                break;

            Console.WriteLine("Opção inválida. Tente novamente.");
        }

        List<Funcionario> lista = new();

        switch (opcao)
        {
            case "1":
                lista = _service.ObterOrdenadosAZ();
                break;

            case "2":
                lista = _service.ObterOrdenadosZA();
                break;

            case "3":
                lista = _service.ObterOrdenadosPorId();
                break;
        }

        Console.WriteLine("\n===== Funcionários =====");

        if (lista.Count == 0)
        {
            Console.WriteLine("Nenhum cadastrado.");
            return;
        }

        foreach (var f in lista)
        {
            Console.WriteLine($"{f.Id.ToString()[..8]} - {f.Nome,-25} | {f.Cargo,-20} | {f.Departamento,-15} | {f.Idade,2} anos | {f.Salario,10:C}");
        }
    }

    public void MostrarFolhaPagamento()
    {
        var total = _service.CalcularFolha();
        Console.WriteLine($"Total da folha: {total:C}");
    }

    public void BuscarFuncionario()
    {
        var funcionario = SelecionarFuncionario();

        if (funcionario == null)
            return;

        Console.WriteLine("\nDetalhes:");
        Console.WriteLine($"{funcionario.Id.ToString()[..8]} - {funcionario.Nome,-25} | {funcionario.Cargo,-20} | {funcionario.Departamento,-15} | {funcionario.Idade,2} anos | {funcionario.Salario,10:C}");
    }

    public void RemoverFuncionario()
    {
        var funcionario = SelecionarFuncionario();

        if (funcionario == null)
            return;

        Console.Write($"Tem certeza que deseja remover {funcionario.Nome}? (S/N): ");
        var confirmacao = Console.ReadLine()?.ToUpper();

        if (confirmacao != "S")
        {
            Console.WriteLine("Operação cancelada.");
            return;
        }

        _service.Remover(funcionario);

        Console.WriteLine("Removido com sucesso!");
    }

    public void EditarSalario()
    {
        var funcionario = SelecionarFuncionario();

        if (funcionario == null)
            return;

        Console.Write("Novo salário: ");
        decimal salario;

        while (!decimal.TryParse(Console.ReadLine(), out salario))
        {
            Console.Write("Valor inválido: ");
        }

        _service.EditarSalario(funcionario, salario);

        Console.WriteLine($"Salário de {funcionario.Nome} atualizado para {salario:C}");
    }

    public void EditarCargo()
    {
        var funcionario = SelecionarFuncionario();

        if (funcionario == null)
            return;

        Console.Write("Novo cargo: ");
        var cargo = Console.ReadLine() ?? "";

        _service.EditarCargo(funcionario, cargo);

        Console.WriteLine("Cargo atualizado!");
    }

}
