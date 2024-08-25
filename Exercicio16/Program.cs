int anosFumando, quantidadeCigarrosPorDia, TotalDiasPerdidos;

Console.WriteLine("Digite a quantidade de cigarros fumados por dia: ");
quantidadeCigarrosPorDia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantos anos você fuma: ");
anosFumando = Convert.ToInt32(Console.ReadLine());

TotalDiasPerdidos = (((anosFumando * 365) * quantidadeCigarrosPorDia) * 10) / 1440;

Console.WriteLine("Você perdeu: " + TotalDiasPerdidos + TotalDiasPerdidos + "dias da sua vida.");