using System;

class Program
{
    static void Main()
    {
        var GetFiltered = (int[] arr, Func<int, bool> filter) => arr.Where(item => filter(item)).ToArray();
        var Print = (int[] arr) =>
        {
            foreach (int i in arr)
                Console.Write($"[{i}], ");
        };
        //

        int[] array = new int[] { 1, 2, 3, 5, 6, 11, 12, 13, 14, 22, 23, 33, 44, 55 };
        int[] evenArray = GetFiltered(array, num => (num % 2 == 0));
        int[] notEvenArray = GetFiltered(array, num => (num % 2 != 0));
        int[] has3Array = GetFiltered(array, num =>
        {
            do
            {
                if (num % 10 == 3)
                    return true;
                num /= 10;
            } while (num > 0);
            return false;
        });
        int[] hasSameNumberArray = GetFiltered(array, num =>
        {
            while (num > 9)
            {
                if (!(num % 10 == num % 100 / 10))
                    return false;
                num /= 10;
            }
            return true;
        });
        //
        System.Console.WriteLine("Original array items:");
        Print(array);
        System.Console.WriteLine("\n********************");
        System.Console.WriteLine("Even array items:");
        Print(evenArray);
        System.Console.WriteLine("\n********************");
        System.Console.WriteLine("Not even array items:");
        Print(notEvenArray);
        System.Console.WriteLine("\n********************");
        System.Console.WriteLine("Has 3 array items:");
        Print(has3Array);
        System.Console.WriteLine("\n********************");
        System.Console.WriteLine("Has same number array items:");
        Print(hasSameNumberArray);
        System.Console.WriteLine("\n********************");

    }
}