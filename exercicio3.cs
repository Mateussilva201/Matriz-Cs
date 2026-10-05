/// Crie um programa em C# que crie uma matriz 3x3 preenchida com números inteiros definidos no código. 
/// Peça para o usuário digitar um número que ele deseja procurar. O programa deve percorrer a matriz inteira 
/// e informar se o número foi encontrado, exibindo a sua exata posição em coordenadas [linha, coluna]. 
/// Se o número não estiver na matriz, exiba uma mensagem de "Não encontrado".
bool existe = false;


int[,] matriz =
{
  {5,9,7},
  {3,4,5},
  {1,5,4},

};



Console.Write("Procurar número dentro da matriz: ");
int numeroProcurado = int.Parse(Console.ReadLine());


for (int i = 0; i < 3; i++)
{

    for (int j = 0; j < 3; j++)
    {
if (matriz[i,j] == numeroProcurado)
        {
            Console.WriteLine($"Número {numeroProcurado} encontrado na Posição: [{i},{j}]");
            existe = true;
        }



    }

}


if (!existe)
{
    Console.WriteLine($"Número {numeroProcurado} não existe na matriz, tente outro número");
}
