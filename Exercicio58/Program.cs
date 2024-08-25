int idade, maiorIdade = 0, qtdeHomens = 0, IdadeMulherMaisJovem = 0, totalIdadeHomens = 0;
string continuar = "s", sexo;

while(continuar.ToUpper() == "S")
{
    Console.WriteLine("Digite seu sexo (M ou F):");
    sexo = Console.ReadLine();

    Console.WriteLine("Digite sua Idade");
    idade = Convert.ToInt32(Console.ReadLine());

    if(idade > maiorIdade)
    {
        maiorIdade = idade;
    }

    if(sexo.ToUpper() == "M")
    {
        qtdeHomens++;
        totalIdadeHomens += idade;
    }

    else
    {
        if(idade > IdadeMulherMaisJovem)
        {
            IdadeMulherMaisJovem = idade;
        }
    }

    Console.WriteLine("Deseja continuar informando? (S ou N)");
    continuar = Console.ReadLine();
}

Console.WriteLine("Qual é a maior idade lida: " + maiorIdade);
Console.WriteLine("Quantos homens foram cadastrados " + qtdeHomens);
Console.WriteLine("Qual é a idade da mulher mais jovem" + IdadeMulherMaisJovem);
Console.WriteLine("Qual é a media de idade entre os homens" + (totalIdadeHomens / qtdeHomens));
