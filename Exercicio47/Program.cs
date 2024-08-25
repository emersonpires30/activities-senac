int contador = 0, numero, somatorio = 0;

while(contador < 7)
{
    Console.WriteLine("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    somatorio += numero;

    contador++;
}

Console.WriteLine("O valor final foi: " + somatorio);