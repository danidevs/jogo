using Jogo;
 
for (int i = 0; i < 2; i++)
{
    Console.Write("Digite o nome do herói: ");
    string? nome = Console.ReadLine();

    Console.Write("Digite a idade do herói: ");
    int idade;

               
    while (true)
    {
        string? idadeInput = Console.ReadLine(); 

        if (int.TryParse(idadeInput, out idade))
        {
            break; 
        }
        else
        {
            Console.Write("Entrada inválida. Por favor, digite uma idade válida: ");
        }
    }

    Console.Write("Digite o tipo do herói (guerreiro, mago, monge, ninja): ");
    string? tipo = Console.ReadLine(); 

    Heroi heroi = new Heroi
    {
        Nome = nome,
        Idade = idade,
        Tipo = tipo 
    };

    heroi.Atacar();
}
        