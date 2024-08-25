decimal largura, comprimento, areaTotal;

Console.WriteLine("digite a largura do terreno: ");
largura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("digite o comprimento do terreno: ");
comprimento = Convert.ToDecimal(Console.ReadLine());

areaTotal = largura * comprimento;
string mensagem = "Area total: " + areaTotal + ".\nClassificação: ";
if(largura < 100)
{
    Console.WriteLine(mensagem + "TERRENO POPULAR");
}
else if(areaTotal <= 500)
{
    Console.WriteLine(mensagem + "TERRENO MASTER");
}
else
{
    Console.WriteLine(mensagem + "TERRENO VIP");
}