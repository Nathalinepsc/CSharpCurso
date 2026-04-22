namespace SaoBento.Dominio;

public class Funcionario
{
    public Guid Id { get; private set; }

    public Funcionario(string nome, DateTime dataNascimento, string cargo, decimal salario, string departamento)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        DataNascimento = dataNascimento;
        Cargo = cargo;
        Salario = salario;
        Departamento = departamento;
    }

    public string Nome { get; private set; }

    public DateTime DataNascimento { get; private set; }

    public string Cargo { get; private set; }

    public decimal Salario { get; private set; }

    public string Departamento { get; private set; }

    public int Idade
    {
        get
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - DataNascimento.Year;

            if (hoje.DayOfYear < DataNascimento.DayOfYear)
                idade--;

            return idade;
        }
    }

    public decimal SalarioAnual
    {
        get
        {
            return Salario * 13.3m;
        }
    }

    public void AlterarSalario(decimal novoSalario)
    {
        Salario = novoSalario;
    }

    public void AlterarCargo(string novoCargo)
    {
        Cargo = novoCargo;
    }

}
