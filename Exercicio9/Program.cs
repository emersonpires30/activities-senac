decimal valorReal, valorDolar, cambioDolar = 5.66M;

Console.WriteLine("Digite o valor em carteira em R$: ");
valorReal = Convert.ToDecimal(Console.ReadLine());

valorDolar = valorReal / cambioDolar;

Console.WriteLine("Você pode comprar $" + valorDolar);