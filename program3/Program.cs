// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = new double[size];

ArrayRandomNumbers(array);// Заполнение массива числами.Вывод созданного массива на экран.
DifferenceOfNumbers(array);//Нахождение max и min числа, вычисление разницы. 

void ArrayRandomNumbers(double[] array) 
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().NextDouble()*200;
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write(" ] - созданный массив,");
}
void DifferenceOfNumbers(double[] array)
{
    double max = array[1];
    double min = array[1];
    double difference = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    difference = (max - min);
    Console.WriteLine($" разница между максимальным и минимальным элементом массива ( {difference} )");
}