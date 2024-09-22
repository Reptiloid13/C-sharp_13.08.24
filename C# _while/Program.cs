class Program
{
    static void Main()
    {
        ArrayTask1();
    }

    static void ArrayTask1()
    {
        /* На ввод поступает массив размером n. Увеличьте каждый четный элемент массива на единицу. 5 5 5 9 8 3 */

        int[] array = { 5, 5, 9, 8, 3 };

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
                array[i] += 1;
        }

        Console.Write(string.Join(", ", array));
    }

    /* На ввод поступает массив размером n. Увеличьте каждый четный элемент массива на единицу.   */
}