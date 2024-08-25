string nome;
decimal salario, salarioReajustado;
int anosEmpresa;

Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite seu salario atual: ");
salario = Convert.ToDecimal(Console.ReadLine());


Console.WriteLine("Digite a quantidade de anos que trabalha na empresa: ");
anosEmpresa = Convert.ToInt32(Console.ReadLine());

if(anosEmpresa <3)
{
    salarioReajustado = salario + (salario * 0.03M);
}
else if(anosEmpresa < 10)
{
    salarioReajustado = salario + (salario * 0.125M);
}
else
{
    salarioReajustado = salario + (salario * 0.2M);
}
Console.WriteLine(nome + "seu novo salario é de: R$ " + salarioReajustado);