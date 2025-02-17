class BubbleSort
{
    static void Main()
    {
        int[] array = { 163, 10468, 468, 5257, 58, 864, 1005, 7 };
        int temp;

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int sort = 0; sort < array.Length - 1 - i; sort++)
            {
                if (array[sort] > array[sort + 1])
                {
                    temp = array[sort + 1];
                    array[sort + 1] = array[sort];
                    array[sort] = temp;
                }
            }
        }
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}