int idade =0, totalIdades = 0, qtdeAlunos = 0;

while(idade != 999)
{
    totalIdades += idade;
    qtdeAlunos++;

    Console.WriteLine("Digite sua idade");
    idade = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("O total de alunos é de: " + qtdeAlunos);
Console.WriteLine("A media de idade na turma é de: " + (totalIdades / qtdeAlunos));