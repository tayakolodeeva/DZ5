// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

ArrayRandomNumbers(array);// Заполнение массива числами.Вывод созданного массива на экран.
OddIndexSum(array); // Вычисление суммы чисел с нечетным индексом.

void ArrayRandomNumbers(int[] array) 
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(-100,100);
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write(" ] - созданный массив,");
}
void OddIndexSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (i%2>0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine($" сумма чисел с нечетным индексом ( {sum} )");
}