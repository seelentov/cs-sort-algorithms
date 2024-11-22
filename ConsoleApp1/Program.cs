﻿internal class Program
{
    private static void Main(string[] args)
    {
        int[] worst = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0];
        Write(worst);

        Console.WriteLine("Bubble");
        BubbleSort(worst.Clone() as int[]);
        Console.WriteLine();

        Console.WriteLine("Insertion");
        InsertionSort(worst.Clone() as int[]);
        Console.WriteLine();

    }

    /*
    Пузырьковая сортировка — это простой алгоритм сортировки, который работает путем многократной замены соседних элементов, если они расположены в неправильном порядке. Он получил свое название потому, что на каждой итерации самый большой элемент «всплывает» на свое правильное место. Этот процесс замены продолжается до тех пор, пока весь список не будет отсортирован в порядке возрастания. Основные шаги алгоритма таковы: начиная с начала списка, сравнивайте каждую пару соседних элементов и меняйте их местами, если они расположены в неправильном порядке, а затем проходите по списку до тех пор, пока замены не перестанут нужны. Однако, несмотря на свою простоту, пузырьковая сортировка не подходит для больших наборов данных, поскольку ее наихудшая и средняя временная сложность равна O(n²), где n — количество сортируемых элементов.
    */
    private static int[] BubbleSort(int[] arr, int step = 0)
    {
        for (int i = arr.Length; i >= 0; i--)
        {
            for (int j = 1; j < i; j++)
            {
                if (arr[j - 1] > arr[j])
                    (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);

                Write(arr, $"(i = {i}, j = {j}, step = {++step})");
            }
        }

        return arr;
    }

    /*
    Сортировка вставками — это простой алгоритм сортировки, который создает окончательный отсортированный массив (или список) по одному элементу за раз. Для больших списков он гораздо менее эффективен, чем более продвинутые алгоритмы, такие как быстрая сортировка, пирамидальная сортировка или сортировка слиянием. Тем не менее, он дает несколько преимуществ, таких как простота понимания алгоритма, он хорошо работает с небольшими списками или списками, которые уже частично отсортированы, и может сортировать список по мере его получения. Алгоритм выполняет итерацию, потребляя один входной элемент при каждом повторении и увеличивая отсортированный выходной список. На каждой итерации он удаляет один элемент из входных данных, находит место, которому он принадлежит, в отсортированном списке и вставляет его туда. Это повторяется до тех пор, пока не останется ни одного входного элемента.
    */
    private static int[] InsertionSort(int[] arr, int step = 0)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (arr[j - 1] > arr[j])
                {
                    (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
                    Write(arr, $"(i = {i}, j = {j}), step = {++step}");
                }
                else
                {
                    break;
                }
            }
        }

        return arr;
    }

    public static void Write(int[] arr, string stat = "")
    {
        Console.Write('[');

        for (int i = 0; i < arr.Length; i++)
        {
            int curr = arr[i];
            Console.Write(curr);
            if (i != arr.Length - 1)
                Console.Write(", ");
        }

        Console.Write(']');
        Console.Write(' ');
        Console.Write(stat);
        Console.WriteLine();
    }

}