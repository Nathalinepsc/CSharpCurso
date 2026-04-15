int idade = 31;

bool a = (idade == 31);
Console.WriteLine("A idade é igual a 31? " + a);  

bool b = (idade != 31);
Console.WriteLine("A idade é diferente de 31? " + b);

bool c  = (idade > 31); 
Console.WriteLine("A idade é maior que 31? " + c);

bool d = (idade < 31);
Console.WriteLine("A idade é menor que 31? " + d);

bool e = (idade >= 18) && (idade <= 65);
Console.WriteLine("A idade é maior que 18 e menor que 65? " + e);

bool f = (idade >= 18) || (idade <= 65);
Console.WriteLine("A idade é maior que 18 ou menor que 65? " + f);

