decimal salario, percentualAumento = 0.15M, salarioFinal;

Console.WriteLine("Digite o seu salário:");
salario = Convert.ToDecimal(Console.ReadLine());

salarioFinal = salario + salario * percentualAumento;

Console.WriteLine("O seu novo salário é de: R$ " + salarioFinal);