int contador = 0, numero, quantidadePares = 0, quantidadeImpares = 0;

while (contador < 6)
{
    Console.WriteLine("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 0)
    {
        quantidadePares++;
    }
    else
    {
        quantidadeImpares++;
    }

    contador++;
}

Console.WriteLine(quantidadePares + "números são pares e " + quantidadeImpares + " números são impares");