﻿int contador = 0;
decimal preco, maiorValorDigitado = 0, menorValorDigitado = 0;

while(contador < 8)
{
    Console.WriteLine("Digite o valor do produto: ");
    preco = Convert.ToDecimal(Console.ReadLine());

    if(contador == 0)
    {
        maiorValorDigitado = preco;
        menorValorDigitado = preco;
    }

    if(preco > maiorValorDigitado)
    {
        maiorValorDigitado = preco;
    }

    if (preco < menorValorDigitado)
    {
        menorValorDigitado = preco;
    }

    contador++;
}

Console.WriteLine("O maior valor digitado foi: R$ " + maiorValorDigitado);
Console.WriteLine("O menor valor digitado foi: R$ " + menorValorDigitado);