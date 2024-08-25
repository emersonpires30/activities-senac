decimal salario, totalSalarioHomens = 0, totalSalarioMulheres = 0;
string sexo, continuar = "S";

while(continuar.ToUpper() == "S")
{
    Console.WriteLine("Digite o seu sexo (M ou F):");
    sexo = Console.ReadLine();

    Console.WriteLine("Digite o seu salario:");
    salario = Convert.ToDecimal(Console.ReadLine());

    if(sexo.ToUpper() == "M")
    {
        totalSalarioHomens += salario;
    }
    else
    {
        totalSalarioMulheres += salario;
    }

    Console.WriteLine("Deseja continuar informando? (S ou N)");
    continuar = Console.ReadLine();
}

Console.WriteLine("O total de salário dos homens foi: R$ " + totalSalarioHomens);
Console.WriteLine("O total de salário das mulheres foi: R$ " + totalSalarioMulheres);