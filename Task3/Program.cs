// Задача 57. Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] InputMatrix()
{
    Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] MatrixInLine(int[,] matrix)
{
    int[] res = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int pos = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            res[pos++] = matrix[i, j];
        }
    }
    return res;
}

void ReleaseArray(int[] array)
{
    Array.Sort(array);
    Console.WriteLine(String.Join(", ", array));    
    int count = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1]) count++;
        else 
        {
            Console.WriteLine($"Элемент {array[i]} встречается {++count} раз");
            count = 0;
        }
    }
    if (array[array.Length - 1] != array[array.Length - 2]) {
        Console.WriteLine($"Элемент {array[array.Length - 1]} встречается 1 раз");
    } 
}

Console.Clear();
int[,] matrix = InputMatrix();
PrintMatrix(matrix);
int[] array = MatrixInLine(matrix);
Console.WriteLine(String.Join(", ", array));
ReleaseArray(array);