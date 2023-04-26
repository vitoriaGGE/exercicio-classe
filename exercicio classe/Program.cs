using exercicio_classe;

Pessoa p1, p2;

p1 = new Pessoa();
p2 = new Pessoa();

Console.Write("Informe aqui os dados da primeira pessoa.\r\nNome: ");
p1.Nome = Console.ReadLine();
Console.Write("Idade: ");
p1.Idade = int.Parse(Console.ReadLine());

Console.Write("Informe aqui os dados da segunda pessoa.\r\nNome: ");
p2.Nome = Console.ReadLine();
Console.Write("Idade: ");
p2.Idade = int.Parse(Console.ReadLine());

if (p1.Idade > p2.Idade)
{

    Console.WriteLine($"{p1.Nome} é mais velho(a) que {p2.Nome}!");

} else if (p1.Idade < p2.Idade)
{

    Console.WriteLine($"{p2.Nome} é mais velho(a) que {p1.Nome}!");

} else
{

    Console.WriteLine($"{p1.Nome} e {p2.Nome} tem a mesma idade!");

}