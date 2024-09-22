class Program
{
    static void Main()
    {
        Massive1();
    }

    static void Massive1()
    {
        /* На ввод поступает массив размером n. Увеличьте каждый четный элемент массива на единицу. 5 5 5 9 8 3 */

        int[] array = { 5, 5, 9, 8, 3 };
        int result = 1;
        int chet;

        for (int i = 0; i > array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                result = array[i] + result;
            }
        }

        Console.WriteLine(result);
    }

    /* На ввод поступает массив размером n. Увеличьте каждый четный элемент массива на единицу.   */
}