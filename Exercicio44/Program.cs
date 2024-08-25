

int primeiroValor = 1000, segundoValor = 1, incremento;

while (primeiroValor > segundoValor)
{

    Console.WriteLine("digite o primeiro valor: ");
    primeiroValor = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("digite o segundo valor: ");
    segundoValor = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("digite o incremento: ");
incremento = Convert.ToInt32(Console.ReadLine());

while (primeiroValor <= segundoValor)
{
    Console.Write(primeiroValor + " ");

    primeiroValor += incremento;
}

Console.Write("Acabou!");

