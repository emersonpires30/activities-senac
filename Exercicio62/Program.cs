int multiplicando;

Console.WriteLine("Digite um número da tabuada:");
multiplicando = Convert.ToInt32(Console.ReadLine());

for(int contador = 1; contador <= 10; contador++)
{
    Console.WriteLine(multiplicando + " x " + contador + " = " + (multiplicando * contador));
}