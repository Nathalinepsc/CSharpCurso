using System.Linq;

namespace SaoBento.Dominio;

public class FuncionarioService
{
    private readonly List<Funcionario> _funcionarios = new();

    public void Adicionar(Funcionario funcionario)
    {
        _funcionarios.Add(funcionario);
    }

    public List<Funcionario> ObterTodos()
    {
        return _funcionarios;
    }

    public Funcionario? BuscarPorNome(string nome)
    {
        return _funcionarios
            .FirstOrDefault(f => f.Nome
            .ToLower()
            .Contains(nome.ToLower()));
    }

    public List<Funcionario> BuscarTodosPorNome(string nome)
    {
        return _funcionarios
            .Where(f => f.Nome.ToLower().Contains(nome.ToLower()))
            .ToList();
    }

    public List<Funcionario> ObterOrdenadosAZ()
    {
        return _funcionarios
            .OrderBy(f => f.Nome)
            .ToList();
    }

    public List<Funcionario> ObterOrdenadosZA()
    {
        return _funcionarios
            .OrderByDescending(f => f.Nome)
            .ToList();
    }

    public List<Funcionario> ObterOrdenadosPorId()
    {
        return _funcionarios
            .OrderBy(f => f.Id)
            .ToList();
    }

    public decimal CalcularFolha()
    {
        decimal total = 0;

        foreach (var f in _funcionarios)
        {
            total += f.Salario;
        }

        return total;
    }

    public void Remover(Funcionario funcionario)
    {
        _funcionarios.Remove(funcionario);
    }

    public void EditarSalario(Funcionario funcionario, decimal novoSalario)
    {
        funcionario.AlterarSalario(novoSalario);
    }

    public void EditarCargo(Funcionario funcionario, string novoCargo)
    {
        funcionario.AlterarCargo(novoCargo);
    }

    public bool Existe(string nome)
    {
        return _funcionarios.Any(f => f.Nome.ToLower() == nome.ToLower());
    }

}
