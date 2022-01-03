void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(-100,100);
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(array[position]);
        position++;

    }
}
int[] array = new int[4];
FillArray(array);
PrintArray(array);

Console.WriteLine(); //Строка, чтобы разделить 2 массива

int n = array.Length;
int index = 0;
while (index < n)
{
    if (array[index] % 2 == 0)
    {
        array[index]=array[index];
        
    }
    else 
    {
        array[index]=0;
    }
    index++;
}
PrintArray(array); //Не смог придумать, как не выводить в консоль нули, поэтому нечетные числа в массиве выводятся нулями