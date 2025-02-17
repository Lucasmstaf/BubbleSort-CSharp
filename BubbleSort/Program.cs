class BubbleSort
{
    static void Main()
    {
        int[] arr = { 163, 10468, 468, 5257, 58, 864, 1005, 7 };
        int temp;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int sort = 0; sort < arr.Length - 1 - i; sort++)
            {
                if (arr[sort] > arr[sort + 1])
                {
                    temp = arr[sort + 1];
                    arr[sort + 1] = arr[sort];
                    arr[sort] = temp;
                }
            }
        }
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
