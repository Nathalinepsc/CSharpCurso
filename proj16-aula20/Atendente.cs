public class Atendente : Empregado
{
  public Atendente(string nome, string sobrenome, string cpf, decimal salario):base(nome, sobrenome, cpf, salario)
  {
    
  }
    override public decimal GetBonificacao()
    {
      return Salario * 0.01m;
    }
}

