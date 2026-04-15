Console.WriteLine($"Digite sua data de nascimento: ");
DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
int idade = DateTime.Now.Year - dataNascimento.Year;

Console.WriteLine($"Sua idade é: {idade.ToString()}");

if(idade < 18)
    Console.WriteLine("Menor de idade não pode trabalhar no BAR");
else if(idade >= 65)
    {
        Console.WriteLine("Não pode trabalhar no BAR");
    }
else
    Console.WriteLine("Opa pode ir para o RH");
