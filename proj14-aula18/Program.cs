using demo_video_18;

// Criando uma lista de pessoas
List<Pessoa> pessoas = new List<Pessoa>();
pessoas.Add(new Pessoa { Id = 1, Nome = "João", Idade = 18 });
pessoas.Add(new Pessoa { Id = 2, Nome = "Maria", Idade = 20 });
pessoas.Add(new Pessoa { Id = 3, Nome = "José", Idade = 25 });
pessoas.Add(new Pessoa { Id = 4, Nome = "Henrique", Idade = 30 });
pessoas.Add(new Pessoa { Id = 5, Nome = "Joana", Idade = 35 });

// Exibindo as pessoas
foreach(Pessoa p in pessoas)
{
    Console.WriteLine("Id: {0} - Nome: {1} - Idade: {2}", p.Id, p.Nome, p.Idade);
}

// Inserindo novas pessoas em posições específicas da lista
pessoas.Insert(2, new Pessoa { Id = 6, Nome = "Sara", Idade = 40 });
pessoas.Insert(0, new Pessoa { Id = 7, Nome = "Pam", Idade = 45 });
pessoas.Insert(4, new Pessoa { Id = 8, Nome = "James", Idade = 50 });

Console.WriteLine("Pessoas incluidas com Insert em posições específicas da lista.");
foreach(Pessoa p in pessoas)
{
    Console.WriteLine("Id: {0} - Nome: {1} - Idade: {2}", p.Id, p.Nome, p.Idade);
}

Console.WriteLine("Lista ordenada por Id:");
foreach(Pessoa p in pessoas.OrderBy(x => x.Id))
{
    Console.WriteLine("Id: {0} - Nome: {1} - Idade: {2}", p.Id, p.Nome, p.Idade);
}

// Exibindo a capacidade e o total de pessoas
pessoas.TrimExcess();
Console.WriteLine("Capacidade e total atual da lista:");
Console.WriteLine("Capacidade {0}", pessoas.Capacity);
Console.WriteLine("Total {0}", pessoas.Count);

// Filtrando as pessoas com idade maior que 30 e ordenando por idade
IEnumerable<Pessoa> pessoas2 = pessoas.Where(x => x.Idade > 30).OrderBy(x => x.Idade);

// Exibindo o total de idade das pessoas filtradas
int totalIdade = pessoas2.Sum(x => x.Idade);
Console.WriteLine("Total de Idade de pessoas com idade maior que 30: {0}", totalIdade);

// Exibindo as pessoas filtradas
Console.WriteLine("Pessoas com idade maior que 30:");
foreach(Pessoa p in pessoas2)
{
    Console.WriteLine("Id: {0} - Nome: {1} - Idade: {2}", p.Id, p.Nome, p.Idade);
}

// Exibindo a primeira pessoa com o nome "James"
Pessoa pessoaJames = pessoas.FirstOrDefault(x => x.Nome == "James");
Console.WriteLine("Primeira pessoa com o nome James:");
Console.WriteLine("Id: {0} - Nome: {1} - Idade: {2}", pessoaJames.Id, pessoaJames.Nome, pessoaJames.Idade);

// Listando os Ids das pessoas filtradas
List<int> numeros = pessoas2.Select(x => x.Id).ToList();
Console.WriteLine("Ids das pessoas com idade maior que 30:");
foreach(int n in numeros)
{
    Console.WriteLine(n);
}

// Exibindo o total de pessoas filtradas
Console.WriteLine("Total de pessoas filtradas: {0}", pessoas2.Count()); 

