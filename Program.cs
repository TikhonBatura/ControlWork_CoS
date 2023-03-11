internal class Program
{
    private static void Main(string[] args)
    {
        string[] array = new string[4];

        for (int i = 0; i < array.Length; i++)
        {
            System.Console.WriteLine("Please enter something: ");
            array[i] = System.Console.ReadLine();
        }
        System.Console.WriteLine();
        System.Console.Write("Entered array: ");
        PrintArray(array);
        System.Console.WriteLine();
        System.Console.Write("Result array: ");
        PrintArray(showStringLessThree(array));

        void PrintArray(string[] array)
        {
            int count = array.Length;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{array[i]}" + " ");
            }
            Console.WriteLine();
        }
        string[] showStringLessThree(string[] array)
        {
            string[] resultArray = new string[array.Length];
            int length;
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                length = array[i].Length;

                if (length < 4 && length > 0)
                {
                    string v = array[i];
                    resultArray[j] = v;
                    j++;
                }
            }
            return resultArray;
        }
    }
}

