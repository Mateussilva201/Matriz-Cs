using System.Runtime.Serialization;

/// Crie uma matriz quadrada 3x3 preenchida com números inteiros. 
/// Escreva um algoritmo que percorra a matriz e calcule apenas a soma dos elementos da diagonal principal 
/// (ou seja, os elementos onde a linha é igual à coluna: matriz[0,0], matriz[1,1] e matriz[2,2]). Exiba o valor da soma ao final.
/// 
int soma = 0;

int[,] matriz =
{
    {9,3,5},
    {6,2,7},
    {7,2,5}
};

for (int i = 0; i < 3; i++)
{

    soma += matriz[i, i];


}


Console.WriteLine($"Resultado da soma é: {soma}");
