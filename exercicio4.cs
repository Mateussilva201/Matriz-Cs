/// Desenvolva um programa em C# que Crie uma matriz original de 2 linhas e 3 colunas preenchida com valores inteiros via teclado.
/// Em seguida, gere e exiba a matriz transposta (que terá inversamente 3 linhas e 2 colunas),
/// onde as linhas da matriz original se transformam nas colunas da nova matriz (transposta[j, i] = original[i, j]).
/// 
int[,] matriz = new int[2,3];
int numeroDigitado;

for (int i = 0; i < 2; i++)
{
for (int j = 0; j < 3; j++)
    {
        Console.Write($"Digite um número para a posição [{i},{j}]: ");
        matriz[i,j] = Convert.ToInt32(Console.ReadLine());

        Console.Write($"{matriz[i, j]}");

    }

}


int[,] transposta = new int[3,2];

for (int i = 0; i < 2; i++)
{
    for (int j = 0;j < 3; j++)
    {
        transposta[j, i] = matriz[i, j];
    }
}


Console.WriteLine("************************************************");

Console.WriteLine("Matriz original");

for (int i = 0;i < 2; i++)
{
    for(int j = 0; j < 3; j++)
    {
        Console.Write($"{matriz[i,j]}\t");
    }
    Console.WriteLine();
}


Console.WriteLine("************************************************");
Console.WriteLine("Matriz transposta");

for(int i = 0; i<3; i++)
{
    for(int j = 0; j<2; j++)
    {
        Console.Write($"{transposta[i,j]}\t");

    }
    Console.WriteLine();
}



