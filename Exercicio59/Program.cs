int idade, idadePessoaMaisVelha = 0, idadeMulherMaisJovem = 999, totalIdades = 0, quantidade = 0,
    qtdeHomensMais30anos = 0, qtdeMulheresMenos18Anos = 0;
string continuar = "s", sexo, nome, nomePessoaMaisVelha = "", nomeMulheresMaisJovem = "";

while(continuar.ToUpper() == "S")
{
    Console.WriteLine("Digite o seu nome");
    nome = Console.ReadLine();

    Console.WriteLine("Digite seu sexo (M ou F):");
    sexo = Console.ReadLine();

    Console.WriteLine("Digite sua Idade");
    idade = Console.ReadLine();

    if(idade > idadePessoaMaisVelha)
    {
        nomePessoaMaisVelha = nome;
        idadePessoaMaisVelha = idade;
    }

    if(sexo.ToUpper() == "F")
    {
        nomeMulheresMaisJovem = nome;
        idadeMulherMaisJovem = idade;
    }

    if(idade < 18)
    {
        qtdeMulheresMenos18Anos++;
    }
    else
    {
        if(idade > 30)
        {
            qtdeHomensMais30anos++;
        }
    }

    totalIdades += idade;
    quantidade++;

    Console.WriteLine("Deseja continuar informando? (S ou N)
}
