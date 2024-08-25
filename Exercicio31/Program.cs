/// Crie um jogo de JoKenPo (Pedra-Papel-Tesoura)

String? jogador1, jogador2;

Console.WriteLine("Bem-vindo ao JokenPo\n\n");
Console.WriteLine("Escolha entre uma das opcões: 'Pedra', 'Papel', 'Tesoura'\n\n");
Console.Write("Jogador 1: ");

jogador1 = Console.ReadLine();
Console.Write("\nJogador 2: ");
jogador2 = Console.ReadLine();
Console.WriteLine("\n ---------------------- \n");

if (jogador1 == jogador2)
{
    Console.WriteLine("Empate!");
}
else if (jogador1 == "Pedra")
{
    if (jogador2 == "Tesoura")
    {
        Console.WriteLine("Jogador 1 Venceu!");
    }
    else
    {
        Console.WriteLine("Jogador 2 Venceu!");
    }
}
else if (jogador1 == "Tesoura")
{
    if (jogador2 == "Pedra")
    {
        Console.WriteLine("Jogador 2 Venceu!");
    }
    else
    {
        Console.WriteLine("Jogador 1 Venceu!");
    }
}
else
{
    if (jogador2 == "Pedra")
    {
        Console.WriteLine("Jogador 1 Venceu!");
    }
    else
    {
        Console.WriteLine("Jogador 2 Venceu!");
    }
}

