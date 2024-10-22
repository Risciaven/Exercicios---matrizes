/*
2.	 Escrever um programa para armazenar valores inteiros em uma matriz qualquer
[1..5, 1..6]. A seguir, calcular a média dos valores pares contidos na matriz e
escrever todo o conteúdo da mesma. 
*/

var Matrix = new int[5, 6];

var EvenSum = 0;

var EvenCount = 0;

for (int Y = 0; Y < Matrix.GetLength(0); Y += 1)
{
    for (int X = 0; X < Matrix.GetLength(1); X += 1)
    {
        Matrix[Y, X] = X + Y;

        if(Matrix[Y, X]%2 == 0)
        {
            EvenSum += Matrix[Y, X];
            
            EvenCount += 1;
        }
    }
}

Console.WriteLine("Os valores da matriz gerada são:");

for(int i = 0; i < Matrix.GetLength(0); i += 1)
{
    for (int j = 0; j < Matrix.GetLength(1); j += 1)
    {
        if(j == Matrix.GetLength(1) - 1)
        {
            Console.WriteLine(Matrix[i, j]);
        }
        else
        {
            Console.Write(Matrix[i, j]);
        }
    }
}

float EvenAver = EvenSum / (float)EvenCount;

Console.WriteLine($"Desses números, {EvenCount} são pares, sua soma é {EvenSum}, e sua média, {EvenAver}");

Console.ReadKey();

/*
Escrever um programa para ler uma matriz qualquer [1..7, 1..4] contendo valores inteiros
(supor que os valores são distintos). Após, encontrar o menor valor contido na matriz e sua posição.
*/

var Matrix2 = new int[7, 4];

int SmallestNum = 0;

var SmallPos = new int[2]{0, 0};

var random = new Random();

for(int Y = 0; Y < Matrix2.GetLength(0); Y += 1)
{
    for(int X = 0; X < Matrix2.GetLength(1); X += 1)
    {
        Matrix2[Y, X] = random.Next(100);

        if(Y == 0 && X == 0)
        {
            SmallestNum = Matrix2[Y, X];

            continue;
        }

        if(Matrix2[Y, X] <= SmallestNum)
        {
            SmallestNum = Matrix2[Y, X];

            SmallPos[0] = Y;

            SmallPos[1] = X;
        }
    }
}

for(int i = 0; i < Matrix2.GetLength(0); i += 1)
{
    for(int j = 0; j < Matrix2.GetLength(1); j += 1)
    {
        if(j == Matrix2.GetLength(1) - 1)
        {
            Console.WriteLine($"{Matrix2[i, j]}");
        }
        else
        {
            Console.Write($"{Matrix2[i, j]} ");
        }
    }
}

Console.WriteLine($"Da matriz feita, o menor número é {SmallestNum}, na posição {SmallPos[0]},{SmallPos[1]}");

Console.ReadKey();

/*
4.	 Escrever um programa que lê uma matriz M[1..5, 1..5] e cria 2 vetores SL(5), SC(5) que
contenham respectivamente as somas das linhas (SL) e das colunas (SC) de M. Escrever a matriz
e os vetores criados. 
*/

var Matrix3 = new float[5, 5];

var SL = new float[Matrix3.GetLength(0)];

var SC = new float[Matrix3.GetLength(1)];

for(int Y = 0; Y < Matrix3.GetLength(0); Y += 1)
{
    for(int X = 0; X < Matrix3.GetLength(1); X += 1)
    {
        Matrix3[Y, X] = random.Next(25);

        SL[Y] += Matrix3[Y, X];

        SC[X] += Matrix3[Y, X];
    }   
}

Console.WriteLine($"A matriz formada foi a seguir:");

for(int i = 0; i < Matrix3.GetLength(0); i += 1)
{
    for(int j = 0; j < Matrix3.GetLength(1); j += 1)
    {
        if(j == Matrix3.GetLength(1) - 1)
        {
            Console.WriteLine(Matrix3[i, j]);
        }
        else
        {
            Console.Write(Matrix3[i, j] + " ");
        }
    }
}

Console.WriteLine("Levando esses números em consideração, as somas das linhas e colunas é:");

Console.Write("Linhas: ");

for(int i = 0; i < SL.Length; i += 1)
{
    if(i == SL.Length - 1)
    {
        Console.WriteLine($"{SL[i]}.");
    }
    else
    {
        Console.Write($"{SL[i]}, ");
    }
}

Console.Write("Colunas: ");

for(int i = 0; i < SC.Length; i += 1)
{
    if(i == SC.Length - 1)
    {
        Console.WriteLine($"{SC[i]}.");
    }
    else
    {
        Console.Write($"{SC[i]}, ");
    }
}

Console.ReadKey();

/*
Escrever um programa que lê duas matrizes N1[1..4, 1..6] e N2[1..4, 1..6] e cria: 
a) Uma matriz M1 que seja a soma de N1 e N2
b) Uma matriz M2 que seja a diferença de N1 com N2
Escrever as matrizes lidas e calculadas. 
*/

var Matrix4A = new int[6, 4];

var Matrix4B = new int[Matrix4A.GetLength(0), Matrix4A.GetLength(1)];

var Matrix4C = new int[Matrix4A.GetLength(0), Matrix4A.GetLength(1)];

var Matrix4D = new int[Matrix4A.GetLength(0), Matrix4A.GetLength(1)];

for(int Y = 0; Y < Matrix4A.GetLength(0); Y += 1)
{
    for(int X = 0; X < Matrix4A.GetLength(1); X += 1)
    {
        Matrix4A[Y, X] = X + Y;
    }
}

for(int Y = 0; Y < Matrix4A.GetLength(0); Y += 1)
{
    for(int X = 0; X < Matrix4A.GetLength(1); X += 1)
    {
        Matrix4B[Y, X] = X + Y;

        Matrix4C[Y, X] = Matrix4A[Y, X] + Matrix4B[Y, X];

        Matrix4D[Y, X] = Matrix4A[Y, X] - Matrix4B[Y, X];
    }
}

Console.WriteLine("As matrizes feitas são as seguintes:");

Console.WriteLine("A primeira:");

for(int i = 0; i < Matrix4A.GetLength(0); i += 1)
{
    for(int j = 0; j < Matrix4A.GetLength(1); j += 1)
    {
        if(j == Matrix4A.GetLength(1) - 1)
        {
            Console.WriteLine (Matrix4A[i, j]);
        }
        else
        {
            Console.Write(Matrix4A[i, j] + " ");
        }
    }
}

Console.WriteLine("A segunda:");

for(int i = 0; i < Matrix4B.GetLength(0); i += 1)
{
    for(int j = 0; j < Matrix4B.GetLength(1); j += 1)
    {
        if(j == Matrix4B.GetLength(1) - 1)
        {
            Console.WriteLine (Matrix4B[i, j]);
        }
        else
        {
            Console.Write(Matrix4B[i, j] + " ");
        }
    }
}
Console.WriteLine("A terceira:");

for(int i = 0; i < Matrix4C.GetLength(0); i += 1)
{
    for(int j = 0; j < Matrix4C.GetLength(1); j += 1)
    {
        if(j == Matrix4C.GetLength(1) - 1)
        {
            Console.WriteLine (Matrix4C[i, j]);
        }
        else
        {
            Console.Write(Matrix4C[i, j] + " ");
        }
    }
}

Console.WriteLine("A quarta (diferença entre as duas primeiras):");

for(int i = 0; i < Matrix4D.GetLength(0); i += 1)
{
    for(int j = 0; j < Matrix4D.GetLength(1); j += 1)
    {
        if(j == Matrix4D.GetLength(1) - 1)
        {
            Console.WriteLine (Matrix4D[i, j]);
        }
        else
        {
            Console.Write(Matrix4D[i, j] + " ");
        }
    }
}

Console.ReadKey();

/*
6.	 Leia uma matriz 6 x 6, conte e escreva quantos valores maiores que 10 ela possui. 
*/

var Matrix6 = new int[6, 6];

var BigNum = new List<int>();

var BigPosX = new List<int>();

var BigPosY = new List<int>();

for(int Y = 0; Y < Matrix6.GetLength(0); Y += 1)
{
    for(int X = 0; X < Matrix6.GetLength(1); X += 1)
    {
        // Console.WriteLine($"Qual o {X}º número da {Y}ª linha?");

        // var input = Console.ReadLine();

        // if(!int.TryParse(input, out Matrix[Y, X]))
        // {
        //     return;
        // }
        
        Matrix6[Y, X] = (2 * X) + (2 * Y);

        if(Matrix6[Y, X] > 10)
        {
            BigNum.Add(Matrix6[Y, X]);
            
            BigPosX.Add(X);

            BigPosY.Add(Y);
        }
    }
}

Console.WriteLine("Os valores da matriz formada são:");

for(int i = 0; i < Matrix6.GetLength(0); i += 1)
{
    for(int j = 0; j < Matrix6.GetLength(1); j += 1)
    {
        if(j == Matrix6.GetLength(1) - 1)
        {
            Console.WriteLine(Matrix6[i, j]);
        }
        else
        {
            Console.Write(Matrix6[i, j] + " ");
        }
    }
}

if(BigNum.Count > 0)
{
    Console.WriteLine($"Nessa matrix, {BigNum.Count} números são maiores que 10. Sendo eles: ");
}

for(int i = 0; i < BigNum.Count; i += 1)
{
    if(i == BigNum.Count - 1)
    {
        Console.WriteLine($"e {BigNum[i]}, na posição {BigPosX[i]}, {BigPosY[i]}.");
    }
    else
    {
        Console.WriteLine($"{BigNum[i]}, na posição {BigPosX[i]}, {BigPosY[i]}; ");
    }
}

Console.ReadKey();

/*
7. Leia uma matriz 4 x 3. Leia também um valor X. O programa deverá fazer uma busca desse
valor na matriz e, ao final escrever a localização (linha e coluna) ou uma mensagem de “não
encontrado”. A leitura da matriz deverá ser realizada apenas uma única vez, porém a leitura
de X e sua busca na matriz deverá ser repetida até que o usuário digite um número negativo. 
*/

var Matrix7 = new int[3, 4];

var Num = 4;

var NumPosX = new List<int>();

var NumPosY = new List<int>();

for(int Y = 0; Y < Matrix7.GetLength(0); Y += 1)
{
    for(int X = 0; X < Matrix7.GetLength(1); X += 1)
    {
        Matrix7[Y, X] = random.Next(10);

        if(Matrix7[Y, X] == Num)
        {
            NumPosX.Add(X);

            NumPosY.Add(Y);
        }
    }
}


for(int i = 0; i < Matrix7.GetLength(0); i += 1)
{
    for(int j = 0; j < Matrix7.GetLength(1); j += 1)
    {
        if(j == Matrix7.GetLength(1) - 1)
        {
            Console.WriteLine($"{Matrix7[i, j]}");
        }
        else
        {
            Console.Write($"{Matrix7[i, j]} ");
        }
    }
}

var question = "Please type a number for me to fetch (or type anything below 0 to stop)";

Console.WriteLine(question);

var input = Console.ReadLine();
Num = int.Parse(input);

while (Num > 0)
{
    var found = false;

    for (var i = 0; i < Matrix7.GetLength(0); i++)
    {
        for (var j = 0; j < Matrix7.GetLength(1); j++)
    {
            if (Matrix7[i, j] == Num)
            {
                found = true;
                Console.WriteLine($"Num Found on coordinates [{i}, {j}]");
        }
        }
    }

    // if statements always wants a true
    if (!found)
        // if code got in here, the condition above was true, but for that, found must be false
        Console.WriteLine($"Number {Num} is not on the Matrix. Try again!\n");

    Console.WriteLine(question);

    input = Console.ReadLine();
    Num = int.Parse(input);
}

Console.ReadKey();

/*
8.	 Leia uma matriz 5 x 2 e escreva a localização (linha e a coluna) do maior valor. 
*/

var Matrix8 = new int[2, 5];

var BiggestNum = 0;

var BiggestPosX = 0;

var BiggestPosY = 0;



for(int Y = 0; Y < Matrix8.GetLength(0); Y += 1)
{
    for(int X = 0; X < Matrix8.GetLength(1); X += 1)
    {
        Matrix8[Y, X] = X + Y;

        if(X > 0 || Y > 0)
        {
            if(Matrix8[Y, X] > BiggestNum)
            {
                BiggestNum = Matrix8[Y, X];

                BiggestPosX = X;

                BiggestPosY = Y;
            }
        }
        else
        {
            BiggestNum = Matrix8[Y, X];

            BiggestPosX = 0;
            
            BiggestPosY = 0;
        }
    }
}

for(int i = 0; i < Matrix8.GetLength(0); i += 1)
{
    for(int j = 0; j < Matrix8.GetLength(1); j += 1)
    {
        if(j == Matrix8.GetLength(1) - 1)
        {
            Console.WriteLine(Matrix8[i, j]);
        }
        else
        {
            Console.Write($"{Matrix8[i, j]} ");
        }
    }
}

Console.WriteLine($"Da matriz criada, o maior número é {BiggestNum}, localizado na posição {BiggestPosX}, {BiggestPosY}");

Console.ReadKey();

/*
11.	Escreva um programa que lê uma matriz M[1..5, 1..5]. Substitua, a seguir, todos os
valores negativos da matriz pelo seu módulo. Exemplo: substitua -2 por 2, -16 por 16, assim por diante. 
*/

var Matrix11 = new int[5, 5];

for(int Y = 0; Y < Matrix11.GetLength(0); Y += 1)
{
    for(int X = 0; X < Matrix11.GetLength(1); X += 1)
    {
        Matrix11[Y, X] = X - Y;
    }
}

for(int i = 0; i < Matrix11.GetLength(0); i += 1)
{
    for(int j = 0; j < Matrix11.GetLength(1); j += 1)
    {
        if(j == Matrix11.GetLength(1) - 1)
        {
            Console.WriteLine($"{Matrix11[i, j]}");
        }
        else
        {
            Console.Write($"{Matrix11[i, j]} ");
        }
    }
}

Console.WriteLine("Convertendo números negativos...");

for(int i = 0; i < Matrix11.GetLength(0); i += 1)
{
    for(int j = 0; j < Matrix11.GetLength(1); j += 1)
    {
        if(Matrix11[i, j] < 0)
        {
            Matrix11[i, j] = Matrix11[i, j] * (- 1);
        }
    }
}

for(int i = 0; i < Matrix11.GetLength(0); i += 1)
{
    for(int j = 0; j < Matrix11.GetLength(1); j += 1)
    {
        if(j == Matrix11.GetLength(1) - 1)
        {
            Console.WriteLine($"{Matrix11[i, j]}");
        }
        else
        {
            Console.Write($"{Matrix11[i, j]} ");
        }
    }
}
