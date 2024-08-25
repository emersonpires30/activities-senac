using System;

string sexo;
decimal peso;
int qtdeMulheres, qtdeHomensMais100Kg, totalPesoMulheres, maiorPesoHomens;

for(int cont = 1; cont <= 8; cont++)
{
    Console.WriteLine("Digite o seu sexo");
    sexo = Console.ReadLine();
    Console.WriteLine("Digite o seu peso");
    peso = Convert.ToDecimal(Console.ReadLine());

    if(peso > 100)
    {
        qtdeHomensMais100Kg++;
    }
    if(maiorPesoHomens < peso)
    {
        maiorPesoHomens = peso;
    }
    else
    {
        qtdeMulheres++;
        totalPesoMulheres += peso;
    }
}

Console.WriteLine("Quantas mulheres foram cadastradas: " + qtdeMulheres);
Console.WriteLine("Quantos homens pesam mais de 100kg: " + qtdeHomensMais100Kg);
Console.WriteLine("A média de peso entre as mulheres " + (totalPesoMulheres / qtdeMulheres));
Console.WriteLine("O maior peso entre os homens " + maiorPesoHomens);

