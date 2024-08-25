int contador = 0, idade = 0, qtMulheres = 0, qtdeHomens = 0, mediaIdade = 0, mediaIdadeHomens = 0, qtdeMulheresMais20 = 0;
string sexo = "";

while(contador < 5)
{
    Console.WriteLine("Digite sua idade: ");
    sexo = Console.ReadLine();

    if(sexo.ToUpper() == "F")
    {
        qtMulheres++;

        if(idade > 20)

        {
            qtdeMulheresMais20++;

        }
    }
    else
    {
        qtdeHomens++;
        mediaIdadeHomens += idade;

    }

    mediaIdade += idade;

    contador++;

}

Console.WriteLine("Quantos homens cadastrados: " + qtdeHomens);
Console.WriteLine("Quantas mulheres foram cadastradas: " + qtMulheres);
Console.WriteLine("A media de idade do grupo: " + (mediaIdade / 5));
Console.WriteLine("A média de idade dos homens: " + (mediaIdade / qtdeHomens));
Console.WriteLine("Quantas mulheres tem mais de 20 anos: " + qtdeMulheresMais20);

