string nome;
decimal salario;

Console.WriteLine("Nome do Funcionário:");
nome = Console.ReadLine();

Console.WriteLine("Salário:");
string salarioStr = Console.ReadLine();

//Convertendo uma string em decimal
salario = Convert.ToDecimal(salarioStr);

Console.WriteLine("O funcionário " + nome + "tem um salário de R$ " + salario + "em Agosto");

