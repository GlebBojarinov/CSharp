//int n = 10;
int[] array = { 11, 57, 98, 33, 66, 77, 88, 44, 7, 8 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
