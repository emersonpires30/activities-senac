using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;

int seguimentoA, seguimentoB, seguimentoC;

Console.WriteLine("Informe o seguimento A: ");
seguimentoA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o seguimento B: ");
seguimentoB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o seguimento C: ");
seguimentoC = Convert.ToInt32(Console.ReadLine());

if (seguimentoA < (seguimentoB + seguimentoC) &&
        seguimentoB < (seguimentoA + seguimentoC) &&
        seguimentoC < (seguimentoA + seguimentoB))

{
    Console.WriteLine("É possivel formar um triângulo.");
}
else
{
    Console.WriteLine(" Não é possivel formar um triângulo.");
}
if (seguimentoA == seguimentoB && seguimentoA == seguimentoC)
{
    Console.WriteLine(" Os seguimentos informados formam um triângulo: Equilátero (todos os lados iguais).");
}
else if (seguimentoA == seguimentoB || seguimentoA == seguimentoC || seguimentoB == seguimentoC)
{
    Console.WriteLine(" Os seguimentos informados formam um triangulo: Isosceles (Dois lados iguais).");
}

{
    Console.WriteLine("Os seguimentos informados formam um triangulo: Escalenno (Todos os lados diferentes).");
}
else if (seguimentoC < seguimentoA + seguimentoB)
{
    Console.WriteLine("seguimento C não é valido para ser um triangulo.");
}
else if (seguimentoB < seguimentoA + seguimentoC)
{
    Console.WriteLine("seguimento B não é valido para ser um triangulo.");
}
else if(seguimentoA < seguimentoB + seguimentoC)
{
    Console.WriteLine("seguimento A não é valido para ser um triangulo.");
}
