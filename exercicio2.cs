/// Elabore um programa em C# que declare uma matriz 2x4 de números inteiros preenchida com valores fixos. 
/// Percorra todos os elementos da matriz utilizando loops aninhados, some todos os valores guardados nela e exiba o resultado total ao final.
int acumulador = 0;

int[,] matriz = {
{50,50,50,50},
{50,50,50,50}


};

for(int i = 0; i < 2 ; i++)
{

    for(int j = 0; j < 4 ; j++)
    {
        acumulador += matriz[i, j];
    }
}

Console.Write($"Resultado total: {acumulador}");
