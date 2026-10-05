/// Escreva um programa em C# que crie uma matriz bidimensional de números inteiros com dimensões 2x2. 
/// O programa deve utilizar estruturas de repetição (for aninhados) para pedir que o usuário 
/// digite os valores correspondentes a cada posição da matriz ([0,0], [0,1], [1,0] e [1,1]). 
/// Por fim, o programa deve exibir todos os números digitados organizados em formato de tabela na tela 
/// (com linhas e colunas bem definidas).

int[,] matriz = new int[2, 2];




for (int i = 0; i < 2; i++)
{
    

    for (int j = 0; j < 2; j++)
    {
        Console.Write($"Digite um número para a posição [{i},{j}]: ");
        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
    }


}


for (int i = 0;i < 2; i++)
{
    for(int j = 0;j < 2; j++)
    {
        Console.Write($"{matriz[i, j]}\t");
    }
    Console.WriteLine();
}
