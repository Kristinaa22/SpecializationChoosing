// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.


int sizeArr = ReadInt("Сколько элементов в массиве: ");
string[] arr = new string[sizeArr];
FillArray(sizeArr, arr);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Новый массив:");
for(int i = 0; i < sizeArr; i++)
{
    int elementLenght = SymbolsQuantity(arr[i]);
    if(elementLenght <= 3)
    {
        Console.Write(arr[i] + " ");
    }
}


// functions
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArray(int size, string[] array)
{
    Console.WriteLine("Введите элементы массива: ");
    for(int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}

int SymbolsQuantity(string sym)
{
    int lenght = sym.Length;
    return lenght;
}
