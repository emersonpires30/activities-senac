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