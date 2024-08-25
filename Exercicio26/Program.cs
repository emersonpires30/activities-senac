int primeiroValor, segundoValor;

Console.WriteLine("Digite o primeiro número: ");
primeiroValor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
segundoValor = Convert.ToInt32(Console.ReadLine());

if (primeiroValor > segundoValor)
{
    Console.WriteLine("O primeiro valor é o maior");
}
else if(primeiroValor < segundoValor)
{
    Console.WriteLine("O segundo valor é o maior");
}
else
{
    Console.WriteLine("Não existe valor maior, os dois são iguais");
}