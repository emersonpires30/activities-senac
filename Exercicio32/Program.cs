/// Escreva um programa para aprovar ou não o empréstimo bancário para a compra
/// de uma casa. O programa vai perguntar o valor da casa, o salário do comprador e
/// em quantos anos ele vai pagar. Calcule o valor da prestação mensal, sabendo que
/// ela não pode exceder 30% do salário ou então o empréstimo será negado.
/// Console.WriteLine("Hello, World!");


double rendaBruta, valorImovel, prestacaoMensal;
int tempoFinanciamentoEmAnos;



Console.Write("Digite o valor da casa: R$ ");
valorImovel = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o seu salário: R$ ");
rendaBruta = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite em quantos anos você pretende pagar: ");
tempoFinanciamentoEmAnos = Convert.ToInt32(Console.ReadLine());


int numParcelas = tempoFinanciamentoEmAnos * 12;


prestacaoMensal = valorImovel / numParcelas;


double limitePrestacao = rendaBruta * 0.30;



if (prestacaoMensal <= limitePrestacao)
{
    Console.WriteLine($"Empréstimo aprovado! A prestação mensal será R$ {prestacaoMensal:F2}.");
}
else
{
    Console.WriteLine($"Empréstimo negado! A prestação mensal de R$ {prestacaoMensal:F2} excede 30% do seu salário.");

}