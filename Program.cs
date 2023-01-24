namespace Array_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[] { 15, 12, -6, 8, -9, 12, 0 };
            Console.WriteLine("Задан массив:");
            foreach (int i in array1)
            {
                Console.Write(i + "\t");
            }

           
            int temp;
            int count_up = 0;
            for (int i = 0; i < array1.Length - 1; i++)
            {
                for (int j = i + 1; j < array1.Length; j++)
                {
                    if (array1[i] > array1[j])
                    {
                        temp = array1[i];
                        array1[i] = array1[j];
                        array1[j] = temp;
                        count_up++;
                    }
                }
            }
            Console.WriteLine("\n\n\nОтсортированный массив по возрастанию:");
            foreach (int i in array1)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine($"\nКоличество операций по обмену элементов местами: {count_up}");

            
            var array2 = new int[] { 15, 12, -6, 8, -9, 12, 0 };
            int count_down = 0;
            for (int i = 0; i < array2.Length - 1; i++)
            {
                for (int j = i + 1; j < array2.Length; j++)
                {
                    if (array2[i] < array2[j])
                    {
                        temp = array2[i];
                        array2[i] = array2[j];
                        array2[j] = temp;
                        count_down++;
                    }
                }
            }
            Console.WriteLine("\n\nОтсортированный массив по убыванию:");
            foreach (int i in array2)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine($"\nКоличество операций по обмену элементов местами: {count_down}");
        }
    }
}